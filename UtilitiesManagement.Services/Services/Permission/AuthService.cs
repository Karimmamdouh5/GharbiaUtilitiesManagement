using UtilitiesManagement.Services.IServices.StaticData;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using UtilitiesManagement.Services.IServices;
using UtilitiesManagement.DataAccess.DataContext;
using GharbiaUtilitiesManagement.DataAccess.Repositories.ExternalORMs;

namespace UtilitiesManagement.Services.Services.Permission

{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly JwtSettings _jwt;
        private readonly IAlignCompanyRepository _alignCompanyRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<AuthService> _logger;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;
        private readonly IHttpContextAccessor _accessor;
        private readonly IMapper _mapper;
        private readonly IStaticDataServices _staticServices;
        private readonly ISharedServices _sharedServices;

        public IAlignCompanyRepository AlignCompany { get; }

        public AuthService(UserManager<ApplicationUser> userManager, 
                           RoleManager<ApplicationRole> roleManager, IOptions<JwtSettings> jwt,
                           IAlignCompanyRepository alignCompanyRepository, IUnitOfWork unitOfWork,
                           ILogger<AuthService> logger, IStringLocalizer<SharedResource> sharLocalizer
                           , IHttpContextAccessor accessor, IMapper mapper, IStaticDataServices staticServices ,
                           ISharedServices sharedServices, IAlignCompanyRepository alignCompany)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _jwt = jwt.Value;
            _alignCompanyRepository = alignCompanyRepository;
           _unitOfWork=unitOfWork;
            _logger = logger; 
            _sharLocalizer = sharLocalizer;
            _accessor = accessor;
            _mapper = mapper;
            _staticServices = staticServices;
            _sharedServices = sharedServices;
            AlignCompany = alignCompany;
        }
        public async Task<string> CheckConnection()
        {
            var Error = new StringBuilder();
            try
            {
                var checkingUtilityDataBase = await _unitOfWork.Users.GetFirstOrDefaultAsync(filter: x => true);
            }
            catch (Exception)
            {
                Error.Append("UtilitiesConnection Failed................");
            }
            try
            {
                var checkingLoggingDataBase = AlignCompany.GetCompanyLinkAndVersionAsync("Elhoceny");
            }
            catch (Exception)
            {
                Error.Append("AlignCompanyDataBase Failed................");
            }
            try
            {
                var checkingOracleConnection = OracleConnectionManager.GetConnection();
                OracleConnectionManager.CloseConnection(checkingOracleConnection);

            }
            catch (Exception)
            {
                Error.Append("OracleConnection Failed................");
            }
            return Error.ToString();
        }
        public async Task<AuthResponse> RegisterAsync(RegisterRequest model)
        {
            var existingEmail = await _userManager.FindByEmailAsync(model.Email);

            if (existingEmail is not null)
            {
                return new AuthResponse
                {
                    Errors = new string[] { _sharLocalizer[SDLocalization.UserWithEmailExists] },
                };
            }

            var existingName = await _userManager.FindByNameAsync(model.UserName);

            if (existingName is not null)
            {
                return new AuthResponse
                {
                    Errors = new string[] { _sharLocalizer[SDLocalization.UserWithNameExists] },

                };
            }

            var newUserId = Guid.NewGuid();
            var newUser = new ApplicationUser
            {
                Id = newUserId.ToString(),
                Email = model.Email,
                UserName = model.UserName,
                UserType_Id = model.UserType_Id
            };

            bool roleExist = await _roleManager.RoleExistsAsync(Roles.User.ToString());
            if (!roleExist)
            {

                var role = new ApplicationRole();
                role.Name = Roles.User.ToString();

                var createRole = await _roleManager.CreateAsync(role);
                if (!createRole.Succeeded)
                {
                    return new AuthResponse
                    {
                        Errors = createRole.Errors.Select(x => x.Description).ToArray()
                    };
                }
            }

            var createdUser = await _userManager.CreateAsync(newUser, model.Password);

            if (!createdUser.Succeeded)
            {
                return new AuthResponse
                {
                    Errors = createdUser.Errors.Select(x => x.Description).ToArray()
                };
            }



            await _userManager.AddToRoleAsync(newUser, Roles.User.ToString());

            var jwtSecurityToken = await CreateJwtToken(newUser);

            return new AuthResponse
            {
                UserId = newUser.Id,
                Email = newUser.Email,
                ExpiresOn = jwtSecurityToken.ValidTo,
                IsAuthenticated = true,
                Roles = new List<string> { Roles.User.ToString() },
                Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
                UserName = newUser.UserName
            };
        }

        private async Task<bool> CheckIfCompanyActive(string CompanyCode)
        {
            return  await _alignCompanyRepository.ExistAsync(x => x.IsActive && !x.IsDeleted
                                                              && DateTime.UtcNow.AddHours(2).Date >= x.StartDate.Date
                                                              && DateTime.UtcNow.AddHours(2).Date <= x.EndDate!.Value.Date
                                                              && x.CompanyCode.ToLower() == CompanyCode.ToLower());
        }

        public async Task<Response<CompanyConfigurationResponse>> CheckCompanyActivationAndVersionAsync(string companyCode)
        {
            try
            {
                if (!await _alignCompanyRepository.ExistAsync(x => x.IsActive
                                                               && DateTime.UtcNow.AddHours(2).Date >= x.StartDate.Date
                                                               && DateTime.UtcNow.AddHours(2).Date <= x.EndDate!.Value.Date
                                                               && x.CompanyCode == companyCode))
                {
                    return new Response<CompanyConfigurationResponse>()
                    {
                        Errors = new List<string>()
                    {
                       _sharLocalizer[SDLocalization.CompanyIsNotActivated]
                    }
                    };
                }
                return await _alignCompanyRepository.GetCompanyLinkAndVersionAsync(companyCode);
            }
            catch (Exception ex)
            {

                return new Response<CompanyConfigurationResponse>()
                {
                    Errors = new List<string> { ex.Message }
                };
            }
            
        }

      
        public async Task<AuthResponse> GetTokenAsync(LoginRequest model)
        {
            try
            {
                if (!await CheckIfCompanyActive(model.CompanyCode))
                    return new AuthResponse()
                    {
                        Errors = new List<string>()
                        {
                          _sharLocalizer[SDLocalization.CompanyIsNotActivated]
                        }
                    };

                var user = await _unitOfWork.Users.GetTheUser(model.CompanyCode,model.UserName);
                if (user == null)
                    return new AuthResponse
                    {
                        Errors = new List<string> { _sharLocalizer[SDLocalization.UserNotExist].Value }
                    };
                if (user.UserType?.Name == "tech" && user.Employee.IsTechnician == false)
                {
                    return new AuthResponse
                    {
                        Errors = new List<String> { _sharLocalizer[SDLocalization.ThisEmployeeIsNotTechnician] },

                    };
                }
                if (user is null || !await _userManager.CheckPasswordAsync(user, model.Password))
                {
                    return new AuthResponse
                    {
                        Errors = new List<String> { _sharLocalizer[SDLocalization.Email_Password_Incorrect] },

                    };

                }

                
                var jwtSecurityToken = await CreateJwtToken(user);

                #region add online refrence
                if (await _unitOfWork.OnlineUsers.AnyAsync(x => x.UserId == user.Id && x.AndroidId !=
                model.AndroidId && !x.IsDeleted, ignoreQueryFilters: true))
                    return new AuthResponse()
                    {
                        Errors = new List<string>
                        {
                            _sharLocalizer[SDLocalization.UserIsAlreadyLoggedIn]
                        }
                    };
                else
                {
                    var onlineRecords = await RemoveOldOnlineUsers(model, user);
                    if (onlineRecords is not null && onlineRecords.Any())
                        await _unitOfWork.CompleteAsync();
                }

                await AddOnlineUser(user, model.AndroidId!, jwtSecurityToken.ValidTo);
                await _unitOfWork.CompleteAsync();

                #endregion

                // var rolesList = await _userManager.GetRolesAsync(user);
                var rolesList = (await _unitOfWork.UserRoles.GetSpecificSelectAsync(filter: x => x.UserId == user.Id && !x.IsDeleted && !x.Role.IsDeleted, select: x => x.Role.Name)).ToList();

                var authModel = new AuthResponse();
                authModel.IsAuthenticated = true;
                authModel.Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
                authModel.Email = user.Email;
                authModel.UserName = user.UserName;
                authModel.ExpiresOn = jwtSecurityToken.ValidTo;

                authModel.Roles = rolesList.ToList();
                authModel.UserId = user.Id;
                authModel.CompanyId = user.Employee.Branch.Company_Id;
                authModel.branchId = user.Employee.Branch_Id;

                if (model.UserToken != null)
                {
                    user.UserToken = model.UserToken;
                    _unitOfWork.Users.Update(user);
                    await _unitOfWork.CompleteAsync();
                }

                return authModel;
            }

            catch (Exception ex)
            {
                string err = _sharLocalizer[SDLocalization.Error];
                _logger.LogError(ex, err);
                var authModel = new AuthResponse() { IsAuthenticated=false,Errors=new List<string>{ err } };
                return authModel;
            }
        }
      
        public async Task<Response<GetUserResponse>> GetUserDataAsync(string userId)
        {

            var FinalResult = new Response<GetUserResponse>();
            var user = await _unitOfWork.Users.GetFirstOrDefaultAsync(filter: x => x.Id == userId && !x.IsDeleted && x.IsActive ,ignoreQueryFilters:true,includeProperties: "Employee.Branch.Company");

            var UserActiveTechnecian = await _unitOfWork.Technicians.GetFirstOrDefaultAsync(filter: x => x.Employee.Users.Any(y => y.Id == userId) && x.IsActive, ignoreQueryFilters: true);

            if (user is null)
            {
                return new Response<GetUserResponse>
                {
                    IsSuccess = false,
                    Errors = new[] { SDLocalization.UserDataIsIncorrect },
                    Message = SDLocalization.UserDataIsIncorrect
                };
            }

            //var rolesList = await _userManager.GetRolesAsync(user);

            //var rolesList = (await _unitOfWork.UserRoles.GetSpecificSelectAsync(filter: x => x.UserId == user.Id && x.IsDeleted == false, select: y => y.Name)).ToList();


            var rolesList = new List<string>();

            var authModel = new GetUserResponse() {IsAuthenticated = true,
            Email = user.Email,
            UserName = user.UserName.Substring(user.UserName.LastIndexOf('_') + 1),
            FullName = user.Employee.Name,
            Technician_Id = UserActiveTechnecian == null ? null : UserActiveTechnecian.Id,
            Roles = rolesList,
            UserId = user.Id,
            CompanyId = user.Employee.Branch.Company_Id,
            branchId = user.Employee.Branch_Id,
            ImgPath=user.Employee.ImagePath,
            EmployeeId = user.Employee_Id,
            Technician= _mapper.Map<TechGetLastTechnician>(UserActiveTechnecian)
            

        };
          
            FinalResult.Data = authModel;
            FinalResult.IsSuccess = true;
            FinalResult.Message = _sharLocalizer[SDLocalization.Data] + user.UserName;
            FinalResult.Data.CompanyCode = user.Employee.Branch.Company.CompanyCode;
            FinalResult.Data.UserCode = user.Employee.Code;
            FinalResult.Data.Menu = await _sharedServices.GetMenu();
            return FinalResult;
        }

        private async Task<JwtSecurityToken> CreateJwtToken(ApplicationUser user)
        {
            var userClaims =  await _userManager.GetClaimsAsync(user);
            var UserData = await _unitOfWork.Users.GetFirstOrDefaultAsync(filter: y => y.Id == user.Id, includeProperties: "UserRoles,UserRoles.Role");
            //var roles = await _userManager.GetRolesAsync(user);
            //var RolesRelations = await _unitOfWork.UserRoles.GetAllAsync(filter: x => x.UserId == user.Id && x.IsDeleted == false,ignoreQueryFilters: true);
            var Roles = UserData.UserRoles.Where(x => !x.IsDeleted).Select(x => x.Role).Where(x => !x.IsDeleted);

            var roleClaims = new List<Claim>();
            roleClaims.AddRange(Roles.Select(x => new Claim("roles",x.Name)));
            var RolesClaims = (await _unitOfWork.RoleClaims.GetAllAsync(filter: x => Roles.Select(d => d.Id).Contains(x.RoleId) && !x.IsDeleted)).Select(x => x.ClaimValue).ToList();

            //*****************PermissionsFilteration*************************************

            var FullPermissions = RolesClaims.Where(x => x.Split(".")[3] == "Full").ToList();
            RolesClaims.RemoveAll(x => FullPermissions.Any(y => y.Split(".")[0] == x.Split(".")[0] && y.Split(".")[1] == x.Split(".")[1] && y.Split(".")[2] == x.Split(".")[2]));
            RolesClaims.AddRange(FullPermissions);
            //****************************************************************************

            roleClaims.AddRange(RolesClaims.Select(x => new Claim("Permission", x)));

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                //new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("uid", user.Id),
                new Claim("companyid", user.Employee.Branch.Company_Id.ToString()),
                new Claim("branchid", user.Employee.Branch_Id.ToString()),
            }
            .Union(userClaims)
            .Union(roleClaims);


            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.SecretKey));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwt.Issuer,
                claims: claims,
                expires: user!.UserType_Id != null? DateTime.UtcNow.AddHours(2).Add(user!.UserType!.TimeOfToken):DateTime.UtcNow.AddHours(2).Add(_jwt.TokenLifetime),
                signingCredentials: signingCredentials);
            return jwtSecurityToken;
        }
 
        public async Task LogOutAsync(Guid UserId)
        {         
            var x = UserId;        
        }

        private async Task<IEnumerable<PermOnlineUser>> RemoveOldOnlineUsers(LoginRequest request, ApplicationUser user)
        {
            var onlineRecords = await _unitOfWork.OnlineUsers.
                GetAllAsync(x => x.UserId == user.Id && (x.AndroidId == request.AndroidId || x.
                AndroidId == null) && !x.IsDeleted
                ,ignoreQueryFilters: true);

            if (onlineRecords is not null && onlineRecords!.ToList().Count != 0)
                _unitOfWork.OnlineUsers.RemoveRange(onlineRecords!);
            return onlineRecords!;
        }

        private async Task AddOnlineUser(ApplicationUser user, string androidId,DateTime ExpireOn)
        {
            await _unitOfWork.OnlineUsers.AddAsync(new PermOnlineUser()
            {
                BranchId = user.Employee.Branch_Id,
                UserId = user.Id,
                JobId = "0",
                InsertDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow,
                AndroidId = androidId,
                ExpireOn = ExpireOn,

            });
        }
        public async Task<Response<string>> LogoutAsync(string userId)
        {
            var users = await _unitOfWork.OnlineUsers.GetAllAsync(x => x.UserId == userId && !x.IsDeleted,
                ignoreQueryFilters: true);
            if (users is null || users.Count() == 0 )
            {
                return new Response<string>()
                {
                    IsSuccess = true,
                    IsNotFound = true,
                    Message= "",
                    Data= _sharLocalizer[SDLocalization.UserWasLoggedOutBefore],
                    Errors = new string[] { }
                };
            }

            try
            {
                 _unitOfWork.OnlineUsers.RemoveRange(users);
                //if (!string.IsNullOrEmpty(request.JobId))
                //    BackgroundJob.Delete(request.JobId);
                return new Response<string>()
                {
                   
                    IsNotFound = true,
                    Errors = new string[] { },
                    Data= _sharLocalizer[SDLocalization.UserIsLoggedOut],
                    Message = "" ,
                    IsSuccess = await _unitOfWork.CompleteAsync() > 0
                };
            }
            catch (Exception e)
            {
                var obj = JsonConvert.SerializeObject(userId);
                string err = _sharLocalizer[SDLocalization.Error];
                _logger.LogError(e, err);
                return new Response<string>()
                {
                    Errors = new string [] { err }
                };
            }
        }
        public async Task<Response<AuthUserRegisterResponse>> UserRegister(AuthResigterRequest resigterRequest)
        {
            try
            {
                var UserTypeName = _staticServices.GetUserTypeName(resigterRequest.UserType_Id);
                if (UserTypeName == null)
                {
                    return new Response<AuthUserRegisterResponse>()
                    {
                        Errors = new[] { string.Format(_sharLocalizer[SDLocalization.CannotBeFound, resigterRequest.UserType_Id]) },
                        Message = string.Format(_sharLocalizer[SDLocalization.CannotBeFound, resigterRequest.UserType_Id]),
                        IsSuccess = false
                    };
                }
                var Employee = await _unitOfWork.Employees.GetFirstOrDefaultAsync(filter: x => x.Id == resigterRequest.EmployeeId && !x.IsDeleted, ignoreQueryFilters: true, includeProperties: "Branch,Branch.Company");
                if (Employee == null)
                    return new Response<AuthUserRegisterResponse>()
                    {
                        Message = _sharLocalizer[SDLocalization.CannotBeFound, resigterRequest.EmployeeId],
                        IsSuccess = false
                    };
                if (Employee.IsTechnician == false && UserTypeName == "tech")
                {
                    return new Response<AuthUserRegisterResponse>()
                    {
                        Errors = new[] { string.Format(_sharLocalizer[SDLocalization.ThisEmployeeIsNotTechnician]) },
                        Message = string.Format(_sharLocalizer[SDLocalization.ThisEmployeeIsNotTechnician]),
                        IsSuccess = false
                    };
                }
                var UserNewObject = _mapper.Map<ApplicationUser>(resigterRequest);
                UserNewObject.Employee = null;
                UserNewObject.EmailConfirmed = true;
                UserNewObject.UserName = Employee.Branch.Company.CompanyCode + "_" + resigterRequest.UserName;
                if (await _unitOfWork.Users.ExistAsync(filter: x => x.UserName == resigterRequest.UserName))
                {
                    return new Response<AuthUserRegisterResponse>()
                    {
                        Errors = new[] { string.Format(_sharLocalizer[SDLocalization.IsExist, resigterRequest.UserName]) },
                        Message = string.Format(_sharLocalizer[SDLocalization.IsExist, resigterRequest.UserName]),
                        IsExists = true,
                        IsSuccess = false
                    };
                }
                else if (await _unitOfWork.Users.ExistAsync(filter: x => x.Email == resigterRequest.Email))
                {
                    return new Response<AuthUserRegisterResponse>()
                    {
                        Errors = new[] { string.Format(_sharLocalizer[SDLocalization.IsExist, resigterRequest.Email]) },
                        Message = string.Format(_sharLocalizer[SDLocalization.IsExist, resigterRequest.Email]),
                        IsExists = true,
                        IsSuccess = false
                    };
                }
                var Result = await _userManager.CreateAsync(UserNewObject, resigterRequest.Password);
                if (!Result.Succeeded)
                {

                    return new Response<AuthUserRegisterResponse>()
                    {
                        Errors = new[] { string.Format(_sharLocalizer[SDLocalization.Error]) },
                        Message = string.Format(_sharLocalizer[SDLocalization.Error]),
                        IsSuccess = false
                    };
                }

                await _unitOfWork.UserRoles.AddRangeAsync(resigterRequest.AddingRoles.Select(x => new ApplicationUserRole()
                {
                    RoleId = x,
                    UserId = UserNewObject.Id,
                    CompanyTenantId = UserNewObject.CompanyTenantId,
                    HistoryDisc = "Inserted In" + DateTime.Now.ToString()
                }));

                // Adding UserBranches.......

                await _unitOfWork.UserBranches.AddRangeAsync(resigterRequest.Branch_Ids.Select(x => new ApplicationUserBranches()
                {
                    Branch_Id = x,
                    User_Id = UserNewObject.Id
                }));

                //...........................

                await _unitOfWork.CompleteAsync();

                return new Response<AuthUserRegisterResponse>()
                {
                    Message = string.Format(_sharLocalizer[SDLocalization.Done]),
                    IsSuccess = true,
                    Data = _mapper.Map<AuthUserRegisterResponse>(UserNewObject)
                };
            }
            catch (Exception e)
            {
                _logger.LogError(e, _sharLocalizer[SDLocalization.Error]);
                return new Response<AuthUserRegisterResponse>()
                {
                    Errors = new[] { string.Format(_sharLocalizer[SDLocalization.Error]) },
                    Message = string.Format(_sharLocalizer[SDLocalization.Error]),
                    IsSuccess = false
                };
            }
        }

        public async Task<Response<List<AuthUserProfileResponse>>> GetCompanyUsers(int CompanyId, string? RoleId,string? UserName)
        {
            try
            {
                var RoleUsersIds = new List<string>();
                if (!string.IsNullOrEmpty(RoleId))
                {
                    RoleUsersIds = (await _unitOfWork.UserRoles.GetSpecificSelectAsync(filter: x => x.RoleId == RoleId && !x.IsDeleted ,select:x => x.UserId, ignoreQueryFilters: true)).ToList();
                }

                var SearchedCompany = await _unitOfWork.Companies.GetFirstOrDefaultAsync(filter: x => x.Id == CompanyId && !x.IsDeleted, ignoreQueryFilters: true);
                if (SearchedCompany == null)
                {
                    return new Response<List<AuthUserProfileResponse>>()
                    {
                        Message = _sharLocalizer[SDLocalization.CannotBeFound, CompanyId],
                        Errors = new[] { string.Format(_sharLocalizer[SDLocalization.CannotBeFound, CompanyId]) },
                        IsSuccess = false
                    };
                }
                if (!SearchedCompany.IsActive)
                {
                    return new Response<List<AuthUserProfileResponse>>()
                    {
                        Message = _sharLocalizer[SDLocalization.NotActive, CompanyId],
                        Errors = new[] { string.Format(_sharLocalizer[SDLocalization.NotActive, CompanyId]) },
                        IsSuccess = false
                    };
                }
                var CompanyUsersProfiles = await _unitOfWork.Users.GetSpecificSelectAsync(filter: y => y.Employee.Branch.Company_Id == SearchedCompany.Id && !y.IsDeleted && (RoleUsersIds.Contains(y.Id) || RoleUsersIds.Count() == 0 || RoleUsersIds == null)  && (string.IsNullOrEmpty(UserName) || y.Employee.Name.Contains(UserName)), select: x => new AuthUserProfileResponse()
                {
                    Code = x.Employee.Code,
                    Email = x.Email,
                    Id = x.Id,
                    ImagePath = x.Employee.ImagePath,
                    InsertDate = x.InsertDate,
                    IsActive = x.IsActive,
                    Job = x.Employee.Job,
                    Name = x.Employee.Name,
                    UserName= x.UserName.Substring(x.UserName.LastIndexOf('_') + 1),
                    UserTypeId=x.UserType_Id,
                    PhoneNumber = x.PhoneNumber,
                    AssignBranchesIds=x.AssignedBranches.Select(a=>a.Branch_Id).ToArray(),
                    AssignBranches = String.Join(",", x.AssignedBranches.Select(a => a.Branch_Id).ToArray()),
                    Roles = x.UserRoles.Where(x => !x.IsDeleted && !x.Role.IsDeleted).Select(a => a.Role.Name.Substring(a.Role.Name.LastIndexOf('_') + 1)).ToList(),
                    UserLastLog  = x.UserLogs.OrderByDescending(x => x.Id).Select(x => new LastUserLogResponse
                    {
                        StartDate = x.InsertDate,
                        EndDate = x.ExpireOn,
                        RemainingTime = ConvertTimeSpanToFormattedString.ToReadableAsObject(x.ExpireOn.Subtract(DateTime.UtcNow.AddHours(2)), x.IsDeleted, x.ExpireOn),
                        IsMobile = x.AndroidId != null,
                        IsConnected = !x.IsDeleted && x.ExpireOn > DateTime.UtcNow.AddHours(2)
                    }).FirstOrDefault(),
                    UserType = x.UserType.Name,
                    OnlineOrNot = x.UserLogs.Any(x => !x.IsDeleted && x.ExpireOn > DateTime.UtcNow.AddHours(2))
                }, ignoreQueryFilters: true);
                return new Response<List<AuthUserProfileResponse>>()
                {
                    Data = CompanyUsersProfiles.ToList(),
                    Message = _sharLocalizer[SDLocalization.Data],
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
                return new Response<List<AuthUserProfileResponse>>()
                {
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] { ex.Message },
                    IsSuccess = false
                };
            }

        }
        public async Task<Response<string>> ResetUserPassWord(string UserId)
        {
            try
            {
                var User = await _unitOfWork.Users.GetFirstOrDefaultAsync(filter: x => x.Id == UserId && !x.IsDeleted && x.IsActive);
                if (User == null)
                {
                    return new Response<string>()
                    {
                        Data = _sharLocalizer[SDLocalization.CannotBeFound, UserId],
                        Message = _sharLocalizer[SDLocalization.CannotBeFound, UserId],
                        Errors = new[] { string.Format(_sharLocalizer[SDLocalization.CannotBeFound, UserId]) }
                    };
                }
                await _userManager.ChangePasswordAsync(User, User.PasswordHash, "123456");
                return new Response<string>()
                {
                    Data = _sharLocalizer[SDLocalization.Updated],
                    Message = _sharLocalizer[SDLocalization.Updated],
                    IsSuccess = true,
                    IsUpdated = true
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
                return new Response<string>()
                {
                    Data = _sharLocalizer[SDLocalization.Error],
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] {ex.Message}
                };
            }
        }
        public Response<String> ActivateorDeactivateUser(string UserId)
        {
            try
            {
                var User = _unitOfWork.Users.GetFirstOrDefault(filter: x => x.Id == UserId && !x.IsDeleted);
                if (User == null)
                {
                    return new Response<string>()
                    {
                        Message = _sharLocalizer[SDLocalization.CannotBeFound, UserId],
                        Errors = new[] { string.Format(_sharLocalizer[SDLocalization.CannotBeFound, UserId]) },
                    };
                }
                User.IsActive = !User.IsActive;
                _unitOfWork.Users.Update(User);
                _unitOfWork.Complete();
                var Message = User.IsActive ? _sharLocalizer[SDLocalization.Activated] : _sharLocalizer[SDLocalization.DeActivated];
                return new Response<String>()
                {
                    Data = Message,
                    Message = Message,
                    IsSuccess = true,
                    IsUpdated = true
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
                return new Response<String>()
                {
                    Data = _sharLocalizer[SDLocalization.Error],
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] {ex.Message}
                };
            }
        }
        public async Task<Response<string>> ChangePassWord(ChangePassWordRequest model)
        {
            try
            {
                if (model.NewPassWord != model.ConfirmNewPassWord)
                    return new Response<string>() { Message = _sharLocalizer[SDLocalization.Error], IsSuccess = false, Data = "" };

                var user = await _userManager.FindByIdAsync(model.User_Id);
                if (user == null)
                {
                    return new Response<string>()
                    {
                        Data = _sharLocalizer[SDLocalization.CannotBeFound, model.User_Id],
                        Message = _sharLocalizer[SDLocalization.CannotBeFound, model.User_Id],
                        Errors = new[] { string.Format(_sharLocalizer[SDLocalization.CannotBeFound, model.User_Id]) }
                    };
                }
                var passwordCheck = await _userManager.CheckPasswordAsync(user, model.OldPassWord);
                if (!passwordCheck)
                    return new Response<string>() { Message = _sharLocalizer[SDLocalization.Error], IsSuccess = false, Data = "" };
                var success = await _userManager.ChangePasswordAsync(user, model.OldPassWord, model.ConfirmNewPassWord);
                return new Response<string>()
                {
                    Data = _sharLocalizer[SDLocalization.Updated],
                    Message = _sharLocalizer[SDLocalization.Updated],
                    IsSuccess = true,
                    IsUpdated = true
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
                return new Response<string>()
                {
                    Data = _sharLocalizer[SDLocalization.Error],
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] { ex.Message }
                };
            }

        }

        public async Task<Response<GetUserResponse>> UpdateUser(UpdateUserRequest model, string Id)
        {
            try
            {
                if (Id != model.User_Id)
                    return new Response<GetUserResponse>() { Message = _sharLocalizer[SDLocalization.CannotBeFound, model.User_Id], IsSuccess = false, Data = new GetUserResponse() };
                var user = await _unitOfWork.Users.GetFirstOrDefaultAsync(filter: x => x.Id == model.User_Id && x.IsActive && !x.IsDeleted, ignoreQueryFilters: true, includeProperties: "Employee,Employee.Branch,Employee.Branch.Company");
                if (user == null)
                    return new Response<GetUserResponse>() { Message = _sharLocalizer[SDLocalization.CannotBeFound, model.User_Id], IsSuccess = false, Data = new GetUserResponse() };
                user = _mapper.Map<UpdateUserRequest, ApplicationUser>(model, user);
                // Updating UserBranches......................

                var ExistinguserBranches = (await _unitOfWork.UserBranches.GetAllAsync(filter: x => x.User_Id == model.User_Id && !x.IsDeleted , ignoreQueryFilters:true)).ToList();
                var DeletingUserBranches = ExistinguserBranches.Select(x => x.Branch_Id).Except(model.Branches_Ids);

                _unitOfWork.UserBranches.RemoveRange(ExistinguserBranches.Where(x => DeletingUserBranches.Contains(x.Branch_Id)).ToList());

                var userBranches = model.Branches_Ids.Except(DeletingUserBranches).Select(x => new ApplicationUserBranches() { User_Id = user.Id, Branch_Id = x });
                user.AssignedBranches = userBranches.ToList();
                //............................................
                _unitOfWork.Users.Update(user);
                await _unitOfWork.CompleteAsync();
                var UserResp = new GetUserResponse()
                {
                    IsAuthenticated = true,
                    Email = user.Email,
                    UserName = user.UserName,
                    FullName = user.Employee.Name,
                    Technician_Id = 0,
                    Roles = new List<string>(),
                    UserId = user.Id,
                    CompanyId = user.Employee.Branch.Company_Id,
                    branchId = user.Employee.Branch_Id,
                    ImgPath = user.Employee.ImagePath,
                    EmployeeId = user.Employee_Id
                };
                return new Response<GetUserResponse>() { Data = UserResp, IsSuccess = true, Message = _sharLocalizer[SDLocalization.Updated] };
            }
            catch (Exception ex)
            {
                return new Response<GetUserResponse>() { Message = _sharLocalizer[SDLocalization.Error], IsSuccess = false, Errors = new[] { ex.Message }, Data = new GetUserResponse() };
            }
        }

        public async Task<Response<List<SelectListResponse>>> GetUserBranches(string UserId)
        {
            try
            {
                var UserBranches = (await _unitOfWork.UserBranches.GetSpecificSelectAsync(filter: x => x.User_Id == UserId && !x.IsDeleted, ignoreQueryFilters: true, select: x => new SelectListResponse() { Id = x.Branch_Id, Name = x.Branch.BranchName })).ToList();
                return new Response<List<SelectListResponse>>() { Data = UserBranches, IsSuccess = true, Message = _sharLocalizer[SDLocalization.Data] };
            }
            catch (Exception ex)
            {
                return new Response<List<SelectListResponse>>() { Data = new List<SelectListResponse>(), Message = _sharLocalizer[SDLocalization.Error], IsSuccess = false, Errors = new[] { ex.Message } };
            }
                
        }
    }
}
