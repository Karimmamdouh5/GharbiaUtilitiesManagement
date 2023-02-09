namespace UtilitiesManagement.Services.Services.Report
{
    public class IssuesReportService : IIssuesReportService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;
        private readonly ILoggingRepository _customLog;
        private readonly IMapper _mapper;

        public IssuesReportService(IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharLocalizer,
                                   ILoggingRepository loggingRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _sharLocalizer = sharLocalizer;
            _customLog = loggingRepository;
            _mapper = mapper;
        }

        #region Issues report 

        public async Task<Response<string>> ManageRemoteCustomersAsync()
        {
            using var transaction = _unitOfWork.BeginTransaction();
            try
            {
                #region Customer activity

                ////Get all the new customer activity by calling the remote stored procedure and get the records after our last record id
                             
                //var lastCustomerActivity = _unitOfWork.CustomerActivities.GetFirstOrDefault(orderBy: x =>
                //x.OrderByDescending(x => x.Id));

                //var newCustomerActivity = _mapper.Map<List<CustCustomerActivity>>
                //    (await _unitOfWork.CustomerActivities.GetRemoteCustomerActivityAsync(lastCustomerActivity
                //    != null ? lastCustomerActivity.Id : 0, false));

                //await _unitOfWork.CustomerActivities.AddRangeAsync(newCustomerActivity);

                //_unitOfWork.Complete();

                //var updatingCustomerActivities = _mapper.Map<IEnumerable<CustCustomerActivity>>(await
                //_unitOfWork.CustomerActivities.GetRemoteCustomerActivityAsync(0, true)).Where(x => newCustomerActivity.All(y => y.Id != x.Id));
                //// Get The Updated activity Data, then update them in  our DB and then change the flag in the remote database
                //_unitOfWork.CustomerActivities.UpdateRange(updatingCustomerActivities);

                //_unitOfWork.Complete();
                //await _unitOfWork.CustomerActivities.CommitAllRemoteCustomerActivityChangesAsync();

                #endregion

                #region Customer status

                //Get all the new customer status by calling the remote stored procedure and get the records after our last record id
                var lastCustomerStatus = _unitOfWork.CustomerStatus.GetFirstOrDefault(orderBy: x =>
                x.OrderByDescending(x => x.Id));

                var newCustomerStatus = _mapper.Map<List<CustCustomerStatus>>(await
                    _unitOfWork.CustomerStatus.GetRemoteCustomerStatusAsync(lastCustomerStatus != null ?
                    lastCustomerStatus.Id : 0, false));
                await _unitOfWork.CustomerStatus.AddRangeAsync(newCustomerStatus);

                _unitOfWork.Complete();

                var updatingCustomerStatus = _mapper.Map<IEnumerable<CustCustomerStatus>>(await
                _unitOfWork.CustomerStatus.GetRemoteCustomerStatusAsync(0, true)).Where(x => newCustomerStatus.All(y => y.Id != x.Id));
                // Get The Updated status Data, then update them in  our DB and then change the flag in the remote database
                _unitOfWork.CustomerStatus.UpdateRange(updatingCustomerStatus);

                _unitOfWork.Complete();
                await _unitOfWork.CustomerStatus.CommitAllRemoteCustomerStatusChangesAsync();

                #endregion

                //#region Customer data

                ////Get all the new customer data by calling the remote stored procedure and get the records after our last record id
                //var lastCustomerData = _unitOfWork.CustomerData.GetFirstOrDefault(orderBy: x =>
                //x.OrderByDescending(x => x.Id));

                //var newCustomerData = _mapper.Map<IEnumerable<CustCustomerData>>(await
                //    _unitOfWork.CustomerData.GetRemoteCustomerDataAsync(lastCustomerData != null ? lastCustomerData.Id
                //    : 0, false));
                //await _unitOfWork.CustomerData.AddRangeAsync(newCustomerData);

                //_unitOfWork.Complete();

                //// Get The Updated customer Data, then update them in  our DB and then change the flag in the remote database
                //var mappedCustCustomerData = _mapper.Map<IEnumerable<CustCustomerData>>(await _unitOfWork.CustomerData
                //    .GetRemoteCustomerDataAsync(0, true)).Where(x => newCustomerData.All(y => y.Id != x.Id));

                //_unitOfWork.CustomerData.UpdateRange(mappedCustCustomerData);

                //_unitOfWork.Complete();
                //await _unitOfWork.CustomerData.CommitAllRemoteCustomerDataChanges();

                //#endregion

                transaction.Commit();
                return new Response<string>()
                {
                    Message = _sharLocalizer[SDLocalization.Done],
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return new Response<string>()
                {
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] { ex.Message }
                };
            }
        }

        public async Task<Response<IEnumerable<BillIssueReportResponse>>> GetTopTwelveIssuesAsync(long companyId)
        {
            try
            {
                return new Response<IEnumerable<BillIssueReportResponse>>()
                {

                    IsSuccess = true,
                    Data = await _unitOfWork.Issue.GetTopTwelveIssuesAsync(companyId)
                };
            }
            catch (Exception ex)
            {
                return new Response<IEnumerable<BillIssueReportResponse>>()
                {
                    Data = new List<BillIssueReportResponse>(),
                    Errors = new string[] { _sharLocalizer[SDLocalization.Error] },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }
        }

        #endregion
    }

}