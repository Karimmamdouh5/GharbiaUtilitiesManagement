namespace UtilitiesManagement.Services.IServices.Report
{
    public interface IIssuesReportService
    {
        Task<Response<IEnumerable<BillIssueReportResponse>>> GetTopTwelveIssuesAsync(long companyId);
    }
}
