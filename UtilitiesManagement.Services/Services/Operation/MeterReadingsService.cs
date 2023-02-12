using Microsoft.AspNetCore.SignalR;
using UtilitiesManagement.Services.Hubs.DashBoard;

namespace UtilitiesManagement.Services.Services.Operation
{
    public class MeterReadingsService : IMeterReadingsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;
        private readonly ILoggingRepository _customLog;
        private readonly IMapper _mapper;
        private readonly IFileUploader _fileUploader;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly IHttpContextAccessor _accessor;
        private readonly IHubContext<OperationsHub, GeneralInterfaces> _operationsHub;

        public MeterReadingsService(IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharLocalizer,
                                     ILoggingRepository loggingRepository, IMapper mapper,
                                     IFileUploader fileUploader, IWebHostEnvironment hostEnvironment,
                                     IHttpContextAccessor accessor, IHubContext<OperationsHub, GeneralInterfaces> operationsHub)
        {
            _unitOfWork = unitOfWork;
            _sharLocalizer = sharLocalizer;
            _customLog = loggingRepository;
            _mapper = mapper;
            _fileUploader = fileUploader;
            _hostEnvironment = hostEnvironment;
            _mapper = mapper;
            _accessor = accessor;
            _operationsHub = operationsHub;
        }

        #region Meter readings

        public async Task<Response<GetMeterReadingResponse>> GetAllMeterReadingsAsync(SearchParametersForMeterReadingsRequest searchParametersRequest)
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
                        return new Response<GetMeterReadingResponse>()
                        {
                            Data = new GetMeterReadingResponse(),
                            IsNotFound = true,
                            Errors = new string[] { resultMsg },
                            Message = resultMsg
                        };
                    customerId = cusdtomerData.Id;
                }
                string UserId = _accessor!.HttpContext == null ? "" : _accessor!.HttpContext!.User.GetUserId();
                var BranchesUsersIds = await _unitOfWork.Users.GetAssignedBranches(UserId);

                Expression<Func<OprMeterReading, bool>> filter = x =>
                (BranchesUsersIds.Contains(x.Employee.Branch_Id))
                &&
                (x.Employee_Id== searchParametersRequest.EmployeeId|| searchParametersRequest.EmployeeId==null ) &&
                (x.MeterReadingDate >= searchParametersRequest.StartDate || searchParametersRequest.StartDate == null)
                &&
                (x.MeterReadingDate <= searchParametersRequest.EndDate || searchParametersRequest.EndDate == null)
                &&
                customerId == null ?

                (searchParametersRequest.CustomerId == x.Customer_Id || searchParametersRequest.CustomerId == null)
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
                (x.IsRevised == searchParametersRequest.IsRevised || searchParametersRequest.IsRevised == null)
                &&
                (x.IsPosted == searchParametersRequest.IsPosted || searchParametersRequest.IsPosted == null)
                : x.Customer_Id == customerId ;

                var result = new GetMeterReadingResponse
                {
                    TotalRecords = await _unitOfWork.MeterReadings.Count(filter: filter),

                    Data = await _unitOfWork.MeterReadings.GetSpecificSelectAsync(filter,
                     take: searchParametersRequest.PageSize,
                     skip: (searchParametersRequest.PageNumber - 1) * searchParametersRequest.PageSize,
                select: x => new GetMeterReading
                {
                    Id = x.Id,
                    CollectorId = x.Employee_Id,
                    CollectorName = x.Employee.Name,
                    CustomerCode = x.CustomerData.Code,
                    CustomerId = x.Customer_Id,
                    CustomerName = x.CustomerData.Name!,
                    IsPosted = x.IsPosted,
                    IsRevised = x.IsRevised,
                    IssueDate = x.IssueDetails.Issue.IssueDate,
                    IssueStatus = x.IssueDetails.Issue.Status,
                    LastReading = x.PreviousReading,
                    IsUpnormalReading =(x.Value- x.PreviousReading)> x.CustomerData.CustomerActivity.ReadingAvg,
                    MeterStatus = x.MeterStatus.Name,
                    Value = x.Value,
                    Notes = x.Notes!,
                    ReadingImagePath = x.ReadingImagePath!,
                    X = x.X,
                    Y = x.Y,
                    MeterReadingDate = x.MeterReadingDate,
                    BlockId = x.CustomerData.Block_Id,
                    BlockName = x.CustomerData.Block.BlockName,

                    AreaId = x.CustomerData.Block.Area_Id,
                    AreaName = x.CustomerData.Block.Area.AreaName,

                    BranchId = x.CustomerData.Block_Id,
                    BranchName = x.Employee.Branch.BranchName,

                    IssueId = x.IssueDetails.Issue_Id,
                    IssueName = x.IssueDetails.Issue.IssueName,




                }, orderBy: x =>
                              x.OrderByDescending(x => x.Id))
                };

                if (result == null || result.Data.ToList().Count == 0)
                    return new Response<GetMeterReadingResponse>()
                    {
                        Data = new GetMeterReadingResponse(),
                        IsNotFound = true,
                        Errors = new string[] { resultMsg },
                        Message = resultMsg
                    };

                return new Response<GetMeterReadingResponse>()
                {
                    IsSuccess = true,
                    Data = result
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(searchParametersRequest), LogType.Bug);
                return new Response<GetMeterReadingResponse>()
                {
                    Errors = new string[] { _sharLocalizer[SDLocalization.Error] },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }
        }

        public async Task<Response<IEnumerable<AddMeterReadingRequest>>> AddMeterReadingAsync(IEnumerable<AddMeterReadingRequest> addMeterReadingRequests)
        {
            ///delete   public long? IssueDetails_Id { get; set; }  not forget remove ?
            var firstRec = addMeterReadingRequests.FirstOrDefault();
            if (firstRec!=null /*&& firstRec.IssueDetails_Id==null*/)
            {

            
            var Employee = _unitOfWork.Employees.GetFirstOrDefault(a => a.Id == firstRec.CollectorId);
            var IssueDetails = _unitOfWork.IssueDetails.GetFirstOrDefault(x => x.Branch_Id == Employee.Branch_Id,orderBy:a=>a.OrderByDescending(x=>x.Id));

            if (IssueDetails != null)
                addMeterReadingRequests.ToList().ForEach(a => a.IssueDetails_Id = IssueDetails.Id);
             }

            /////end delete
           string err = _sharLocalizer[SDLocalization.Error];
            try
            {
                var CustomerIds = addMeterReadingRequests.Select(x => x.Customer_Id).ToArray();

                // Send Issue Id Here Then Get By SubQuery The Issue Date Then Get The Data By ThIS cONDITION
                
                var IssueDetailsArray = (await _unitOfWork.IssueDetails.GetSpecificSelectAsync(filter: y => addMeterReadingRequests.FirstOrDefault()!.IssueDetails_Id == y.Id, select: obj => new SelectListResponseWithDate() { Date = obj.Issue.IssueDate })).Select(x => x.Date).ToArray();

                await UpdatePreviousReading(CustomerIds, IssueDetailsArray);
                var mappedMeterReading = _mapper.Map<IEnumerable<OprMeterReading>>(addMeterReadingRequests);
                await _unitOfWork.MeterReadings.AddRangeAsync(mappedMeterReading);
                bool result = await _unitOfWork.CompleteAsync() > 0;

                //Calling Hub To FetchData
                await _operationsHub.Clients.All.LoadData("Load");
                return new Response<IEnumerable<AddMeterReadingRequest>>()
                {
                    IsSuccess = result,
                    Data = _mapper.Map<IEnumerable<AddMeterReadingRequest>>(mappedMeterReading),
                    Errors = new string[] { },
                    Message = result ? _sharLocalizer[SDLocalization.Done] : err
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(addMeterReadingRequests));
                return new Response<IEnumerable<AddMeterReadingRequest>>()
                {
                    Errors = new string[] { err },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }
        }

        public async Task<Response<IEnumerable<UpdateMeterReadingRequest>>> UpdateTwoSpecificFieldsForMeterReadingAsync(IEnumerable<UpdateMeterReadingRequest> updateMeterReadingRequests)
        {
            string err = _sharLocalizer[SDLocalization.Error];
            string? userId = _accessor!.HttpContext == null ? null : _accessor!.HttpContext!.User.GetUserId();
            string userName = "";
            if (userId != null)
            {
                var user = await _unitOfWork.Users.GetFirstOrDefaultAsync(a => a.Id == userId);
                userName = user.Id;
            }
            try
            {
                //foreach (var updateMeterReadingRequest in updateMeterReadingRequests)
                //    if (updateMeterReadingRequest.IsPotsed)
                //        updateMeterReadingRequest.IsRevised = true;
                //_unitOfWork.MeterReadings.UpdateRange(listOfObj);
                //bool result = await _unitOfWork.CompleteAsync() > 0;
                long[] postMeterReadingIds = updateMeterReadingRequests.Where(a => a.IsPosted == true).Select(a => a.Id).ToArray();
                var postmeterReadings = await _unitOfWork.MeterReadings.GetAllAsync(filter: a => postMeterReadingIds.Contains(a.Id),includeProperties: "CustomerData");

                foreach (var post in postmeterReadings)
                {
                  if (!post.IsPosted)
                  {
                    post.IsPosted = true;
                    post.IsRevised = true;
                    _unitOfWork.MeterReadings.Update(post);
                    bool result = await _unitOfWork.CompleteAsync() > 0;
                    if (result)
                    {
                            var meterStatusName = await _unitOfWork.MeterReadingStatus.GetFirstOrDefaultAsync(filter: obj => obj.Id == post.MeterStatus_Id, ignoreQueryFilters: true);
                            var resultPostReading = await _unitOfWork.MeterReadings.Remote_PostMeterReading(post.CustomerData.Name!, post.Customer_Id.ToString() , post.Issue_Details_Id, meterStatusName.Name, post.Value, post.Notes, post.Employee_Id, userName, post.Id,post.CustomerData.Block_Id);
                        
                       
                    }
                  }
                }

                long[] revisedMeterReadingIds = updateMeterReadingRequests.Where(a => !a.IsPosted).Select(a => a.Id).ToArray();

                var revisedReadings = await _unitOfWork.MeterReadings.GetAllAsync(filter: a => revisedMeterReadingIds.Contains(a.Id));
                revisedReadings.ToList().ForEach(r => r.IsRevised = updateMeterReadingRequests.FirstOrDefault(a => a.Id == r.Id)!.IsRevised);
                _unitOfWork.MeterReadings.UpdateRange(revisedReadings);
                bool revisedResult = await _unitOfWork.CompleteAsync() > 0;

                return new Response<IEnumerable<UpdateMeterReadingRequest>>()
                {
                    IsSuccess = true,
                    IsUpdated = true,
                    Data = updateMeterReadingRequests,
                    Errors = new string[] { },
                    Message = _sharLocalizer[SDLocalization.Updated]
                };

            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(updateMeterReadingRequests));
                return new Response<IEnumerable<UpdateMeterReadingRequest>>()
                {
                    Errors = new string[] { err },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }
        }

        public async Task<Response<IEnumerable<string>>> UploadMeterReadingImageAsync(List<IFormFile> photos, ImagePathRequest imagePath)
        {
            try
            {
                var path = GetImagePath(imagePath);
                var paths = new List<string>();
                await Task.Run(() => photos.ForEach(photo =>
                {
                    int indexOfChar = photo.FileName.IndexOf('_', StringComparison.Ordinal);
                    string meterReadingId = photo.FileName.Substring(0, indexOfChar);

                    var meterReading = _unitOfWork.MeterReadings.GetFirstOrDefault(x => x.Id == int.Parse(meterReadingId));

                    string imagePath = _fileUploader.ProcessUploadedFile(photo, path, _hostEnvironment, $"{meterReading.Id}_");
                    paths.Add(imagePath);

                    meterReading.ReadingImagePath = imagePath;
                    _unitOfWork.MeterReadings.Update(meterReading);
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
                ImagePathRequest.MeterReading => MeterReadingPhotosPath,
                _ => ComplaintPhotosPath
            };
        }

        public async Task<Response<IEnumerable<SelectListResponse>>> ListOfMeterReadingStatusAsync()
        {
            try
            {
                return new Response<IEnumerable<SelectListResponse>>()
                {
                    Data = _mapper.Map<IEnumerable<SelectListResponse>>(
                        await _unitOfWork.MeterReadingStatus.GetAllAsync(x => !x.IsDeleted)),
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, "");
                return new Response<IEnumerable<SelectListResponse>>()
                {
                    Errors = new[] { ex.Message },
                    Message = _sharLocalizer[SDLocalization.Error]
                };
            }
        }
        private async Task<bool> UpdatePreviousReading(long[] customerIds , DateTime[] IssueDates)
        {
            try
            {
                var GetRemotePrevReading = await _unitOfWork.MeterReadings.GetRemotePreviousReadingForCustomersAsync(string.Join(",", customerIds), string.Join(",", IssueDates.Select(x => x.ToString("yyyy-MM-dd"))));

                long[] CustomersIds = GetRemotePrevReading.Select(a => a.CustomerId).ToArray();

                var CustomersData = await _unitOfWork.CustomerData.GetAllAsync(filter: a => CustomersIds.Contains(a.Id));
                CustomersData.ToList().ForEach(r => { r.PreviousReading = GetRemotePrevReading.FirstOrDefault(a => a.CustomerId == r.Id)!.PrevReading.ToString(); r.PreviousReadingIssueNumber = GetRemotePrevReading.FirstOrDefault(a => a.CustomerId == r.Id)!.IssueName; });
                _unitOfWork.CustomerData.UpdateRange(CustomersData);
                bool revisedResult = await _unitOfWork.CompleteAsync() > 0;

                return true;
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, "");
                return false;
            }
        }

        public async Task<Response<UpdateMeterReadingValueRequest>> UpdateMeterReadingValueAsync(UpdateMeterReadingValueRequest model)
        {
            bool result = false;

            try
            {
                var meterReading = await _unitOfWork.MeterReadings.GetFirstOrDefaultAsync(x =>
                x.Id == model.MeterReadings_Id);

                if (meterReading is null)
                {
                    string resultMsg = string.Format(_sharLocalizer[SDLocalization.CannotBeFound],
                        _sharLocalizer[SDLocalization.MeterReading], model.MeterReadings_Id);

                    return new Response<UpdateMeterReadingValueRequest>()
                    {
                        Data = new UpdateMeterReadingValueRequest(),
                        IsNotFound = true,
                        Errors = new string[] { resultMsg },
                        Message = resultMsg
                    };
                }
                double oldMeterReadingValue = meterReading.Value;

                meterReading.Value = model.NewValue;
                _unitOfWork.MeterReadings.Update(meterReading);

                //To add the new meter readings in log
                var meterReadingLog = new OprMeterReadingLog
                {
                    MeterReadings_Id = model.MeterReadings_Id,
                    OldValue = oldMeterReadingValue,
                    NewValue = model.NewValue
                };

                await _unitOfWork.MeterReadingLogs.AddAsync(meterReadingLog);
                result = await _unitOfWork.CompleteAsync() > 0;

                return new Response<UpdateMeterReadingValueRequest>()
                {
                    IsSuccess = result,
                    IsUpdated = true,
                    IdOfAddedObject = meterReading.Id,
                    Data = model,
                    Errors = new string[] { },
                    Message = _sharLocalizer[SDLocalization.Updated]
                };
            }
            catch (Exception ex)
            {
                return new Response<UpdateMeterReadingValueRequest>()
                {
                    Errors = new string[] { _sharLocalizer[SDLocalization.Error] },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }
        }
        #endregion
    }

}