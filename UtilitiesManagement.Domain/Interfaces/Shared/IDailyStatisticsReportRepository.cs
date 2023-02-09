namespace UtilitiesManagement.Domain.Interfaces.Shared
{
    public interface IDailyStatisticsReportRepository: IBaseRepository<BillIssue>
    {
        Task<IEnumerable<SharTotalDailyStatisticsReportResponse>> GetTotalDailyStatisticsAsync(SharDailyStatisticsSearchParametersRequest dailyStatisticsSearchParametersRequest);
        Task<(IEnumerable<SharTotalDailyStatisticsPerEmployeeReport>, int totalRecords)> GetTotalDailyStatisticsPerEmployeeAsync(SharDailyStatisticsSearchParametersForDBRequest model);
        Task<IEnumerable<SharTotalDailyStatisticsForEmployeeReportResponse>> GetTotalDailyStatisticsForEmployeeAsync(SharDailyStatisticsSearchParametersForEmployee model);
    }
}
