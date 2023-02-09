namespace UtilitiesManagement.Api.Areas.Operation.Controllers
{
    [Area(Modules.Report)]
    [ApiController]
    [ApiExplorerSettings(GroupName = Modules.Report)]
    public class IssuesController : ControllerBase
    {
        private readonly IIssuesReportService _issuesReportService;

        public IssuesController(IIssuesReportService issuesReportService) =>
            _issuesReportService = issuesReportService;

        [HttpGet(ApiRoutes.Bills.GetTopTwelveIssues)]
        public async Task<IActionResult> GetTopTwelveIssuesAsync(long companyId) =>
            Ok(await _issuesReportService.GetTopTwelveIssuesAsync(companyId));
    }
}
