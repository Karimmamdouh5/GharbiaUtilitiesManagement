using UtilitiesManagement.Domain.Constants;
using UtilitiesManagement.Domain.Dtos;
using UtilitiesManagement.Services.IServices;
using UtilitiesManagement.Services.IServices.Permission;
using UtilitiesManagement.Domain.Dtos.Response;

namespace  UtilitiesManagement.Services.Services.Permission
{
    public class PermissionsService:IPermissionsService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly JwtSettings _jwt;
        private readonly ISharedServices _sharedServices;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<PermissionsService> _logger;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;

        public PermissionsService(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager, IOptions<JwtSettings> jwt, IUnitOfWork unitOfWork, ILogger<PermissionsService> logger, IStringLocalizer<SharedResource> sharLocalizer, ISharedServices SharedServices)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _jwt = jwt.Value;
            _unitOfWork = unitOfWork;
            _logger = logger;
            _sharLocalizer = sharLocalizer;
            _sharedServices = SharedServices;
        }
        #region Roles
        public async Task<Response<string>> CreateRoleAsync(AddNewRollRequest model)
        {
            try
            {
                var SearchedCompany = await _unitOfWork.Companies.GetFirstOrDefaultAsync(x => x.Id == model.CompanyId && !x.IsDeleted, null, true);
                if (SearchedCompany is null)
                {
                    return new Response<string>()
                    {
                        Message = _sharLocalizer[SDLocalization.CannotBeFound, _sharLocalizer[SDLocalization.Company], model.CompanyId]
                    };
                }
                var role = new ApplicationRole()
                {
                    Company_Id = model.CompanyId,
                    Name = SearchedCompany.CompanyCode + '_' + model.RoleName
                };
                var result = await _roleManager.CreateAsync(role);
                if (result.Succeeded)
                    return new Response<string>()
                    {
                        IsSuccess = true,
                        Data = role.Id,
                    };
                return new Response<string>()
                {
                    Errors = result.Errors.Select(x => x.Description),
                    Message = _sharLocalizer[SDLocalization.Error]
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
                return new Response<string>()
                {
                    Errors = new[] {ex.Message},
                    Message = _sharLocalizer[SDLocalization.Error]
                };
            }
            
        }
        public async Task<Response<RolesByUserIdResponse>> ManageUserRolesAsync(RolesByUserIdResponse model)
        {
            try
            {
                var User = await _unitOfWork.Users.GetFirstOrDefaultAsync(filter: x => x.Id == model.UserId && x.IsActive && !x.IsDeleted, includeProperties: "Employee.Branch,UserRoles,UserRoles.Role,Employee.Branch.Company", ignoreQueryFilters: true);
                if (User == null)
                {
                    return new Response<RolesByUserIdResponse>()
                    {
                        IsSuccess = false,
                        Message = _sharLocalizer[SDLocalization.CannotBeFound, model.UserId]
                    };
                }
                //string[] ExistingUserRoles = User.UserRoles.Where(x => !x.IsDeleted).Select(x => x.RoleId).ToArray();
                var ExistingUserRoles = User.UserRoles.Where(x => !x.IsDeleted).Select(x => x.RoleId).ToArray();
                var SelectedRoles = model.UserRoles.Where(x => x.IsSelected).Select(x => $"{User.Employee.Branch.Company.CompanyCode.ToLower().Trim()}_{x.DisplayValue}").ToList();
                var UserRolesNames = (await _unitOfWork.Permissions.GetSpecificSelectAsync(filter: x => ExistingUserRoles.Contains(x.Id) && x.Company_Id == User.Employee.Branch.Company_Id, ignoreQueryFilters: true, select: y => y.Name)).ToList();
                var NewUserRoles = SelectedRoles.Except(UserRolesNames).ToList();
                var DeletedRoles = UserRolesNames.Except(SelectedRoles).ToList();

                var SoftDeletedItems = User.UserRoles.Where(x => x.IsDeleted).Select(y => _unitOfWork.Permissions.GetFirstOrDefault(filter: d => d.Id == y.RoleId && !d.IsDeleted, ignoreQueryFilters: true));
                await AddAndRestoreRolesToUser(NewUserRoles, SoftDeletedItems, model, User);
                RemoveRolesFromUser(DeletedRoles, model);
                await _unitOfWork.CompleteAsync();
                return new Response<RolesByUserIdResponse>()
                {
                    Message = _sharLocalizer[SDLocalization.Updated],
                    IsSuccess = true,
                    Data = model,
                    IsUpdated = true
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
                return new Response<RolesByUserIdResponse>()
                {
                    IsSuccess = false,
                    Errors = new[] { string.Format(_sharLocalizer[SDLocalization.Error]) },
                    Message = _sharLocalizer[SDLocalization.Error]
                };
            }
        }
        private async Task<bool> AddAndRestoreRolesToUser(IEnumerable<string> NewUserRoles,IEnumerable<ApplicationRole> SoftDeletedItems , RolesByUserIdResponse model,ApplicationUser User)
        {
            try
            {
                var AddingItems = NewUserRoles.Except(SoftDeletedItems.Select(x => x.Name)).Select(z => _unitOfWork.Permissions.GetFirstOrDefault(filter: x => x.Name == z, ignoreQueryFilters: true)).Select(x => new ApplicationUserRole() { RoleId = x.Id, UserId = model.UserId, CompanyTenantId = User.CompanyTenantId, HistoryDisc = "Inserted_" + DateTime.Now.ToString() });
                await _unitOfWork.UserRoles.AddRangeAsync(AddingItems);

                var RestoringItems = NewUserRoles.Except(NewUserRoles.Except(SoftDeletedItems.Select(x => x.Name))).Select(z => _unitOfWork.Permissions.GetFirstOrDefault(filter: x => x.Name == z, ignoreQueryFilters: true)).Select(x => x.Id).Select(y => _unitOfWork.UserRoles.GetFirstOrDefault(filter: z => z.RoleId == y && z.IsDeleted && z.UserId == model.UserId, ignoreQueryFilters: true)).ToList();
                RestoringItems.ForEach(s => { s.IsDeleted = false; s.HistoryDisc = "Restored__" + DateTime.Now.ToString(); });
                _unitOfWork.UserRoles.UpdateRange(RestoringItems);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
                return false;
            }
           
        }
        private void RemoveRolesFromUser(IEnumerable<string> DeletedRoles , RolesByUserIdResponse model)
        {
            try
            {
                var DeletingItems = DeletedRoles.Select(x => _unitOfWork.Permissions.GetFirstOrDefault(filter: z => z.Name == x && !z.IsDeleted)).Select(x => _unitOfWork.UserRoles.GetFirstOrDefault(f => f.RoleId == x.Id && f.UserId == model.UserId && !f.IsDeleted, ignoreQueryFilters: true)).ToList();
                DeletingItems.ForEach(e => { e.IsDeleted = true; e.HistoryDisc = "Deleted__" + DateTime.Now.ToString(); });
                _unitOfWork.UserRoles.UpdateRange(DeletingItems);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
            }
            
        }

        public async Task<Response<PermissionsTreeByRoleResponse>> GetClaimsByRoleAsync(string roleId)
        {
            try
            {
                var ResponseData = new PermissionsTreeByRoleResponse();
                var Role = (await _unitOfWork.Permissions.GetFirstOrDefaultAsync(filter: x => x.Id == roleId && !x.IsDeleted, ignoreQueryFilters: true, includeProperties: "Company,RoleClaims"));

                if (Role == null)
                {
                    return new Response<PermissionsTreeByRoleResponse>() { IsSuccess = false, Message = _sharLocalizer[SDLocalization.CannotBeFound, "AdminCompany"] };
                }

                ResponseData.RoleId = Role.Id;
                ResponseData.RoleName = Role.Name;

                var RoleClaims = Role.RoleClaims.Where(x => !x.IsDeleted).ToList();


                var AdminRole = await _unitOfWork.Permissions.GetFirstOrDefaultAsync(filter: x => x.Company_Id == Role.Company_Id && x.Is_Admin && !x.IsDeleted , ignoreQueryFilters:true);

                if (AdminRole == null)
                {
                    return new Response<PermissionsTreeByRoleResponse>() { IsSuccess = false, Message = _sharLocalizer[SDLocalization.CannotBeFound, "Company Role Admin"] };
                }

                var CompanyPremissions = (await _unitOfWork.RoleClaims.GetSpecificSelectAsync(filter: x => x.RoleId == AdminRole.Id && !x.IsDeleted , select : y => new CheckBox() { 
                    DisplayValue = y.ClaimValue,
                    Id=y.Id,
                    IsSelected = RoleClaims.Select(a => a.ClaimValue).Contains(y.ClaimValue)
                },ignoreQueryFilters:true)).ToList();

                ResponseData.RoleTree = _sharedServices.CreatePermissionsTree(CompanyPremissions.Select(a => new TreeObject()
                {
                    PermissionItem = a.DisplayValue,
                    RoleClaimsId = a.Id,
                    RoleClaimsSelectedFlag = a.IsSelected
                }).ToList());

                return new Response<PermissionsTreeByRoleResponse>()
                {
                    Data = ResponseData,
                    Message = String.Format(_sharLocalizer[SDLocalization.Data]),
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
                return new Response<PermissionsTreeByRoleResponse>() { IsSuccess = false , Message = _sharLocalizer[SDLocalization.Error] };
            }
            
        }
        public async Task<Response<PermissionsByRoleResponse>> ManageClaimsByRoleAsync(PermissionsTreeByRoleResponse model)
        {
            try
            {
                var WorkingData = new PermissionsByRoleResponse()
                {
                    RoleId = model.RoleId,
                    RoleCalims = _sharedServices.GetPermissionsFromTree(model.RoleTree)
                };
                var SelectedPermisions = WorkingData.RoleCalims.Where(x => x.IsSelected).Select(x => x.DisplayValue).ToList();
                var RoleObject = await _unitOfWork.Permissions.GetFirstOrDefaultAsync(filter: x => x.Id == model.RoleId && !x.IsDeleted, ignoreQueryFilters: true, includeProperties: "Company,RoleClaims");
                if (RoleObject == null)
                {
                    return new Response<PermissionsByRoleResponse>() { IsSuccess = false, Message = _sharLocalizer[SDLocalization.CannotBeFound , "Role"] };
                }

                var RolePermissions = RoleObject.RoleClaims.Where(x => !x.IsDeleted).ToList();

                var DeletedPermissions = RolePermissions.Select(x => x.ClaimValue).ToList().Except(SelectedPermisions).ToList();
                
                var NewPermissions = SelectedPermisions.Except(RolePermissions.Select(x => x.ClaimValue).ToList()).ToList();

                var DB_SoftDeletedPermissions = await _unitOfWork.RoleClaims.GetSpecificSelectAsync(filter: x => x.IsDeleted && x.RoleId == model.RoleId , select:y => y.ClaimValue);

                await AddAndRestoringClaimsFromRole(NewPermissions, DB_SoftDeletedPermissions, WorkingData);

                await RemoveClaimsFromRole(DeletedPermissions , new List<string>() { model.RoleId});

                if (RoleObject.Is_Admin)
                {
                    var subRolepermessions = (await _unitOfWork.RoleClaims.GetAllAsync(filter: x => !x.IsDeleted && x.Role.Company_Id == RoleObject.Company_Id && DeletedPermissions.Contains(x.ClaimValue) && !x.Role.Is_Admin , includeProperties: "Role")).ToList();
                    await RemoveClaimsFromRole(subRolepermessions.Select(x => x.ClaimValue).ToList() , subRolepermessions.Select(x => x.RoleId).ToList());
                }


                await _unitOfWork.CompleteAsync();

                return new Response<PermissionsByRoleResponse>()
                {
                    Data = WorkingData,
                    IsSuccess = true,
                    IsUpdated = true,
                    Message = _sharLocalizer[SDLocalization.Done]
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
                return new Response<PermissionsByRoleResponse>()
                {
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] {ex.Message}
                };
            }
        } 
        private async Task<bool> AddAndRestoringClaimsFromRole(List<string> NewPermissions, IEnumerable<string> DB_SoftDeletedPermissions , PermissionsByRoleResponse model)
        {
            try
            {
                var AddingPermissions = NewPermissions.Except(DB_SoftDeletedPermissions).Select(z => new ApplicationRoleClaim()
                {
                    RoleId = model.RoleId,
                    ClaimType = "Permission",
                    ClaimValue = z,
                    HistoryDisc = "Inserted_" + DateTime.Now.ToString() + "--"
                }).ToList();

                await _unitOfWork.RoleClaims.AddRangeAsync(AddingPermissions);

                var RestoringPermissions = NewPermissions.Except(AddingPermissions.Select(x => x.ClaimValue)).Select(x => _unitOfWork.RoleClaims.GetFirstOrDefault(filter: y => y.ClaimValue == x && y.RoleId == model.RoleId)).ToList();
                RestoringPermissions.ForEach(e => { e.IsDeleted = false; e.HistoryDisc = "Restoring___" + DateTime.Now.ToString(); });
                _unitOfWork.RoleClaims.UpdateRange(RestoringPermissions);

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
                return false;
            }
            
        }
        private  async Task RemoveClaimsFromRole(List<string> DeletedPermissions , List<string> RoleId) {
            try
            {
                var DeletedPermissionsList = (await _unitOfWork.RoleClaims.GetAllAsync(filter: x => DeletedPermissions.Contains(x.ClaimValue) && RoleId.Contains(x.RoleId))).ToList();
                DeletedPermissionsList.ForEach(e => { e.IsDeleted = true; e.HistoryDisc = "Deleted___" + DateTime.Now.ToString(); });
                _unitOfWork.RoleClaims.UpdateRange(DeletedPermissionsList);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
            }

        }
        public async Task<Response<RolesByUserIdResponse>> GetUserRolesAsync(string UserId) {
            try
            {
                var User = await _unitOfWork.Users.GetFirstOrDefaultAsync(filter: x => x.Id == UserId && !x.IsDeleted && x.IsActive, ignoreQueryFilters: true, includeProperties: "Employee,Employee.Branch,Employee.Branch.Company,UserRoles,UserRoles.Role");
                string[] UserRolesIds = User.UserRoles.Where(x => !x.IsDeleted).Select(a=>a.RoleId).ToArray();
                var ResponseData = (await _unitOfWork.Permissions.GetSpecificSelectAsync(filter: x => x.Company_Id == User.Employee.Branch.Company_Id && !x.IsDeleted && !x.Is_Admin , select : z => new CheckBox_WithIdString(){
                    DisplayValue = z.Name.Substring(z.Name.LastIndexOf('_') + 1),
                    Id = z.Id,
                    IsSelected = UserRolesIds.Contains(z.Id)
                },ignoreQueryFilters:true)).ToList();

                return new Response<RolesByUserIdResponse>() { 
                    Data = new RolesByUserIdResponse() { UserId = UserId, UserRoles = ResponseData },
                    IsSuccess = true,
                    Message = _sharLocalizer[SDLocalization.Data]
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
                return new Response<RolesByUserIdResponse>()
                {
                    IsSuccess = false,
                    Message = _sharLocalizer[SDLocalization.Error]
                };
            }
        }

        public async Task<Response<PermissionsByCompanyResponse>> ManageClaimsForCompanyAdminAsync(PermissionsTreeByCompanyResponse model)
        {
            try
            {
                var WorkingData = new PermissionsByCompanyResponse()
                {
                    CompanyId = model.CompanyId,
                    RoleCalims = _sharedServices.GetPermissionsFromTree(model.RoleTree)
                };
                var SelectedClaims = WorkingData.RoleCalims.Where(x => x.IsSelected).Select(x => x.DisplayValue).ToList();
                var CompanyAdminRole = await _unitOfWork.Permissions.GetFirstOrDefaultAsync(filter: x => x.Company_Id == model.CompanyId && x.Is_Admin && !x.IsDeleted,ignoreQueryFilters:true,includeProperties: "RoleClaims");
                var AdminRoleClaims = CompanyAdminRole.RoleClaims.Where(x => !x.IsDeleted).ToList();
                var NewClaims = SelectedClaims.Except(AdminRoleClaims.Select(y => y.ClaimValue)).ToList();
                var DeletedClaims = AdminRoleClaims.Select(y => y.ClaimValue).Except(SelectedClaims).ToList();
                var SoftDeletedClaims = await _unitOfWork.RoleClaims.GetAllAsync(filter: x => x.RoleId == CompanyAdminRole.Id && x.IsDeleted,ignoreQueryFilters:true);
                await AddingandRestoringClaimsToAdminRole(NewClaims, SoftDeletedClaims, CompanyAdminRole);
                DeleteClaimsFromAdminRole(DeletedClaims, CompanyAdminRole);
                await  AccessChangesToCompanySubRoles(WorkingData, DeletedClaims, CompanyAdminRole);
                await _unitOfWork.CompleteAsync();

                return new Response<PermissionsByCompanyResponse>()
                {
                    Data = WorkingData,
                    Message = _sharLocalizer[SDLocalization.Updated],
                    IsSuccess = true,
                    IsUpdated = true
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
                return new Response<PermissionsByCompanyResponse>()
                {
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] { string.Format(_sharLocalizer[SDLocalization.Error]) },
                    IsSuccess = false
                };
            }
            
        }
        private async Task<bool> AddingandRestoringClaimsToAdminRole(List<string> NewClaims ,IEnumerable<ApplicationRoleClaim> SoftDeletedClaims,ApplicationRole CompanyAdminRole)
        {
            try
            {
                var AddingClaims = NewClaims.Distinct().Except(SoftDeletedClaims.Select(x => x.ClaimValue)).Select(z => new ApplicationRoleClaim()
                {
                    RoleId = CompanyAdminRole.Id,
                    ClaimValue = z,
                    ClaimType = "Permission"
                }).ToList();
                await _unitOfWork.RoleClaims.AddRangeAsync(AddingClaims);

                var RestoringClaims = NewClaims.Except(AddingClaims.Select(x => x.ClaimValue)).Select(x => _unitOfWork.RoleClaims.GetFirstOrDefault(filter: y => y.ClaimValue == x && y.RoleId == CompanyAdminRole.Id, ignoreQueryFilters: true)).ToList();
                RestoringClaims.ForEach(q => { q.IsDeleted = false; q.HistoryDisc = "Restored_" + DateTime.Now.ToString() + "__"; });
                _unitOfWork.RoleClaims.UpdateRange(RestoringClaims);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
                return false;
            }
            
        }
        private  void  DeleteClaimsFromAdminRole(List<string> DeletedClaims, ApplicationRole CompanyAdminRole)
        {
            try
            {
                var DeletingClaims = DeletedClaims.Distinct().Select(x => _unitOfWork.RoleClaims.GetFirstOrDefault(filter: z => z.ClaimValue == x && z.RoleId == CompanyAdminRole.Id, ignoreQueryFilters: true)).ToList();
                DeletingClaims.ForEach(e => { e.IsDeleted = true; e.HistoryDisc = "Deleted_" + DateTime.Now.ToString() + "___"; });
                _unitOfWork.RoleClaims.UpdateRange(DeletingClaims);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
            }
           
        }
        private async Task<bool> AccessChangesToCompanySubRoles(PermissionsByCompanyResponse model, List<string> DeletedClaims, ApplicationRole CompanyAdminRole)
        {
            try
            {
                var DeletingClaims = DeletedClaims.Select(x => _unitOfWork.RoleClaims.GetFirstOrDefault(filter: z => z.ClaimValue == x && z.RoleId == CompanyAdminRole.Id, ignoreQueryFilters: true)).ToList();

                var CompanySubRoles = (await _unitOfWork.Permissions.GetSpecificSelectAsync(filter: x => x.Company_Id == model.CompanyId && !x.IsDeleted && !x.Is_Admin, select: y => y.Id, ignoreQueryFilters: true)).ToList();

                var DeletingSubRolesClaims = (await _unitOfWork.RoleClaims.GetAllAsync(filter: x => CompanySubRoles.Contains(x.RoleId) && !x.IsDeleted && DeletingClaims.Select(z => z.ClaimValue).Contains(x.ClaimValue), ignoreQueryFilters: true)).ToList();
                DeletingSubRolesClaims.ForEach(e => { e.IsDeleted = true; e.HistoryDisc = "Deleted_" + DateTime.Now.ToString() + "___"; });
                _unitOfWork.RoleClaims.UpdateRange(DeletingSubRolesClaims);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
                return false;
            }
            
        }
        public async Task<Response<string>> ManageCompanyPermissions(PermissionsByRoleResponse model)
        {

            var result = new Response<string>();
            try
            {
                var role = await _roleManager.FindByIdAsync(model.RoleId);
               
                if (role == null || role.IsDeleted)
                {
                    result.Message =  _sharLocalizer[SDLocalization.CannotBeFound , _sharLocalizer[SDLocalization.Item] , model.RoleId];
                    return result;
                }

                var roleClaims = await _roleManager.GetClaimsAsync(role);

                foreach (var claim in roleClaims)
                    await _roleManager.RemoveClaimAsync(role, claim);

                var selectedClaims = model.RoleCalims.Where(c => c.IsSelected).ToList();

                foreach (var claim in selectedClaims)
                    await _roleManager.AddClaimAsync(role, new Claim("Permission", claim.DisplayValue));


                result.IsSuccess = true;
                return result;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
                result.Message = _sharLocalizer[SDLocalization.CannotBeFound , _sharLocalizer[SDLocalization.Item] , model.RoleId];
                return result;
            }
        }

        public async Task<Response<string>> AddAllClaimsToRoleAsync()
        {
            try
            {
                var Role = await _unitOfWork.Permissions.GetFirstOrDefaultAsync(filter: x => x.Is_SuperAdmin == true && !x.IsDeleted);
                if (Role == null)
                {
                    return new Response<string>()
                    {
                        Message = _sharLocalizer[SDLocalization.NotFoundData],
                        Errors = new[] { string.Format(_sharLocalizer[SDLocalization.NotFoundData]) },
                        IsSuccess = false
                    };
                }
                var AllPermissions = Permissions.GenerateAllPermissions().Select(x => new ApplicationRoleClaim()
                {
                    ClaimType = "Permission",
                    ClaimValue = x,
                    RoleId = Role.Id,
                    CompanyTenantId = Role.CompanyTenantId
                });
                var ExistingRoleClaims = await _unitOfWork.RoleClaims.GetAllAsync(filter: x => x.RoleId == Role.Id && !x.IsDeleted);
                var AddingRoleClaims = AllPermissions.Select(x => x.ClaimValue).Except(ExistingRoleClaims.Select(y => y.ClaimValue)).Select(z => new ApplicationRoleClaim()
                {
                    ClaimType = "Permission",
                    ClaimValue = z,
                    RoleId = Role.Id,
                    CompanyTenantId = Role.CompanyTenantId
                });
                await _unitOfWork.RoleClaims.AddRangeAsync(AddingRoleClaims);
                await _unitOfWork.CompleteAsync();
                return new Response<string>()
                {
                    Data = _sharLocalizer[SDLocalization.Done],
                    Message = _sharLocalizer[SDLocalization.Done],
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
                return new Response<string>()
                {
                    Data = _sharLocalizer[SDLocalization.Error],
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] {ex.Message},
                    IsSuccess = true
                };
            }
        }

        public async Task<Response<PermissionsByRoleResponse>> GetPermissionByRoleAsync(string roleId)
        {
            var result = new Response<PermissionsByRoleResponse>();
            try
            {
                var role = await _roleManager.FindByIdAsync(roleId);
                
                if (role == null || role.IsDeleted)
                {
                    result.Message =  _sharLocalizer[SDLocalization.CannotBeFound , _sharLocalizer[SDLocalization.Item], roleId];
                    return result;
                }

                var roleClaims = await _unitOfWork.RoleClaims.GetSpecificSelectAsync(filter: x => !x.IsDeleted, select: x => x.ClaimValue);
                var allClaims = Permissions.GenerateAllPermissions();
                var allPermissions = allClaims.Select(p => new CheckBox { DisplayValue = p }).ToList();

                foreach (var permission in allPermissions)
                {
                    if (roleClaims.Any(c => c == permission.DisplayValue))
                        permission.IsSelected = true;
                }

                var modelClaims = new PermissionsByRoleResponse
                {
                    RoleId = roleId,
                    RoleCalims = allPermissions
                };
                return new Response<PermissionsByRoleResponse>() { IsSuccess = true, Data = modelClaims };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
                result.Message = result.Message =  _sharLocalizer[SDLocalization.CannotBeFound , _sharLocalizer[SDLocalization.Item], roleId];
                return result;
            }
        }
        public async Task<Response<List<string>>> ListAllCompanyRulesByCompanyId(int CompanyId)
        {
            var Result = new Response<List<string>>();
            try
            {
                var SubRules = await _unitOfWork.Permissions.GetAllAsync(filter: x => x.Company_Id == CompanyId && x.IsDeleted == false && x.Is_Admin == false, ignoreQueryFilters: true);
                if (SubRules is null)
                {
                    Result.Message =  _sharLocalizer[SDLocalization.CannotBeFound , _sharLocalizer[SDLocalization.Item], CompanyId];
                }
                Result.IsSuccess = true;
                Result.Data = SubRules.Select(x => x.Name.Split("_")[1]).ToList();
                Result.Message = _sharLocalizer[SDLocalization.Done];
                return Result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
                Result.Message =  _sharLocalizer[SDLocalization.CannotBeFound , _sharLocalizer[SDLocalization.Data],""];
                return Result;
            }

        }
        public async Task<Response<List<SelectListWithStringIdStringResponse>>> ListRulesForCompany(int CompanyId) {
            try
            {

                var CompanySubRoles = (await _unitOfWork.Permissions.GetSpecificSelectAsync(filter: x => x.Company_Id == CompanyId && !x.IsDeleted && !x.Is_Admin ,select: y => new SelectListWithStringIdStringResponse()
                {
                    Name = y.Name.Substring(y.Name.LastIndexOf('_') + 1),
                    Id = y.Id,
                })).ToList();

                return new Response<List<SelectListWithStringIdStringResponse>> ()
                {
                    Message = _sharLocalizer[SDLocalization.Data],
                    Data = CompanySubRoles,
                    IsSuccess = true,
                    IdOfAddedObject = CompanyId
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
                return new Response<List<SelectListWithStringIdStringResponse>>()
                {
                    Message = _sharLocalizer[SDLocalization.Error],
                    IsSuccess = false,
                    IdOfAddedObject = CompanyId
                };
            }
           
        }

        public async Task<Response<SelectListWithStringIdStringResponse>> AddRulesToCompany(CompanyRoleDTO model)
        {
            try
            {
                var Company = await _unitOfWork.Companies.GetFirstOrDefaultAsync(filter: x => x.Id == model.CompanyId && x.IsActive,ignoreQueryFilters:true);
                if (Company == null)
                {
                    return new Response<SelectListWithStringIdStringResponse>()
                    {
                        IsSuccess = false,
                        Message = _sharLocalizer[SDLocalization.IsExist, model.CompanyId]
                    };
                }
                var CompanySubRoles = (await _unitOfWork.Permissions.GetSpecificSelectAsync(filter: x => x.Company_Id == model.CompanyId && !x.IsDeleted && !x.Is_Admin, select: y => y.Name,ignoreQueryFilters:true)).ToList();
                if (CompanySubRoles.Any(a=> a.Split("_")[1] == model.RoleName))
                {
                    return new Response<SelectListWithStringIdStringResponse>()
                    {
                        IsSuccess = false,
                        Message = _sharLocalizer[SDLocalization.IsExist, model.RoleName]
                    };
                }
                var NewRoleObject = new ApplicationRole()
                {
                    Name = Company.CompanyCode + "_" + model.RoleName,
                    Company_Id = model.CompanyId,
                    Is_Admin = false,
                    NormalizedName = (Company.CompanyCode + "_" + model.RoleName).ToUpper(),
                };
                await _unitOfWork.Permissions.AddAsync(NewRoleObject);
                await _unitOfWork.CompleteAsync();

                return new Response<SelectListWithStringIdStringResponse>()
                {
                    IsSuccess = true,
                    Data = new SelectListWithStringIdStringResponse() { Id = NewRoleObject.Id,Name = NewRoleObject.Name.Substring(NewRoleObject.Name.LastIndexOf('_') + 1) },
                    Message = _sharLocalizer[SDLocalization.Done],
                    IdOfAddedObject = 0
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
                return new Response<SelectListWithStringIdStringResponse>()
                {
                    IsSuccess = false,
                    Message = _sharLocalizer[SDLocalization.Error]
                };
            }
        }
        public async Task<Response<SelectListWithStringIdStringResponse>> EditRulesToCompany(CompanyRoleDTO_Edit model,string  roleId)
        {
            try
            {
                var SearchedRole = await _unitOfWork.Permissions.GetFirstOrDefaultAsync(filter: x => x.Id == model.RoleId && !x.IsDeleted && !x.Is_Admin, includeProperties: "Company", ignoreQueryFilters: true);
                if (SearchedRole == null || model.RoleId!= roleId)
                {
                    return new Response<SelectListWithStringIdStringResponse>()
                    {
                        IsSuccess = false,
                        Message = _sharLocalizer[SDLocalization.CannotBeFound, model.RoleId]
                    };
                }
                //var Company = await _unitOfWork.Companies.GetFirstOrDefaultAsync(filter: x => x.Id == SearchedRole.Company_Id && x.IsActive && !x.IsDeleted);
                SearchedRole.Name = SearchedRole?.Company?.CompanyCode + "_" + model.RoleNameNew;
                SearchedRole.NormalizedName =(SearchedRole?.Company?.CompanyCode + "_" + model.RoleNameNew).ToUpper();
                _unitOfWork.Permissions.Update(SearchedRole);
                await _unitOfWork.CompleteAsync();

                return new Response<SelectListWithStringIdStringResponse>()
                {
                    Data = new SelectListWithStringIdStringResponse() { Id = SearchedRole.Id , Name = SearchedRole.Name.Substring(SearchedRole.Name.LastIndexOf('_') + 1) },
                    IsSuccess = true,
                    IsUpdated = true,
                    Message = _sharLocalizer[SDLocalization.Updated]
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
                return new Response<SelectListWithStringIdStringResponse>()
                {
                    IsSuccess = false,
                    Message = _sharLocalizer[SDLocalization.Error],
                };
            }
            
        }
        public async Task<Response<ApplicationRole>> DeleteRulesToCompany(string RoleId)
        {
            try
            {
                var SearchedRole = await _unitOfWork.Permissions.GetFirstOrDefaultAsync(filter: x =>  x.Id == RoleId && !x.Is_Admin && !x.IsDeleted, ignoreQueryFilters: true);
                if (SearchedRole == null)
                {
                    return new Response<ApplicationRole>()
                    {
                        IsSuccess = false,
                        Message = _sharLocalizer[SDLocalization.CannotBeFound, RoleId]
                    };
                }
                SearchedRole.Name = SearchedRole.Name + "_Deleted";
                SearchedRole.NormalizedName = (SearchedRole.NormalizedName + "_Deleted").ToUpper() ;
                SearchedRole.IsDeleted = true;
                _unitOfWork.Permissions.Update(SearchedRole);
                await _unitOfWork.CompleteAsync();

                return new Response<ApplicationRole>()
                {
                    IsSuccess = true,
                    Message = _sharLocalizer[SDLocalization.Deleted],
                    IdOfAddedObject = 0
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
                return new Response<ApplicationRole>()
                {
                    IsSuccess = false,
                    Message = _sharLocalizer[SDLocalization.Error]
                };
            }
            
        }

        public async Task<Response<PermissionsTreeByCompanyResponse>> GetClaimsForCompanyAdminAsync(int CompanyId)
        {
            try
            {
                var CompanyAdminRole = await _unitOfWork.Permissions.GetFirstOrDefaultAsync(filter: x => x.Company_Id == CompanyId && x.Is_Admin && !x.IsDeleted && x.Company.IsActive,ignoreQueryFilters:true,includeProperties: "RoleClaims");
                if (CompanyAdminRole is null)
                {
                    return new Response<PermissionsTreeByCompanyResponse>()
                    {
                        Message = _sharLocalizer[SDLocalization.CannotBeFound, CompanyId],
                        Errors = new[] { string.Format(_sharLocalizer[SDLocalization.CannotBeFound, CompanyId]) }
                    };
                }
                var DataResponse = CompanyAdminRole.RoleClaims.Where(x => !x.IsDeleted).ToList().Select(y => new CheckBox()
                {
                    DisplayValue = y.ClaimValue,
                    Id = y.Id,
                    IsSelected = true
                }).ToList();
                var AllPermissionsValues = Permissions.GenerateAllPermissions().Except(DataResponse.Select(x => x.DisplayValue).ToList());
                DataResponse.AddRange(AllPermissionsValues.Select(x => new CheckBox()
                {
                    Id = 0,
                    DisplayValue = x,
                    IsSelected = false
                }));
                return new Response<PermissionsTreeByCompanyResponse>()
                {
                    Data = new PermissionsTreeByCompanyResponse() { CompanyId = CompanyId, RoleTree = _sharedServices.CreatePermissionsTree(DataResponse.OrderBy(x => x.Id).Select(a => new TreeObject()
                    {
                        PermissionItem = a.DisplayValue,
                        RoleClaimsId = a.Id,
                        RoleClaimsSelectedFlag = a.IsSelected
                    }).ToList())},
                    IsSuccess = true,
                    Message = _sharLocalizer[SDLocalization.Data],
                    IdOfAddedObject = CompanyId
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
                return new Response<PermissionsTreeByCompanyResponse>()
                {
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] { string.Format(_sharLocalizer[SDLocalization.Error]) }
                };
            }
        }

        public async Task<Response<List<AuthPermissionsTreeResponse>>> GetDefaultClaimsByCompanyIdAsync(int CompanyId)
        {
            try
            {
                var CompanyAdminRole = (await _unitOfWork.Permissions.GetFirstOrDefaultAsync(filter: x => x.Company_Id == CompanyId && x.Is_Admin && !x.IsDeleted,ignoreQueryFilters:true,includeProperties: "RoleClaims"));
                if (CompanyAdminRole == null)
                {
                    return new Response<List<AuthPermissionsTreeResponse>>()
                    {
                        Message = _sharLocalizer[SDLocalization.CannotBeFound, CompanyId],
                        IsSuccess = false,
                    };
                }
                var CompanyClaims = CompanyAdminRole.RoleClaims.Where(a => !a.IsDeleted).Select(y => new CheckBox()
                {
                    DisplayValue = y.ClaimValue,
                    Id = y.Id,
                    IsSelected = false
                }).ToList();
                return new Response<List<AuthPermissionsTreeResponse>>()
                {
                    Message = _sharLocalizer[SDLocalization.Data],
                    Data =_sharedServices.CreatePermissionsTree(CompanyClaims.Select(a => new TreeObject()
                    {
                        PermissionItem = a.DisplayValue,
                        RoleClaimsId = a.Id,
                        RoleClaimsSelectedFlag = a.IsSelected
                    }).ToList()),
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
                return new Response<List<AuthPermissionsTreeResponse>>()
                {
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] { string.Format(_sharLocalizer[SDLocalization.Error]) }
                };
            }
        }

        public async Task<Response<AuthRoleDetailsByCompanyResponse>>GetRolesDetailsForCompany(int CompanyId)
        {
            try
            {
                var Company = await _unitOfWork.Companies.GetFirstOrDefaultAsync(filter: x => x.Id == CompanyId && !x.IsDeleted && x.IsActive,ignoreQueryFilters:true);
                if (Company == null)
                {
                    return new Response<AuthRoleDetailsByCompanyResponse>()
                    {
                        Message = _sharLocalizer[SDLocalization.CannotBeFound, CompanyId],
                        IsSuccess = false,
                    };
                } 

                var CompanyRolesDetails = (await _unitOfWork.Permissions.GetSpecificSelectAsync(ignoreQueryFilters: true, filter: x => x.Company_Id == Company.Id && !x.Is_Admin && !x.IsDeleted, select: ob => new RoleDetails()
                {
                    Claims = ob.RoleClaims.Where(x => !x.IsDeleted).Select(x => x.ClaimValue).ToList(),
                    RoleId = ob.Id,
                    RoleName = ob.Name.Substring(ob.Name.LastIndexOf('_') + 1),
                    UsersCount = ob.UserRoles.Count(c => !c.IsDeleted),
                    Users = ob.UserRoles.Where(a=>!a.IsDeleted).Select(ur => new AuthUserProfileResponse()
                    {
                        Code = ur.User.Employee.Code,
                        Email = ur.User.Employee.Email,
                        Id = ur.User.Id,
                        ImagePath = ur.User.Employee.ImagePath,
                        InsertDate = ur.User.InsertDate,
                        IsActive = ur.User.IsActive,
                        Job = ur.User.Employee.Job,
                        Name = ur.User.Employee.Name,
                        UserName = ur.User.UserName.Substring(ur.User.UserName.LastIndexOf('_') + 1),
                        UserLastLog = ur.User.UserLogs.OrderByDescending(x => x.Id).Select(x => new LastUserLogResponse
                        {
                            StartDate = x.InsertDate,
                            EndDate = x.ExpireOn,
                            RemainingTime = ConvertTimeSpanToFormattedString.ToReadableAsObject(x.ExpireOn.Subtract(DateTime.UtcNow.AddHours(2)), x.IsDeleted, x.ExpireOn),
                            IsMobile = x.AndroidId != null,
                            IsConnected = !x.IsDeleted && x.ExpireOn > DateTime.UtcNow.AddHours(2)
                        }).FirstOrDefault(),
                        UserType = ur.User.UserType.Name,
                        OnlineOrNot = ur.User.UserLogs.Any(x => !x.IsDeleted && x.ExpireOn > DateTime.UtcNow.AddHours(2))
                    }).ToList()
                })).ToList();
                return new Response<AuthRoleDetailsByCompanyResponse>()
                {
                    Data = new AuthRoleDetailsByCompanyResponse()
                    {
                        CompanyId = CompanyId,
                        Roles = CompanyRolesDetails
                    },
                    Message = _sharLocalizer[SDLocalization.Data],
                    IsSuccess = true
                };

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, _sharLocalizer[SDLocalization.Error]);
                return new Response<AuthRoleDetailsByCompanyResponse>()
                {
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] { string.Format(_sharLocalizer[SDLocalization.Error]) }
                };
            }
        }
        
        #endregion
    }
}
