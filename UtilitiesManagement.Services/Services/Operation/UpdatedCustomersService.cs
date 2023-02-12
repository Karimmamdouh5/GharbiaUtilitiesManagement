namespace UtilitiesManagement.Services.Services.Operation
{
    public class UpdatedCustomersService : IUpdatedCustomersService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;
        private readonly ILoggingRepository _customLog;
        private readonly IMapper _mapper;
        private readonly IFileUploader _fileUploader;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly IHttpContextAccessor _accessor;
        public UpdatedCustomersService(IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharLocalizer,
                                       ILoggingRepository loggingRepository, IMapper mapper, IFileUploader
                                       fileUploader, IWebHostEnvironment hostEnvironment, IHttpContextAccessor accessor)
        {
            _unitOfWork = unitOfWork;
            _sharLocalizer = sharLocalizer;
            _customLog = loggingRepository;
            _mapper = mapper;
            _fileUploader = fileUploader;
            _hostEnvironment = hostEnvironment;
            _accessor = accessor;
        }

        #region Updeted customers

        public async Task<Response<GetUpdatedCustomerResponse>> GetAllUpdatedCustomersAsync(SearchParametersRequest searchParametersRequest)
        {
            try
            {
                string resultMsg = _sharLocalizer[SDLocalization.NotFoundData];
                if (searchParametersRequest.EndDate != null)
                    searchParametersRequest.EndDate = searchParametersRequest.EndDate.Value.AddHours(23)
                        .AddMinutes(59).AddSeconds(59);
                long? customerId = null;
                if (!string.IsNullOrEmpty(searchParametersRequest.CustomerCode))
                {
                    var cusdtomerData = await _unitOfWork.CustomerData.GetFirstOrDefaultAsync(x => x.Code == searchParametersRequest.CustomerCode);

                    if (cusdtomerData == null)
                        return new Response<GetUpdatedCustomerResponse>()
                        {
                            Data = new GetUpdatedCustomerResponse(),
                            IsNotFound = true,
                            Errors = new string[] { resultMsg },
                            Message = resultMsg
                        };
                    customerId = cusdtomerData.Id;
                }

                string UserId = _accessor!.HttpContext == null ? "" : _accessor!.HttpContext!.User.GetUserId();
                var BranchesUsersIds = await _unitOfWork.Users.GetAssignedBranches(UserId);

                Expression<Func<OprUpdatedCustomer, bool>> filter = x =>
                (BranchesUsersIds.Contains(x.Employee.Branch_Id))
                &&
                (x.Employee_Id == searchParametersRequest.EmployeeId || searchParametersRequest.EmployeeId == null) &&
                //var result = await _unitOfWork.UpdatedCustomers.GetSpecificSelectAsync(x =>
                ((x.RequestDate >= searchParametersRequest.StartDate || searchParametersRequest.StartDate == null)
                &&
                (x.RequestDate <= searchParametersRequest.EndDate || searchParametersRequest.EndDate == null)) &&
                customerId == null ?

                (searchParametersRequest.CustomerId == x.CustomerData_Id || searchParametersRequest.CustomerId == null)
                &&
                (searchParametersRequest.CustomerCode == x.CustomerData.Code || searchParametersRequest.CustomerCode == null)

                &&
                (searchParametersRequest.BranchId == x.Employee.Branch_Id || searchParametersRequest.BranchId == null)
                &&
                (searchParametersRequest.AreaId == x.CustomerData.Block.Area_Id || searchParametersRequest.AreaId == null)
                &&
                (searchParametersRequest.BlockId == x.CustomerData.Block_Id || searchParametersRequest.BlockId == null)
                &&
                (searchParametersRequest.CityId == x.CustomerData.Block.Area.City_Id || searchParametersRequest.CityId == null)
                &&
                (searchParametersRequest.StateId == x.CustomerData.Block.Area.City.State_Id || searchParametersRequest.StateId == null)
                &&
                (searchParametersRequest.UpdatingTypeId == x.UpdatedCustomerType_Id || searchParametersRequest.UpdatingTypeId == null)
               
                &&
                (searchParametersRequest.IsRevised == x.IsRevised || searchParametersRequest.IsRevised == null)

                : x.CustomerData_Id == customerId;

                var result = new GetUpdatedCustomerResponse
                {
                    TotalRecords = await _unitOfWork.UpdatedCustomers.Count(filter: filter),

                    Data = await _unitOfWork.UpdatedCustomers.GetSpecificSelectAsync(filter,
                     take: searchParametersRequest.PageSize,
                     skip: (searchParametersRequest.PageNumber - 1) * searchParametersRequest.PageSize,
                select: x => new GetUpdatedCustomer
                {
                    Id = x.Id,
                    CollectorName = x.Employee.Name,
                    CustomerCode = x.CustomerData.Code,
                    CustomerName = x.CustomerData.Name!,
                    CustomerActivity = x.CustomerActivity.Name,
                    Cust_X=x.CustomerData.X,
                    Cust_Y=x.CustomerData.Y ,
                    Cust_NationalId = x.CustomerData.NationalId,
                    Cust_NumOfUnits=x.CustomerData.NumOfUnits,
                    Cust_ImagePath = x.CustomerData.ImagePath,
                    Cust_Activity = x.CustomerData.CustomerActivity.Name,
                    NationalId = x.NationalId,
                    NumOfUnits = x.NumOfUnits ?? 0,
                    RequestDate = x.RequestDate,
                    SysName = x.UpdatedCustomerType.SysName,
                    UpdatedTypeName = x.UpdatedCustomerType.Name,
                    UpdatedTypeSysName = x.UpdatedCustomerType.SysName,
                    X = x.X,
                    Y = x.Y,
                    ImagePath = x.ImagePath!,
                    UpdatedCustomerTypeId = x.UpdatedCustomerType_Id,

                    AreaId = x.CustomerData.Block.Area_Id,
                    AreaName = x.CustomerData.Block.Area.AreaName,

                    BlockId = x.CustomerData.Block_Id,
                    BlockName = x.CustomerData.Block.BlockName,

                    BranchId = x.Employee.Branch_Id,
                    BranchName = x.Employee.Branch.BranchName,

                    IssueId = x.Issue_Id,
                    IssueName = x.Issue.IssueName,
                    IsRevised = x.IsRevised
                }, orderBy: x =>
                  x.OrderByDescending(x => x.Id))
                };

                if (result == null || result.Data.ToList().Count == 0)
                    return new Response<GetUpdatedCustomerResponse>()
                    {
                        Data = new GetUpdatedCustomerResponse(),
                        IsNotFound = true,
                        Errors = new string[] { resultMsg },
                        Message = resultMsg
                    };

                return new Response<GetUpdatedCustomerResponse>()
                {
                    IsSuccess = true,
                    Data = result
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(searchParametersRequest), LogType.Bug);
                return new Response<GetUpdatedCustomerResponse>()
                {
                    Errors = new string[] { _sharLocalizer[SDLocalization.Error] },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }
        }

        public async Task<Response<IEnumerable<AddUpdatedCustomerResponse>>> AddUpdatedCustomerAsync(IEnumerable<AddUpdatedCustomerRequest> addUpdatedCustomerRequests)
        {
            string err = _sharLocalizer[SDLocalization.Error];
            try
            {
                var mappedUpdatedCustomer = _mapper.Map<IEnumerable<OprUpdatedCustomer>>(addUpdatedCustomerRequests);
                await _unitOfWork.UpdatedCustomers.AddRangeAsync(mappedUpdatedCustomer);
                bool result = await _unitOfWork.CompleteAsync() > 0;

                var data = _mapper.Map<IEnumerable<AddUpdatedCustomerResponse>>(mappedUpdatedCustomer);
                var UpdatedCustomerTypes = await _unitOfWork.UpdatedCustomerTypes.GetAllAsync();
                data.ToList().ForEach(x => x.SysName = UpdatedCustomerTypes.FirstOrDefault(a => a.Id == x.UpdatedCustomerType_Id)?.SysName);
                return new Response<IEnumerable<AddUpdatedCustomerResponse>>()
                {


                    IsSuccess = result,
                    Data = data,
                    Errors = new string[] { },
                    Message = result ? _sharLocalizer[SDLocalization.Done] : err
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(addUpdatedCustomerRequests));
                return new Response<IEnumerable<AddUpdatedCustomerResponse>>()
                {
                    Errors = new string[] { err },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }
        }

        public async Task<Response<IEnumerable<UpdateUpdatedCustomerRequest>>> UpdateSpecificFieldForUpdatedCustomerAsync(IEnumerable<UpdateUpdatedCustomerRequest> updateUpdatedCustomerRequests)
        {
            string err = _sharLocalizer[SDLocalization.Error];
            try
            {
                long[] revisedUpdateCustIds = updateUpdatedCustomerRequests.Select(a => a.Id).ToArray();

                var revisedUpdateCust = await _unitOfWork.UpdatedCustomers.GetAllAsync(filter: a => revisedUpdateCustIds.Contains(a.Id));
                revisedUpdateCust.ToList().ForEach(r => r.IsRevised = updateUpdatedCustomerRequests.FirstOrDefault(a => a.Id == r.Id).IsRevised);
                _unitOfWork.UpdatedCustomers.UpdateRange(revisedUpdateCust);
                bool revisedResult = await _unitOfWork.CompleteAsync() > 0;

                return new Response<IEnumerable<UpdateUpdatedCustomerRequest>>()
                {
                    IsSuccess = true,
                    IsUpdated = true,
                    Data = updateUpdatedCustomerRequests,
                    Errors = new string[] { },
                    Message = _sharLocalizer[SDLocalization.Updated]
                };

            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(updateUpdatedCustomerRequests));
                return new Response<IEnumerable<UpdateUpdatedCustomerRequest>>()
                {
                    Errors = new string[] { err },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }
        }

        public async Task<Response<IEnumerable<string>>> UploadUpdatedCustomerImagesAsync(List<IFormFile> photos, ImagePathRequest imagePath)
        {
            try
            {
                var path = GetImagePath(imagePath);
                var paths = new List<string>();
                await Task.Run(() => photos.ForEach(photo =>
                {
                    int indexOfChar = photo.FileName.IndexOf('_', StringComparison.Ordinal);
                    string updatedCustomerId = photo.FileName.Substring(0, indexOfChar);

                    var updatedCustomer = _unitOfWork.UpdatedCustomers.GetFirstOrDefault(x => x.Id == int.Parse(updatedCustomerId));

                    string imagePath = _fileUploader.ProcessUploadedFile(photo, path, _hostEnvironment, $"{updatedCustomer.Id}_");
                    paths.Add(imagePath);

                    updatedCustomer.ImagePath = imagePath;
                    _unitOfWork.UpdatedCustomers.Update(updatedCustomer);
                }));
                bool result = await _unitOfWork.CompleteAsync() > 0;
                return new Response<IEnumerable<string>>()
                {
                    IsSuccess = result,
                    Data = paths,
                    Errors = new string[] { },
                    Message = result ? _sharLocalizer[SDLocalization.Done] : _sharLocalizer[SDLocalization.Error]
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, "");
                return new Response<IEnumerable<string>>()
                {

                    Errors = new string[] { ex.Message },
                    Message = _sharLocalizer[SDLocalization.Error]
                };
            }
        }

        private static string GetImagePath(ImagePathRequest imagePath)
        {
            return imagePath switch
            {
                ImagePathRequest.UpdatedCustomers => UpdatedCustomerPhotosPath,
                _ => ComplaintPhotosPath
            };
        }

        public async Task<Response<IEnumerable<SelectListSysNameResponse>>> ListOfUpdatedCustomerTypeAsync()
        {
            try
            {
                IEnumerable<SelectListSysNameResponse> data = await _unitOfWork.UpdatedCustomerTypes.GetSpecificSelectAsync(x => !x.IsDeleted,
                    select: g => new SelectListSysNameResponse
                    {
                        Id = g.Id,
                        Name = g.Name,
                        SysName = g.SysName
                    });
                return new Response<IEnumerable<SelectListSysNameResponse>>
                {
                    Data = data,
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, "");
                return new Response<IEnumerable<SelectListSysNameResponse>>()
                {
                    Errors = new[] { ex.Message },
                    Message = _sharLocalizer[SDLocalization.Error]
                };
            }
        }

        #endregion
    }

}