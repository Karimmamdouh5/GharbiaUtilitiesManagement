using UtilitiesManagement.Domain.ViewModels.Customer;
using static UtilitiesManagement.Domain.Constants.Permissions.Permissions;

namespace UtilitiesManagement.Services.Services.Customer
{
    public class CustomerDataService : ICustomerDataService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;
        private readonly ILoggingRepository _customLog;
        private readonly IMapper _mapper;
        private readonly HttpContextAccessor _accessor;

        public CustomerDataService(IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharLocalizer,
                                   ILoggingRepository loggingRepository, IMapper mapper,HttpContextAccessor accessor)
        {
            _unitOfWork = unitOfWork;
            _sharLocalizer = sharLocalizer;
            _customLog = loggingRepository;
            _mapper = mapper;
            _accessor = accessor;
        }

        #region Customer data and manage remotely

        public async Task<Response<GetCustomerResponse>> GetAllCustomerDataAsync(SearchParametersForCustomerDataRequest searchParametersForCustomerDataRequest)
        {
            if (searchParametersForCustomerDataRequest.EndDate != null)
                searchParametersForCustomerDataRequest.EndDate = searchParametersForCustomerDataRequest
                    .EndDate.Value.AddHours(23).AddMinutes(59).AddSeconds(59);
            try
            {
                long? customerId = null;
                if (!string.IsNullOrEmpty(searchParametersForCustomerDataRequest.CustomerCode))
                {
                    var cusdtomerData = await _unitOfWork.CustomerData.GetFirstOrDefaultAsync(x => x.Code == searchParametersForCustomerDataRequest.CustomerCode);

                    if (cusdtomerData == null)
                    {
                        string resultMsg = _sharLocalizer[SDLocalization.NotFoundData];

                        return new Response<GetCustomerResponse>()
                        {
                            Data = new GetCustomerResponse(),
                            IsNotFound = true,
                            Errors = new string[] { resultMsg },
                            Message = resultMsg
                        };
                    }
                    customerId = cusdtomerData.Id;
                }

                Expression<Func<CustCustomerData, bool>> filter = x =>
                 (x.MeterStartDate >= searchParametersForCustomerDataRequest.StartDate || searchParametersForCustomerDataRequest.StartDate == null)
                 &&
                 (x.MeterStartDate <= searchParametersForCustomerDataRequest.EndDate || searchParametersForCustomerDataRequest.EndDate == null)
                 &&
                 customerId == null ?

                 (searchParametersForCustomerDataRequest.CustomerId == x.Id || searchParametersForCustomerDataRequest.CustomerId == null)
                 &&
                 (searchParametersForCustomerDataRequest.CustomerCode == x.Code || searchParametersForCustomerDataRequest.CustomerCode == null)
                 &&
                 (x.Block.EmployeeBlocks.Any(a => a.Collector_Id == searchParametersForCustomerDataRequest.EmployeeId) || searchParametersForCustomerDataRequest.EmployeeId == null)
                 &&
                 (searchParametersForCustomerDataRequest.AreaId == x.Block.Area_Id || searchParametersForCustomerDataRequest.AreaId == null)
                 &&
                 (searchParametersForCustomerDataRequest.BlockId == x.Block_Id || searchParametersForCustomerDataRequest.BlockId == null)
                 : x.Id == customerId
                 &&
                 (searchParametersForCustomerDataRequest.StateId == x.Block.Area.City.State_Id || searchParametersForCustomerDataRequest.StateId == null)
                 &&
                 (searchParametersForCustomerDataRequest.CityId == x.Block.Area.City_Id || searchParametersForCustomerDataRequest.CityId == null);

                var result = new GetCustomerResponse
                {
                    TotalRecords = await _unitOfWork.CustomerData.Count(filter: filter),

                    Data = await _unitOfWork.CustomerData.GetSpecificSelectAsync(filter,
                     take: searchParametersForCustomerDataRequest.PageSize,
                     skip: (searchParametersForCustomerDataRequest.PageNumber - 1) * searchParametersForCustomerDataRequest.PageSize,

            select: x => new GetCustomer
            {
                Id = x.Id,
                X = x.X,
                Y = x.Y,
                MeterChassisNum = x.MeterChassisNum!,
                BlockName = x.Block.BlockName,
                ActivityId = x.CustomerActivity_Id,
                ActivityName = x.CustomerActivity.Name,
                Name = x.Name!,
                Code = x.Code,
                ActivityStartIsuue = x.ActivityStarIssue,
                ActualActivity = x.ActualActivity!,
                ActualName = x.ActualName,
                AreaId = x.Block.Area_Id,
                AreaName = x.Block.Area.AreaName,
                BlockId = x.Block_Id,
                HasSewage = x.CustomerHasSewage,
                ImagePath = x.ImagePath,
                IsDataComplete = x.IsDataComplete,
                MeterStartDate = x.MeterStartDate,
                MeterStartIssue = x.MeterStartIssue,
                MeterStartReading = x.MeterStartReading,
                NumOfUnits = x.NumOfUnits,
                StartIssue = x.MeterStartIssue,
                StatusId = x.CustomerStatus_Id,
                SubscriptionStartDate = x.SubscriptionStartDate,
                PreviousReading = x.PreviousReading,
                PreviousReadingIssueNumber = x.PreviousReadingIssueNumber,
                Address = x.Address,
            })
                };

                if (result == null || result.Data.ToList().Count == 0)
                {
                    string resultMsg = _sharLocalizer[SDLocalization.NotFoundData];

                    return new Response<GetCustomerResponse>()
                    {
                        IsNotFound = true,
                        Errors = new string[] { resultMsg },
                        Message = resultMsg,
                        Data = new GetCustomerResponse()
                    };
                }

                return new Response<GetCustomerResponse>()
                {
                    IsSuccess = true,
                    Data = result
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(searchParametersForCustomerDataRequest), LogType.Bug);
                return new Response<GetCustomerResponse>()
                {
                    Errors = new string[] { _sharLocalizer[SDLocalization.Error] },
                    Message = ex.Message
                };
            }
        }

        public async Task<Response<IEnumerable<GetCustomerDataForCollectorResponse>>> GetAllCustomerDataByCollectorAsync(long Collector_Id, int IssueDetailsId, long[] BlockIds)
        {
            try
            {
                // update Previous Reading  For all Customer By Collector
                var BlocksCodes = await _unitOfWork.Blocks.GetSpecificSelectAsync(x => BlockIds.Contains(x.Id), y => new String(y.BlockCode));
                var GetRemoteTotalBillsForCustomers = await _unitOfWork.CustomerData.GetCustomersTotalBillsAsync(Collector_Id, string.Join(",", BlocksCodes));

                //var GetRemoteTotalBillsForCustomers= new List<GetCustomersTotalBills_ViewModel> { new GetCustomersTotalBills_ViewModel { CustomerID = 0, BillsCounts = 0, BillsTotalAmount = 0 } };
                var result = await _unitOfWork.CustomerData.GetSpecificSelectAsync(x => (BlockIds.Contains(x.Block_Id) || BlockIds == null || BlockIds.Count() == 0) && x.Block.EmployeeBlocks.Any(a => a.Collector_Id == Collector_Id),
                 orderBy: x => x.OrderBy(a => a.Block_Id),
                select: x => new GetCustomerDataForCollectorResponse
                {
                    Id = x.Id,
                    X = x.X,
                    Y = x.Y,
                    MeterChassisNum = x.MeterChassisNum!,
                    BlockName = x.Block.BlockName,
                    ActivityId = x.CustomerActivity_Id,
                    ActivityName = x.CustomerActivity.Name,
                    Name = x.Name!,
                    Code = x.Code,
                    ActivityStartIsuue = x.ActivityStarIssue,
                    ActualActivity = x.ActualActivity,
                    ActualName = x.ActualName,
                    BranchName = x.Block.Area.City.State.Branch.BranchName,
                    BranchId = x.Block.Area.City.State.Branch_Id,
                    AreaId = x.Block.Area_Id,
                    AreaName = x.Block.Area.AreaName,
                    BlockId = x.Block_Id,
                    HasSewage = x.CustomerHasSewage,
                    ImagePath = x.ImagePath,
                    IsDataComplete = x.IsDataComplete,
                    MeterStartDate = x.MeterStartDate,
                    MeterStartIssue = x.MeterStartIssue,
                    MeterStartReading = x.MeterStartReading,
                    NumOfUnits = x.NumOfUnits,
                    StartIssue = x.MeterStartIssue,
                    StatusId = x.CustomerStatus_Id,
                    SubscriptionStartDate = x.SubscriptionStartDate,
                    PreviousReading = x.PreviousReading,
                    PreviousReadingIssueNumber = x.PreviousReadingIssueNumber,
                    Address = x.Address,
                    HasReading = x.OprMeterReading.Any(a => a.Issue_Details_Id == IssueDetailsId)
                    //CountBill= GetRemoteTotalBillsForCustomers.Any(a=>a.CustomerID==1)? GetRemoteTotalBillsForCustomers.FirstOrDefault(a => a.CustomerID == 1)!.BillsCounts:0 ,
                    //TotalIndebtedness = GetRemoteTotalBillsForCustomers.Where(a => a.CustomerID == x.Id).Select(a => a.BillsTotalAmount).SingleOrDefault()
                });

                result.ToList().ForEach(r =>
                {
                    r.CountBill = GetRemoteTotalBillsForCustomers.Where(a => a.CustomerID == r.Id).Select(a => a.BillsCounts).FirstOrDefault(); r.TotalIndebtedness = GetRemoteTotalBillsForCustomers.Where(a => a.CustomerID == r.Id).Select(a => a.BillsTotalAmount).FirstOrDefault();
                });
                if (result == null || result.ToList().Count == 0)
                {
                    string resultMsg = _sharLocalizer[SDLocalization.NotFoundData];

                    return new Response<IEnumerable<GetCustomerDataForCollectorResponse>>()
                    {
                        Data = new List<GetCustomerDataForCollectorResponse>(),
                        IsNotFound = true,
                        Errors = new string[] { resultMsg },
                        Message = resultMsg
                    };
                }

                return new Response<IEnumerable<GetCustomerDataForCollectorResponse>>()
                {

                    IsSuccess = true,
                    Data = result
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, "");
                return new Response<IEnumerable<GetCustomerDataForCollectorResponse>>()
                {
                    Data = new List<GetCustomerDataForCollectorResponse>(),
                    Errors = new string[] { _sharLocalizer[SDLocalization.Error] },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }
        }


        public async Task<Response<CustCustomerProfileResponse>> GetCustomerDataProfileAsync(FilterForCustomerProfileRequest filterForCustomerProfileRequest)
        {
            try
            {
                long? customerId = null;

                if (filterForCustomerProfileRequest.CustomerId == null && filterForCustomerProfileRequest.CustomerCode == null)
                {
                    string resultMsg = _sharLocalizer[SDLocalization.NotFoundData];

                    return new Response<CustCustomerProfileResponse>()
                    {
                        Data = new CustCustomerProfileResponse(),
                        IsNotFound = true,
                        Errors = new string[] { resultMsg },
                        Message = resultMsg
                    };
                }

                if (!string.IsNullOrEmpty(filterForCustomerProfileRequest.CustomerCode))
                {
                    var cusdtomerData = await _unitOfWork.CustomerData.GetFirstOrDefaultAsync(x => x.Code ==
                    filterForCustomerProfileRequest.CustomerCode);

                    if (cusdtomerData == null)
                    {
                        string resultMsg = _sharLocalizer[SDLocalization.NotFoundData];

                        return new Response<CustCustomerProfileResponse>()
                        {
                            Data = new CustCustomerProfileResponse(),
                            IsNotFound = true,
                            Errors = new string[] { resultMsg },
                            Message = resultMsg
                        };
                    }
                    customerId = cusdtomerData.Id;
                }
                //customerId == null ?
                var result = await _unitOfWork.CustomerData.GetSpecificSelectAsync(x => x.Code ==
                   filterForCustomerProfileRequest.CustomerCode || x.Id == filterForCustomerProfileRequest
                   .CustomerId,
                   //: x.Id == customerId ,

                   select: x => new CustCustomerProfileResponse()
                   {
                       Id = x.Id,
                       X = x.X,
                       Y = x.Y,
                       MeterChassisNum = x.MeterChassisNum!,
                       BlockName = x.Block.BlockName,
                       ActivityId = x.CustomerActivity_Id,
                       Name = x.Name!,
                       Code = x.Code,
                       ActivityStartIsuue = x.ActivityStarIssue,
                       ActualActivity = x.ActualActivity!,
                       ActualName = x.ActualName,
                       AreaId = x.Block.Area_Id,
                       AreaName = x.Block.Area.AreaName,
                       BlockId = x.Block_Id,
                       HasSewage = x.CustomerHasSewage,
                       ImagePath = x.ImagePath,
                       IsDataComplete = x.IsDataComplete,
                       MeterStartDate = x.MeterStartDate,
                       MeterStartIssue = x.MeterStartIssue,
                       MeterStartReading = x.MeterStartReading,
                       NumOfUnits = x.NumOfUnits,
                       StartIssue = x.MeterStartIssue,
                       StatusId = x.CustomerStatus_Id,
                       SubscriptionStartDate = x.SubscriptionStartDate,
                       PreviousReading = x.PreviousReading,
                       PreviousReadingIssueNumber = x.PreviousReadingIssueNumber,
                       Address = x.Address,
                   });
                if (result == null || result.ToList().Count == 0)
                {
                    string resultMsg = _sharLocalizer[SDLocalization.NotFoundData];

                    return new Response<CustCustomerProfileResponse>()
                    {
                        Data = new CustCustomerProfileResponse(),
                        IsNotFound = true,
                        Errors = new string[] { resultMsg },
                        Message = resultMsg
                    };
                }
                return new Response<CustCustomerProfileResponse>()
                {
                    IsSuccess = true,
                    Data = result.FirstOrDefault()!
                };
            }
            catch (Exception ex)
            {
                string err = String.Format(_sharLocalizer[SDLocalization.Error]);
                await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(filterForCustomerProfileRequest), LogType.Bug);
                return new Response<CustCustomerProfileResponse>()
                {
                    Errors = new[] { err },
                    Message = err,
                    IsSuccess = false
                };
            }
        }

        public async Task<Response<IEnumerable<SharSelectListGroupResponse>>> ListOfCustomer(FilterWithTwoFlagsCustomerRequest filterWithTwoFlagsCustomerRequest)
        {
            try
            {
                var result = await _unitOfWork.CustomerData.GetSpecificSelectAsync(x => x.Block.Area_Id ==
            filterWithTwoFlagsCustomerRequest.AreaId && (x.Block_Id ==
            filterWithTwoFlagsCustomerRequest.BlockId || filterWithTwoFlagsCustomerRequest.BlockId == null),
            select: x => new SharSelectListGroupResponse
            {
                Id = x.Id,
                Name = x.Name!,
                Group = x.Block.Area.AreaName,
                Title = x.Block.BlockName
            });
                if (result == null || result.ToList().Count == 0)
                {
                    string resultMsg = _sharLocalizer[SDLocalization.NotFoundData];

                    return new Response<IEnumerable<SharSelectListGroupResponse>>()
                    {
                        IsNotFound = true,
                        Errors = new string[] { resultMsg },
                        Message = resultMsg
                    };
                }

                return new Response<IEnumerable<SharSelectListGroupResponse>>()
                {
                    IsSuccess = true,
                    Data = result
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(filterWithTwoFlagsCustomerRequest), LogType.Bug);
                return new Response<IEnumerable<SharSelectListGroupResponse>>()
                {
                    Errors = new string[] { _sharLocalizer[SDLocalization.Error] },
                    Message = ex.Message
                };
            }

        }

        public async Task<Response<GetCustomerDataResponse>> ActiveOrDeActiveForCompletedDataAsync(int customerDataId)
        {
            try
            {
                var customerData = await _unitOfWork.CustomerData.GetFirstOrDefaultAsync(x => x.Id == customerDataId &&
            !x.IsDeleted);

                var customerDataRequest = _mapper.Map<GetCustomerDataResponse>(customerData);

                if (customerData is null)
                {
                    string resultMsg = string.Format(_sharLocalizer[SDLocalization.CannotBeFound],
                        _sharLocalizer[SDLocalization.Customer], customerDataId);

                    return new Response<GetCustomerDataResponse>()
                    {
                        IsNotFound = true,
                        Data = customerDataRequest,
                        Errors = new string[] { resultMsg },
                        Message = resultMsg
                    };
                }
                customerData.IsDataComplete = !customerData.IsDataComplete;
                _unitOfWork.CustomerData.Update(customerData);

                return new Response<GetCustomerDataResponse>()
                {
                    IsSuccess = await _unitOfWork.CompleteAsync() > 0,
                    IsUpdated = true,
                    Message = customerData.IsDataComplete
                    ? _sharLocalizer[SDLocalization.Activated]
                    : _sharLocalizer[SDLocalization.DeActivated]
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, "");
                return new Response<GetCustomerDataResponse>()
                {
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] { ex.Message }
                };
            }

        }

        public async Task<Response<IEnumerable<SelectListResponseIdInt>>> ListOfCustomerActivitesAsync()
        {
            try
            {
                return new Response<IEnumerable<SelectListResponseIdInt>>()
                {
                    Data = _mapper.Map<IEnumerable<SelectListResponseIdInt>>(await _unitOfWork.CustomerActivities.GetAllAsync
                    (x => !x.IsDeleted)),
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, "");
                return new Response<IEnumerable<SelectListResponseIdInt>>()
                {
                    Data = new List<SelectListResponseIdInt>(),
                    Errors = new[] { ex.Message },
                    Message = _sharLocalizer[SDLocalization.Error]
                };
            }
        }

        public async Task<Response<string>> ManageRemoteCustomersAsync()
        {
            try
            {
                #region Customer activity

                //Get all the new customer activity by calling the remote stored procedure and get the records after our last record id

                var existingCustomerActivities = (await _unitOfWork.CustomerActivities.GetAllAsync(filter: x => true)).ToList();

                var LastExistingIdCustomerActivity = existingCustomerActivities.LastOrDefault() != null ? existingCustomerActivities.LastOrDefault().Id : 0;

                var RemoteData = (await _unitOfWork.CustomerActivities.GetRemoteCustomerActivityAsync()).ToList().Select(obj => new CustCustomerActivity() { Id = obj.Id + LastExistingIdCustomerActivity, Name = obj.Name }).ToList();

                await _unitOfWork.CustomerActivities.AddRangeAsync(RemoteData.Where(obj => !existingCustomerActivities.Any(y => y.Name == obj.Name)));

                _unitOfWork.Complete();

                #endregion

                #region Customer data

                //Get all the new customer data by calling the remote stored procedure and get the records after our last record id

                var lastCusotmerId = await _unitOfWork.CustomerData.GetFirstOrDefaultAsync(filter: x => !x.IsDeleted, orderBy: x => x.OrderByDescending(y => y.Id));

                // Replace tHE inner Join to be After the Group Statement
                // Use Truncate and remove Delete 
                //await _unitOfWork.CustomerData.GetRemoteCustomerDataAsync(lastCusotmerId != null ? lastCusotmerId.Id : 0);

                var customerActivitiesData = (await _unitOfWork.CustomerActivities.GetSpecificSelectAsync(filter: obj => true, select: obj => new SelectIntListResponse() { Id = obj.Id, Name = obj.Name })).ToList();

                var remoteData = await _unitOfWork.CustomerData.GetRemoteCustomerDataAsync(lastCusotmerId != null ? lastCusotmerId.Id : 0);
                var addingDataCustomer = _mapper.Map<IEnumerable<CustCustomerData>>(remoteData).ToList();
                foreach (var item in addingDataCustomer)
                {
                    var searchedActivityObject = customerActivitiesData.FirstOrDefault(obj => obj.Name == item.ActualActivity);
                    item.CustomerActivity_Id = searchedActivityObject != null ? searchedActivityObject.Id : 0;
                }
                var uniqCustomers = addingDataCustomer.Where(obj => obj.CustomerActivity_Id != 0).DistinctBy(x => x.Id);
                await _unitOfWork.CustomerData.AddRangeAsync(uniqCustomers);
                _unitOfWork.Complete();

                ////Commmit the Updated Customer Data

                //var AllRemoteData = _mapper.Map<List<CustCustomerDataTemp>>(await _unitOfWork.CustomerData.GetRemoteCustomerDataAsync(0));
                //await _unitOfWork.CustomerData_Temp.AddRangeAsync(AllRemoteData);
                //_unitOfWork.Complete();
                //await _unitOfWork.CustomerData.CommitAllRemoteCustomerDataChanges();

                #endregion

                return new Response<string>()
                {
                    Message = _sharLocalizer[SDLocalization.Done],
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, "");
                return new Response<string>()
                {
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] { ex.Message }
                };
            }
        }


        public async Task<Response<GetMeterReadingForAllCustomersResponse>> GetAllMeterReadingsAsync(SearchParametersForMeterReadingsRequest searchParametersRequest)
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
                        return new Response<GetMeterReadingForAllCustomersResponse>()
                        {
                            Data = new GetMeterReadingForAllCustomersResponse(),
                            IsNotFound = true,
                            Errors = new string[] { resultMsg },
                            Message = resultMsg
                        };
                    customerId = cusdtomerData.Id;
                }
                string UserId = _accessor!.HttpContext == null ? "" : _accessor!.HttpContext!.User.GetUserId();
                var BranchesUsersIds = await _unitOfWork.Users.GetAssignedBranches(UserId);

                Expression<Func<CustCustomerData, bool>> filter = x =>
                (x.OprMeterReading.Any(a=> BranchesUsersIds.Contains(a.Employee.Branch_Id)))
                &&
                (x.OprMeterReading.Any(a=>a.Employee_Id == searchParametersRequest.EmployeeId) || searchParametersRequest.EmployeeId == null) &&
                (x.OprMeterReading.Any(a=>a.MeterReadingDate >= searchParametersRequest.StartDate) || searchParametersRequest.StartDate == null)
                &&
                (x.OprMeterReading.Any(a=>a.MeterReadingDate <= searchParametersRequest.EndDate) || searchParametersRequest.EndDate == null)
                &&
                customerId == null ?

                (x.OprMeterReading.Any(a=>a.Customer_Id ==searchParametersRequest.CustomerId ) || searchParametersRequest.CustomerId == null)
                &&
                (x.OprMeterReading.Any(a=>a.CustomerData.Code== searchParametersRequest.CustomerCode) || searchParametersRequest.CustomerCode == null)

                &&
                (x.OprMeterReading.Any(a=>a.Employee.Branch_Id== searchParametersRequest.BranchId))
                &&
                (x.OprMeterReading.Any(a=>a.Issue_Details_Id== searchParametersRequest.IssueDetailsId))

                &&
                (x.OprMeterReading.Any(a => a.CustomerData.Block.Area_Id== searchParametersRequest.AreaId) || searchParametersRequest.AreaId == null)
                &&
                (x.OprMeterReading.Any(a => a.CustomerData.Block_Id== searchParametersRequest.BlockId) || searchParametersRequest.BlockId == null)
                &&
                (x.OprMeterReading.Any(a => a.CustomerData.Block.Area.City_Id==searchParametersRequest.CityId) || searchParametersRequest.CityId == null)
                &&
                (x.OprMeterReading.Any(a => a.CustomerData.Block.Area.City.State_Id==searchParametersRequest.StateId) || searchParametersRequest.StateId == null)
                &&
                (x.OprMeterReading.Any(a => a.IsRevised == searchParametersRequest.IsRevised) || searchParametersRequest.IsRevised == null)
               
                : x.Id == customerId;

                var result = new GetMeterReadingForAllCustomersResponse
                {
                    TotalRecords = await _unitOfWork.CustomerData.Count(filter: filter),

                    Data = await _unitOfWork.CustomerData.GetSpecificSelectAsync(filter,
                     take: searchParametersRequest.PageSize,
                     skip: (searchParametersRequest.PageNumber - 1) * searchParametersRequest.PageSize,
                select: x => new GetMeterReadingForAllCustomers
                {
                    CustomerId = x.Id,
                    CollectorName = x.OprMeterReading.MaxBy(m => m.Id)!.Employee.Name,
                    CustomerName = x.Name!,
                    LastReading = x.OprMeterReading.MaxBy(m => m.Id)!.PreviousReading,
                    IsUpnormalReading = (x.OprMeterReading.MaxBy(m => m.Id)!.Value - x.OprMeterReading.MaxBy(m => m.Id)!.PreviousReading) > x.CustomerActivity.ReadingAvg,
                    MeterStatus = x.OprMeterReading.MaxBy(m => m.Id)!.MeterStatus.Name,
                    Value = x.OprMeterReading.MaxBy(m => m.Id)!.Value,
                    Notes = x.OprMeterReading.MaxBy(m => m.Id)!.Notes!,
                    ReadingImagePath = x.OprMeterReading.MaxBy(m => m.Id)!.ReadingImagePath!,
                    X = x.OprMeterReading.MaxBy(m => m.Id)!.X,
                    Y = x.OprMeterReading.MaxBy(m => m.Id)!.Y,
                    MeterReadingDate = x.OprMeterReading.MaxBy(m => m.Id)!.MeterReadingDate,
                    BranchName = x.OprMeterReading.MaxBy(m => m.Id)!.Employee.Branch.BranchName,
                    IssueName = x.OprMeterReading.MaxBy(m => m.Id)!.IssueDetails.Issue.IssueName,




                }, orderBy: x =>
                              x.OrderByDescending(x => x.Id))
                };

                if (result == null || result.Data.ToList().Count == 0)
                    return new Response<GetMeterReadingForAllCustomersResponse>()
                    {
                        Data = new GetMeterReadingForAllCustomersResponse(),
                        IsNotFound = true,
                        Errors = new string[] { resultMsg },
                        Message = resultMsg
                    };

                return new Response<GetMeterReadingForAllCustomersResponse>()
                {
                    IsSuccess = true,
                    Data = result
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(searchParametersRequest), LogType.Bug);
                return new Response<GetMeterReadingForAllCustomersResponse>()
                {
                    Errors = new string[] { _sharLocalizer[SDLocalization.Error] },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }
        }

        #endregion
    }

}