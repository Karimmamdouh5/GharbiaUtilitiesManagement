namespace UtilitiesManagement.Services.Services.Shared
{
    public class CompanyService : ICompanyService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;
        private readonly ILoggingRepository _customLog;
        private readonly IMapper _mapper;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IAlignCompanyRepository _alignCompanyRepository;
        private readonly IFileUploader _fileUploader;
        private readonly IWebHostEnvironment _hostEnvironment;

        public CompanyService(IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharLocalizer,
                                ILoggingRepository loggingRepository, IMapper mapper,
                                RoleManager<ApplicationRole> roleManager,
                                UserManager<ApplicationUser> userManager,
                                IAlignCompanyRepository alignCompanyRepository,
                                IFileUploader fileUploader,
                                IWebHostEnvironment hostEnvironment
                              )
        {
            _unitOfWork = unitOfWork;
            _sharLocalizer = sharLocalizer;
            _customLog = loggingRepository;
            _mapper = mapper;
            _roleManager = roleManager;
            _userManager = userManager;
            _alignCompanyRepository = alignCompanyRepository;
            _fileUploader = fileUploader;
            _hostEnvironment = hostEnvironment;



        }
        #region Companies

        public async Task<IEnumerable<GetCompanyResponse>> GetAllCompaniesAsync() => _mapper.Map<List
            <GetCompanyResponse>>(await _unitOfWork.Companies.GetAllAsync(x => !x.IsDeleted, orderBy: o
                => o.OrderByDescending(x => x.Id)));

        public async Task<IEnumerable<SelectListResponse>> ListOfCompaniesAsync() =>
                _mapper.Map<List<SelectListResponse>>((await _unitOfWork.Companies.GetAllAsync(a => a.IsActive && !a.IsDeleted, orderBy: x => x.OrderByDescending(a => a.Id))));
        //await _unitOfWork.Companies.GetSpecificSelectAsync(x => x.IsActive && !x.IsDeleted,
        //        ignoreQueryFilters: true,
        //        select: x => new SelectListResponse
        //        {
        //            Id = x.Id,
        //            Name = x.CompanyName
        //        });
        

        public async Task<Response<GetCompanyResponse>> GetCompanyProfileAsync(int CompanyId) => new Response<GetCompanyResponse>()
        {
            Data = _mapper.Map<
            GetCompanyResponse>(await _unitOfWork.Companies.GetFirstOrDefaultAsync(x => !x.IsDeleted &&
            x.Id == CompanyId, ignoreQueryFilters: true)),
            Message = _sharLocalizer[SDLocalization.Data]
        };

        public async Task<Response<string>> AddCompanyAsync(AddCompanyRequest addCompanyRequest)
        {

            if (await _unitOfWork.Companies.ExistAsync(x =>
            x.CompanyCode.Trim().ToLower() == addCompanyRequest.CompanyCode.Trim().ToLower() && !x.IsDeleted, ignoreQueryFilters: true))
            {
                string msg = string.Format(_sharLocalizer[SDLocalization.IsExist], addCompanyRequest.CompanyCode);

                return new Response<string>()
                {
                    IsExists = true,
                    Errors = new string[] { msg },
                    Message = msg
                };
            }
            if (await _unitOfWork.Companies.ExistAsync(x => x.CompanyName.Trim().ToLower() == addCompanyRequest.CompanyName.Trim().ToLower() && !x.IsDeleted, ignoreQueryFilters: true))
            {
                string msg = string.Format(_sharLocalizer[SDLocalization.IsExist], addCompanyRequest.CompanyName);
                return new Response<string>()
                {
                    IsExists = true,
                    Errors = new string[] { msg },
                    Message = msg
                };
            }
            using (var transaction = _unitOfWork.BeginTransaction())
            {
                string msgError = _sharLocalizer[SDLocalization.Error];
                try
                {
                    var Company = _mapper.Map<SharCompany>(addCompanyRequest);
                    Company = await _unitOfWork.Companies.AddAsync(Company);

                    await _unitOfWork.CompleteAsync();

                    var Branch = new SharBranch()
                    {
                        
                       
                        BranchName = addCompanyRequest.CompanyName,
                        Company_Id = Company.Id,
                        BranchCode =addCompanyRequest.CompanyCode,
                        Id =//0
                        //todo//1
                        (await _unitOfWork.Branches.GetFirstOrDefaultAsync(filter: x =>true , orderBy:x => x.OrderByDescending(y => y.Id))).Id + 1
                        
                         
                    };


                    Branch = await _unitOfWork.Branches.AddAsync(Branch);
                    await _unitOfWork.CompleteAsync();

                    var Employee = new HrEmployee()
                    {
                        Name = addCompanyRequest.ManagerName,
                        Status_Id = 1,
                        Code = "1",
                        Mobile = addCompanyRequest.PhoneNumber,
                        ImagePath = "",
                        Branch_Id = Branch.Id,
                        Job = addCompanyRequest.Job,
                        Id =//0
                        //todo//1
                        (await _unitOfWork.Employees.GetFirstOrDefaultAsync(filter: x => true, orderBy: x => x.OrderByDescending(y => y.Id))).Id + 1


                    };

                    Employee = await _unitOfWork.Employees.AddAsync(Employee);
                    bool AlignComapnyResult = await _alignCompanyRepository.Add(new AlignCompany()
                    {
                        CompanyCode = addCompanyRequest.CompanyCode,
                        StartDate = DateTime.UtcNow.AddHours(2),
                        EndDate = DateTime.UtcNow.AddHours(2).AddYears(1),
                        IsActive = addCompanyRequest.IsActive,
                    });

                    await _unitOfWork.CompleteAsync();
                
                    if (AlignComapnyResult)
                    {
                        string roleName = $"{addCompanyRequest.CompanyCode.Trim()}_{addCompanyRequest.RoleName.Trim()}";
                        string userName = roleName;
                        var AppUser = new ApplicationUser()
                        {
                            UserName = userName,
                            Email = null,
                            Employee = Employee,
                            PhoneNumber = addCompanyRequest.PhoneNumber,
                            EmailConfirmed = true,
                            IsActive = true,
                            //CompanyTenantId = Company.Id,
                        };
                        //var user = await _userManager.Users.FirstOrDefaultAsync(x => x.UserName == userName);
                        bool roleExist = await _roleManager.RoleExistsAsync(roleName); //_roleManager.Roles.Any(a => a.Company_Id == Company.Id && a.Name == addCompanyRequest.RoleName);
                        if (!roleExist)
                        {
                            var role = new ApplicationRole();
                            role.Name = roleName;
                            role.Company_Id = Company.Id;
                            role.Is_Admin = true;
                            role.Is_SuperAdmin= addCompanyRequest.Is_SuperAdmin;
                            await _roleManager.CreateAsync(role);
                        }
                        await _userManager.CreateAsync(AppUser, "123456");

                        await _userManager.AddToRoleAsync(AppUser, roleName);

                        if (addCompanyRequest.LogoWebPhoto is not null)
                        {
                            Company.LogoWeb = _fileUploader.ProcessUploadedFile(addCompanyRequest.LogoWebPhoto, SD.CompanyPhotosPath, _hostEnvironment, Company.CompanyCode + "_logoweb");
                        }
                        if (addCompanyRequest.LogoPrintPhoto is not null)
                        {
                            Company.LogoPrint = _fileUploader.ProcessUploadedFile(addCompanyRequest.LogoPrintPhoto, SD.CompanyPhotosPath, _hostEnvironment, Company.CompanyCode + "_logoprint");
                        }

                        var ChangeLogoPath = await _unitOfWork.CompleteAsync();
                        //await AddAllClaimsToRole(roleName);
                        transaction.Commit();



                        return new Response<string>()
                        {
                            Message = _sharLocalizer[SDLocalization.Done],
                            IsSuccess = true
                        };
                    }
                    else
                    {
                        return new Response<string>()
                        {
                            Message = msgError,
                            Errors = new List<string>() { msgError, }
                        };
                    }
                }
                catch (Exception ex)
                {
                    var message =  ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message);
                    transaction.Rollback();
                    await _customLog.LogExceptionInDb(ex, message);

                    return new Response<string>()
                    {
                        Errors = new string[] { msgError },
                        Message = msgError
                    };
                }
            }
            //bool exists = false;
            //exists = await _unitOfWork.Jobs.ExistAsync(x => x.Name.Trim().ToUpper() == jobsRequest.Name.Trim().ToUpper());
            //if (exists)
            //    return new Response<HrJob>() { IsExists = true, Message = $"Job {jobsRequest.Name} is Exist" };

            //try
            //{
            //    var objResult = await _unitOfWork.Jobs.AddAsync(new HrJob() { Name = jobsRequest.Name, Company_Id = 1 });
            //    bool result = await _unitOfWork.CompleteAsync() > 0;
            //    return new Response<HrJob>() { IsSuccess = result, IdOfAddedObject = objResult.Id, Data = objResult, Errors = new string[] { }, Message = result ? "Done" : "Error" };

            //}
            //catch (Exception ex)
            //{
            //    await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(jobsRequest));
            //    return new Response<HrJob>() { Errors = new string[] { _sharLocalizer["Error"] }, Message = ex.Message+(ex.InnerException==null?"" : ex.InnerException.Message)};
            //}

        }

        public async Task<Response<string>> UpdateCompanyAsync(int companyId, UpdateCompanyRequest updateCompanyRequest)
        {
            bool exists = false;
            string localizedCompany = _sharLocalizer[SDLocalization.Company];
            string msgNotFound = string.Format(_sharLocalizer[SDLocalization.CannotBeFound], localizedCompany, updateCompanyRequest.CompanyName);
            var company = await _unitOfWork.Companies.GetFirstOrDefaultAsync(x => x.Id == updateCompanyRequest.Id && x.IsActive && !x.IsDeleted, ignoreQueryFilters: true);
            if (company == null || company.Id != companyId)
            {
                return new Response<string>()
                {
                    Data = "",
                    IsNotFound = true,
                    Errors = new string[] { msgNotFound },
                    Message = msgNotFound
                };
            }
            if (!company.IsActive)
            {
                string resultMsg = string.Format(_sharLocalizer[SDLocalization.NotActiveNotUpdate],
                    localizedCompany, companyId);

                return new Response<string>()
                {
                    IsNotFound = true,
                    Errors = new string[] { resultMsg },
                    Message = resultMsg
                };
            }
            exists = await _unitOfWork.Companies
                .ExistAsync(x => x.CompanyName.Trim().ToUpper() == updateCompanyRequest.CompanyName.Trim().ToUpper() && x.Id != companyId);
            if (!exists)
            {
                string err = _sharLocalizer[SDLocalization.Error];
                try
                {
                    var obj = _mapper.Map<UpdateCompanyRequest, SharCompany>(updateCompanyRequest, company);
                    var objResult = _unitOfWork.Companies.Update(obj);
                    bool result = await _unitOfWork.CompleteAsync() > 0;

                    return new Response<string>()
                    {
                        IsSuccess = result,
                        IsUpdated = true,
                        IdOfAddedObject = objResult.Id,
                        Errors = new string[] { },
                        Message = result ? _sharLocalizer[SDLocalization.Updated] : _sharLocalizer[err]
                    };

                }
                catch (Exception ex)
                {
                    await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(updateCompanyRequest));
                    return new Response<string>()
                    {
                        Errors = new string[] { err },
                        Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                    };
                }
            }
            string msg = string.Format(_sharLocalizer[SDLocalization.IsExist], localizedCompany);
            return new Response<string>()
            {
                IsExists = true,
                Errors = new string[] { msg },
                Message = msg
            };
        }

        public async Task<Response<string>> DeleteCompanyAsync(int companyId)
        {
            var company = await _unitOfWork.Companies.GetFirstOrDefaultAsync(a => a.Id == companyId && a.IsActive && !a.IsDeleted,
                                                                        ignoreQueryFilters: true);
            if (company == null)
            {
                string resultMsg = string.Format(_sharLocalizer[SDLocalization.CannotBeFound],
                    _sharLocalizer[SDLocalization.Company], companyId);

                return new Response<string>()
                {
                    IsNotFound = true,
                    Errors = new string[] { resultMsg },
                    Message = resultMsg
                };
            }

            try
            {
                await _unitOfWork.Companies.Remove(company);
                bool result = await _unitOfWork.CompleteAsync() > 0;

                if (!result)
                {
                    string err = _sharLocalizer[SDLocalization.Error];

                    return new Response<string>()
                    {
                        IsSuccess = false,

                        Errors = new string[] { err },
                        Message = err
                    };
                }
                return new Response<string>()
                {
                    IsSuccess = true,
                    Errors = new string[] { },
                    Message = _sharLocalizer[SDLocalization.Deleted]
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, $"error when deleting company id: {companyId} obj :{JsonConvert.SerializeObject(company)}");
                return new Response<string>()
                {
                    Errors = new string[] { _sharLocalizer[SDLocalization.Error] },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }
        }

        public async Task<Response<string>> ChangeLogoCompanyAsync(ChangeCompanyLogoRequest changeCompanyLogoRequest, bool logoWeb)
        {
            bool exists = false;
            string localizedCompany = _sharLocalizer[SDLocalization.Company];
            string msgNotFound = string.Format(_sharLocalizer[SDLocalization.CannotBeFound], localizedCompany, changeCompanyLogoRequest.Company_Id);
            var company = await _unitOfWork.Companies.GetFirstOrDefaultAsync(x => x.Id == changeCompanyLogoRequest.Company_Id && x.IsActive && !x.IsDeleted, ignoreQueryFilters: true);
            if (company == null)
            {
                return new Response<string>()
                {
                    Data = "",
                    IsNotFound = true,
                    Errors = new string[] { msgNotFound },
                    Message = msgNotFound
                };
            }
            if (changeCompanyLogoRequest.CompanyLogo is null)
            {
                return new Response<string>()
                {
                    Data = "",
                    IsNotFound = true,
                    Errors = new string[] { string.Format(_sharLocalizer[SDLocalization.CannotBeFound], localizedCompany, _sharLocalizer[SDLocalization.Image]) },
                    Message = msgNotFound
                };
            }

            string err = _sharLocalizer[SDLocalization.Error];
            try
            {
                string imgLink = "";
                if (changeCompanyLogoRequest.CompanyLogo is not null && logoWeb)
                {
                    company.LogoWeb = _fileUploader.ProcessUploadedFile(changeCompanyLogoRequest.CompanyLogo, SD.CompanyPhotosPath, _hostEnvironment, company.CompanyCode + "_logoweb");
                    imgLink = company.LogoWeb;
                    _fileUploader.DeleteFile(company.LogoWeb, _hostEnvironment);
                }
                else if (changeCompanyLogoRequest.CompanyLogo is not null && !logoWeb)
                {
                    company.LogoPrint = _fileUploader.ProcessUploadedFile(changeCompanyLogoRequest.CompanyLogo, SD.CompanyPhotosPath, _hostEnvironment, company.CompanyCode + "_logoprint");
                    imgLink = company.LogoPrint;
                    _fileUploader.DeleteFile(company.LogoPrint, _hostEnvironment);
                }
                _unitOfWork.Companies.Update(company);
                await _unitOfWork.CompleteAsync();
                return new Response<string>()
                {
                    IsSuccess = true,
                    IsUpdated = true,
                    Errors = new string[] { },
                    Data = imgLink,
                    Message = _sharLocalizer[SDLocalization.Updated]
                };

            }

            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(changeCompanyLogoRequest));
                return new Response<string>()
                {
                    Errors = new string[] { err },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }

            string msg = string.Format(_sharLocalizer[SDLocalization.IsExist], localizedCompany);
            return new Response<string>()
            {
                IsExists = true,
                Errors = new string[] { msg },
                Message = msg
            };



        }

        public async Task<Response<string>> ActiveOrNotAsync(int companyId)
        {
            {
                var company = await _unitOfWork.Companies.GetFirstOrDefaultAsync(a => a.Id == companyId && !a.IsDeleted, ignoreQueryFilters: true);


                if (company is null)
                {
                    string resultMsg = string.Format(_sharLocalizer[SDLocalization.CannotBeFound],
                        _sharLocalizer[SDLocalization.Company], companyId);

                    return new Response<string>()
                    {
                        Data = "",
                        IsNotFound = true,
                        Errors = new string[] { resultMsg },
                        Message = resultMsg
                    };
                }
                company.IsActive = !company.IsActive;
                _unitOfWork.Companies.Update(company);
                return new Response<string>()
                {
                    IsSuccess = await _unitOfWork.CompleteAsync() > 0,
                    IsUpdated = true,
                    Errors = new string[] { },
                    Message = company.IsActive
                    ? _sharLocalizer[SDLocalization.Activated]
                    : _sharLocalizer[SDLocalization.DeActivated]
                };
            }
        }

        #endregion
    }
}
