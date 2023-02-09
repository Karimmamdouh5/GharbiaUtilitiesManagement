namespace UtilitiesManagement.Services.IServices.Report
{
    public interface ISharedReportService
    {
        Task<Response<IEnumerable<SharTotalDailyStatisticsReportResponse>>> GetTotalDailyStatisticsAsync(SharDailyStatisticsSearchParametersRequest dailyStatisticsSearchParametersRequest);
        Task<Response<SharTotalDailyStatisticsPerEmployeeReportResponse>> GetTotalDailyStatisticsPerEmployeeAsync(SharDailyStatisticsSearchParametersRequest dailyStatisticsSearchParametersRequest);
        Task<Response<IEnumerable<SharTotalDailyStatisticsForEmployeeReportResponse>>> GetTotalDailyStatisticsForSpecificEmployeeAsync(SharDailyStatisticsSearchParametersForEmployeeRequest dailyStatisticsSearchParametersRequest);
    }
}
