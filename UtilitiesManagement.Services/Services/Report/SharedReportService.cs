namespace UtilitiesManagement.Services.Services.Report
{
    public class SharedReportService : ISharedReportService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;
        private readonly ILoggingRepository _customLog;
        private readonly IMapper _mapper;

        public SharedReportService(IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharLocalizer,
                                   ILoggingRepository loggingRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _sharLocalizer = sharLocalizer;
            _customLog = loggingRepository;
            _mapper = mapper;
        }

        #region Shared report 

        public async Task<Response<IEnumerable<SharTotalDailyStatisticsReportResponse>>> GetTotalDailyStatisticsAsync(SharDailyStatisticsSearchParametersRequest dailyStatisticsSearchParametersRequest)
        {
            try
            {
                dailyStatisticsSearchParametersRequest.EndDate = dailyStatisticsSearchParametersRequest.EndDate.AddHours(23)
                    .AddMinutes(59).AddSeconds(59);

                return new Response<IEnumerable<SharTotalDailyStatisticsReportResponse>>()
                {

                    IsSuccess = true,
                    Data = await _unitOfWork.DailyStatistics.GetTotalDailyStatisticsAsync(dailyStatisticsSearchParametersRequest)
                };
            }
            catch (Exception ex)
            {
                return new Response<IEnumerable<SharTotalDailyStatisticsReportResponse>>()
                {
                    Data = new List<SharTotalDailyStatisticsReportResponse>(),
                    Errors = new string[] { _sharLocalizer[SDLocalization.Error] },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }
        }

        public async Task<Response<SharTotalDailyStatisticsPerEmployeeReportResponse>> GetTotalDailyStatisticsPerEmployeeAsync(SharDailyStatisticsSearchParametersRequest dailyStatisticsSearchParametersRequest)
        {
            dailyStatisticsSearchParametersRequest.EndDate = dailyStatisticsSearchParametersRequest.EndDate.AddHours(23)
                .AddMinutes(59).AddSeconds(59);

            try
            {
                var (result, totalRecords) = await _unitOfWork.DailyStatistics.GetTotalDailyStatisticsPerEmployeeAsync
                    (new SharDailyStatisticsSearchParametersForDBRequest
                    {
                        CompanyId = dailyStatisticsSearchParametersRequest.CompanyId,
                        StartDate = dailyStatisticsSearchParametersRequest.StartDate,
                        EndDate = dailyStatisticsSearchParametersRequest.EndDate,
                        Take = dailyStatisticsSearchParametersRequest.PageSize,
                        Skip = (dailyStatisticsSearchParametersRequest.PageNumber - 1) * dailyStatisticsSearchParametersRequest.PageSize
                    });

                return new Response<SharTotalDailyStatisticsPerEmployeeReportResponse>()
                {

                    IsSuccess = true,
                    Data = new SharTotalDailyStatisticsPerEmployeeReportResponse()
                    {
                        TotalRecords = totalRecords,
                        Data = result
                    }
            };
            }
            catch (Exception ex)
            {
                return new Response<SharTotalDailyStatisticsPerEmployeeReportResponse>()
                {
                    Data = new SharTotalDailyStatisticsPerEmployeeReportResponse(),
                    Errors = new string[] { _sharLocalizer[SDLocalization.Error] },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }
        }

        public async Task<Response<IEnumerable<SharTotalDailyStatisticsForEmployeeReportResponse>>> GetTotalDailyStatisticsForSpecificEmployeeAsync(SharDailyStatisticsSearchParametersForEmployeeRequest dailyStatisticsSearchParametersRequest)
        {
            DateTime dateTime = DateTime.Now;
            DateOnly? StartDate;
            DateOnly? EndDate;
            if (dailyStatisticsSearchParametersRequest.StartDate == null)
                StartDate = DateOnly.
                    FromDateTime(dateTime.AddDays(-7));
            else
                StartDate = DateOnly.FromDateTime(dailyStatisticsSearchParametersRequest.StartDate.Value);

            if (dailyStatisticsSearchParametersRequest.EndDate == null)
                EndDate = DateOnly.
                    FromDateTime(dateTime).AddDays(1);
            else
                EndDate = DateOnly.FromDateTime(dailyStatisticsSearchParametersRequest.EndDate.Value).AddDays(1); 

            try
            {
                SharDailyStatisticsSearchParametersForEmployee dataSearch = new SharDailyStatisticsSearchParametersForEmployee { EmployeeId = dailyStatisticsSearchParametersRequest.EmployeeId, EndDate = EndDate.Value, StartDate = StartDate.Value };
                return new Response<IEnumerable<SharTotalDailyStatisticsForEmployeeReportResponse>>()
                {
                    IsSuccess = true,
                    Data = await _unitOfWork.DailyStatistics.GetTotalDailyStatisticsForEmployeeAsync(dataSearch)
                };
            }
            catch (Exception ex)
            {
                return new Response<IEnumerable<SharTotalDailyStatisticsForEmployeeReportResponse>>()
                {
                    Data = new List<SharTotalDailyStatisticsForEmployeeReportResponse>(),
                    Errors = new string[] { _sharLocalizer[SDLocalization.Error] },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }



            throw new NotImplementedException();
        }

        #endregion
    }

}