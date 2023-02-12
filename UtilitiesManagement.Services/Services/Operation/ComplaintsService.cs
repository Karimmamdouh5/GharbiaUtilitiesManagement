using Microsoft.AspNetCore.SignalR;
using UtilitiesManagement.Services.Hubs.DashBoard;

namespace UtilitiesManagement.Services.Services.Operation
{
    public class ComplaintsService : IComplaintsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;
        private readonly ILoggingRepository _customLog;
        private readonly IMapper _mapper;
        private readonly IFileUploader _fileUploader;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly IHubContext<OperationsHub, GeneralInterfaces> _operationsHub;
        private readonly IHttpContextAccessor _accessor;
        public ComplaintsService(IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharLocalizer,
                                     ILoggingRepository loggingRepository, IMapper mapper,
                                     IFileUploader fileUploader, IWebHostEnvironment hostEnvironment, IHubContext<OperationsHub, GeneralInterfaces> operationsHub, IHttpContextAccessor accessor)
        {
            _unitOfWork = unitOfWork;
            _sharLocalizer = sharLocalizer;
            _customLog = loggingRepository;
            _mapper = mapper;
            _fileUploader = fileUploader;
            _hostEnvironment = hostEnvironment;
            _operationsHub = operationsHub;
            _accessor = accessor;
        }

        #region Complaints

        public async Task<Response<GetComplaintResponse>> GetAllComplaintsAsync(SearchParametersRequest searchParametersRequest)
        {
            if (searchParametersRequest.EndDate != null)
                searchParametersRequest.EndDate = searchParametersRequest.EndDate.Value.AddHours(23)
                    .AddMinutes(59).AddSeconds(59);
            try
            {
                //long? customerId = null;
                if (!string.IsNullOrEmpty(searchParametersRequest.CustomerCode))
                {
                    var cusdtomerData = await _unitOfWork.CustomerData.GetFirstOrDefaultAsync(x => x.Code == searchParametersRequest.CustomerCode);

                    if (cusdtomerData == null)
                    {
                        string resultMsg = _sharLocalizer[SDLocalization.NotFoundData];

                        return new Response<GetComplaintResponse>()
                        {
                            Data = new GetComplaintResponse(),
                            IsNotFound = true,
                            Errors = new string[] { resultMsg },
                            Message = resultMsg
                        };
                    }
                    searchParametersRequest.CustomerId = cusdtomerData.Id;
                }
                string UserId = _accessor!.HttpContext == null ? "" : _accessor!.HttpContext!.User.GetUserId();
                var BranchesUsersIds = await _unitOfWork.Users.GetAssignedBranches(UserId);


                Expression<Func<OprComplaint, bool>> filter = x =>

                (BranchesUsersIds.Contains(x.Employee.Branch_Id))
                &&
                 (searchParametersRequest.EmployeeId == x.Employee_Id || searchParametersRequest.EmployeeId == null)
                 &&
                 (x.IsPublic == searchParametersRequest.IsPublic || searchParametersRequest.IsPublic == null)
                
                 &&
                 (x.IsCustomerComplaint == searchParametersRequest.IsCustomerComplaint || searchParametersRequest.IsCustomerComplaint == null)
                 &&
                 (x.ComplaintDate >= searchParametersRequest.StartDate || searchParametersRequest.StartDate == null)
                 &&
                 (x.ComplaintDate <= searchParametersRequest.EndDate || searchParametersRequest.EndDate == null)
                 &&

                 (searchParametersRequest.CustomerId == x.Customer_Id || searchParametersRequest.CustomerId == null)
                 //&&
                 //(searchParametersRequest.CustomerCode == x.CustomerData!.Code || searchParametersRequest.CustomerCode == null)

                 &&
                 (searchParametersRequest.BranchId == x.Employee.Branch_Id || searchParametersRequest.BranchId == null)
                 &&
                 (searchParametersRequest.AreaId == x.CustomerData!.Block!.Area_Id || searchParametersRequest.AreaId == null)
                 &&
                 (searchParametersRequest.BlockId == x.CustomerData!.Block_Id || searchParametersRequest.BlockId == null)
                 &&
                 (searchParametersRequest.IsRevised == x.IsRevised || searchParametersRequest.IsRevised == null)
                 &&
                 (searchParametersRequest.StateId == x.CustomerData.Block.Area.City.State_Id || searchParametersRequest.StateId == null)
                 &&
                 (searchParametersRequest.CityId == x.CustomerData.Block.Area.City_Id || searchParametersRequest.CityId == null);

                var result = new GetComplaintResponse
                {
                    TotalRecords = await _unitOfWork.Complaints.Count(filter: filter),

                    Data = await _unitOfWork.Complaints.GetSpecificSelectAsync(filter, ignoreQueryFilters: true,
                     take: searchParametersRequest.PageSize,
                     skip: (searchParametersRequest.PageNumber - 1) * searchParametersRequest.PageSize,
                select: x => new GetComplaint
                {
                    Id = x.Id,
                    CollectorName = x.Employee.Name,
                    CustomerName = x.CustomerData == null ? "" : x.CustomerData!.Name,
                    CustomerCode = x.CustomerData == null ? "" : x.CustomerData!.Code,
                    IsRevised = x.IsRevised,
                    X = x.X,
                    Y = x.Y,
                    ComplaintTypeName = x.ComplaintType.Name,
                    Date = x.ComplaintDate,
                    Details = x.Notes,
                    ComplaintImagesPath = x.ComplaintImages.Select(a => a.ImagePath).ToList(),
                    AreaId = x.CustomerData == null ? x!.Block!.Area_Id : x.CustomerData!.Block!.Area_Id,
                    AreaName = x.CustomerData == null ? x!.Block!.Area.AreaName : x.CustomerData!.Block!.Area.AreaName,
                    BlockId = x.CustomerData == null ? (long)x!.BlockId : x.CustomerData!.Block_Id,
                    BlockName = x.CustomerData == null ? x!.Block!.BlockName : x.CustomerData!.Block!.BlockName,
                    BranchId = x.CustomerData == null ? x!.Block!.Area!.City.State.Branch_Id : x.CustomerData!.Block!.Area!.City.State.Branch_Id,
                    BranchName = x.CustomerData == null ? x!.Block.Area!.City.State.Branch.BranchName : x.CustomerData!.Block!.Area.City.State.Branch.BranchName,
                    IssueId = x.Issue_Id,
                    IssueName = x.Issue.IssueName,
                    IsPublic = x.IsPublic,
                    PublicAddress = x.PublicAddress,
                    IsCustomerComplaint = x.IsCustomerComplaint


                    //Id = x.Id,
                    //CollectorName = x.Employee.Name,
                    //CustomerName = x.CustomerData!.Name!,
                    //CustomerCode=x.CustomerData!.Code,
                    //IsRevised = x.IsRevised,
                    //X = x.X,
                    //Y = x.Y,
                    //ComplaintTypeName = x.ComplaintType.Name,
                    //Date = x.ComplaintDate,
                    //Details = x.Notes,
                    //ComplaintImagesPath = x.ComplaintImages.Select(a => a.ImagePath).ToList(),
                    //AreaId = x.CustomerData.Block.Area_Id,
                    //AreaName = x.CustomerData.Block.Area.AreaName,
                    //BlockId = (long)(x.CustomerData!= null ? x.CustomerData!.Block_Id : x.BlockId),
                    //BlockName = x.CustomerData != null? x.CustomerData.Block.BlockName : x.Block.BlockName,
                    //BranchId = x.CustomerData!.Block.Area.Branch_Id,
                    //BranchName = x.Employee.Branch.BranchName,
                    //IssueId = x.Issue_Id,
                    //IssueName = x.Issue.IssueName,
                    //IsPublic = x.IsPublic,
                    //PublicAddress = x.PublicAddress
                }, orderBy: x =>
                  x.OrderByDescending(x => x.Id))

                };

                if (result == null || result.Data.ToList().Count == 0)
                {
                    string resultMsg = _sharLocalizer[SDLocalization.NotFoundData];

                    return new Response<GetComplaintResponse>()
                    {
                        Data = new GetComplaintResponse() /*{ TotalRecords = TotalRecords }*/,
                        IsNotFound = true,
                        Errors = new string[] { resultMsg },
                        Message = resultMsg
                    };
                }

                return new Response<GetComplaintResponse>()
                {
                    IsSuccess = true,
                    Data = result
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(searchParametersRequest), LogType.Bug);
                return new Response<GetComplaintResponse>()
                {
                    Errors = new string[] { _sharLocalizer[SDLocalization.Error] },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }
        }

        public async Task<Response<IEnumerable<AddComplaintRequest>>> AddComplaintAsync(IEnumerable<AddComplaintRequest> addComplaintRequests)
        {
            string err = _sharLocalizer[SDLocalization.Error];

            addComplaintRequests = addComplaintRequests.Where(a => a.CustomerId != null || a.BlockId != null);
            if (addComplaintRequests.Count() == 0)
            {
                return new Response<IEnumerable<AddComplaintRequest>>()
                {
                    IsSuccess = false,
                    Data = new List<AddComplaintRequest>(),
                    Errors = new string[] { },
                    Message = _sharLocalizer[SDLocalization.ReviewRequest]
                };
            }
            try
            {
                var mappedComplaint = _mapper.Map<IEnumerable<OprComplaint>>(addComplaintRequests);
                await _unitOfWork.Complaints.AddRangeAsync(mappedComplaint);
                bool result = await _unitOfWork.CompleteAsync() > 0;
                //Calling Hub To FetchData
                await _operationsHub.Clients.All.LoadData("Load");
                return new Response<IEnumerable<AddComplaintRequest>>()
                {
                    IsSuccess = result,
                    Data = _mapper.Map<IEnumerable<AddComplaintRequest>>(mappedComplaint),
                    Errors = new string[] { },
                    Message = result ? _sharLocalizer[SDLocalization.Done] : err
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(addComplaintRequests), LogType.Bug);
                return new Response<IEnumerable<AddComplaintRequest>>()
                {
                    Errors = new string[] { err },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }
        }

        public async Task<Response<IEnumerable<UpdateComplaintRequest>>> UpdateSpecificFieldForComplaintAsync(List<UpdateComplaintRequest> updateComplaintRequests)
        {
            string err = _sharLocalizer[SDLocalization.Error];
            try
            {
                long[] revisedComplainsIds = updateComplaintRequests.Select(a => a.Id).ToArray();

                var revisedComplains = await _unitOfWork.Complaints.GetAllAsync(filter: a => revisedComplainsIds.Contains(a.Id));
                revisedComplains.ToList().ForEach(r => r.IsRevised = updateComplaintRequests.FirstOrDefault(a => a.Id == r.Id).IsRevised);
                _unitOfWork.Complaints.UpdateRange(revisedComplains);
                bool revisedResult = await _unitOfWork.CompleteAsync() > 0;

                return new Response<IEnumerable<UpdateComplaintRequest>>()
                {
                    IsSuccess = true,
                    IsUpdated = true,
                    Data = updateComplaintRequests,
                    Errors = new string[] { },
                    Message = _sharLocalizer[SDLocalization.Updated]
                };

            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(updateComplaintRequests), LogType.Bug);
                await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(updateComplaintRequests));
                return new Response<IEnumerable<UpdateComplaintRequest>>()
                {
                    Errors = new string[] { err },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }
        }

        public async Task<Response<IEnumerable<string>>> UploadComplaintImagesAsync(List<IFormFile> photos, ImagePathRequest imagePath, string? internet_Speed)
        {
            try
            {
                if (photos.Count() == 0 || photos == null)
                {
                    string resultMsg = _sharLocalizer[SDLocalization.NotFoundPhotos];

                    return new Response<IEnumerable<string>>()
                    {
                        Data = new List<string>(),
                        Errors = new string[] { resultMsg },
                        Message = resultMsg
                    };
                }


                var path = GetImagePath(imagePath);
                var paths = new List<string>();
                await Task.Run(() => photos.ForEach(async photo =>
                {
                    int indexOfChar = photo.FileName.IndexOf('_', StringComparison.Ordinal);
                    //_customLog.LogExceptionInDb(new Exception() { }, photo.FileName, LogType.Bug);

                    string idOwnerOfPic = photo.FileName.Substring(0, indexOfChar);

                    var complaint = _unitOfWork.Complaints.GetFirstOrDefault(x => x.Id == int.Parse(idOwnerOfPic));

                    string imagePath = _fileUploader.ProcessUploadedFile(photo, path, _hostEnvironment, $"{photo.FileName}_");

                    paths.Add(imagePath);

                    var addComplaintImage = new AddComplaintImage
                    {
                        ImagePath = imagePath,
                        Complaint_Id = complaint.Id,
                        InternetSpeed = internet_Speed
                    };

                    await _unitOfWork.ComplaintImages.AddAsync(_mapper.Map<OprComplaintImage>(addComplaintImage));
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
                return new Response<IEnumerable<string>>()
                {
                    Errors = new[] { ex.Message },
                    Message = string.Format(_sharLocalizer[SDLocalization.Error]),
                    IsSuccess = false
                };
            }

        }

        private static string GetImagePath(ImagePathRequest imagePath)
        {
            return imagePath switch
            {
                ImagePathRequest.Complaint => ComplaintPhotosPath,
                _ => MeterReadingPhotosPath
            };
        }

        #endregion
    }

}