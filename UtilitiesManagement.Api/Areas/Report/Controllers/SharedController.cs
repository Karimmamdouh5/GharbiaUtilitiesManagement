namespace UtilitiesManagement.Api.Areas.Operation.Controllers
{
    [Area(Modules.Report)]
    [ApiController]
    [ApiExplorerSettings(GroupName = Modules.Report)]
    public class SharedController : ControllerBase
    {
        private readonly ISharedReportService _sharedReportService;

        public SharedController(ISharedReportService sharedReportService) =>
            _sharedReportService = sharedReportService;

        [HttpGet(ApiRoutes.Shared.GetTotalDailyStatistics)]
        public async Task<IActionResult> GetTotalDailyStatisticsAsync([FromQuery] SharDailyStatisticsSearchParametersRequest model) =>
            Ok(await _sharedReportService.GetTotalDailyStatisticsAsync(model));

        [HttpGet(ApiRoutes.Shared.GetTotalDailyStatisticsPerEmployee)]
        public async Task<IActionResult> GetTotalDailyStatisticsPerEmployeeAsync([FromQuery] SharDailyStatisticsSearchParametersRequest model) =>
            Ok(await _sharedReportService.GetTotalDailyStatisticsPerEmployeeAsync(model));

        [HttpGet(ApiRoutes.Shared.GetTotalDailyStatisticsForEmployee)]
        public async Task<IActionResult> GetTotalDailyStatisticsForEmployeeAsync([FromQuery] SharDailyStatisticsSearchParametersForEmployeeRequest model) =>
            Ok(await _sharedReportService.GetTotalDailyStatisticsForSpecificEmployeeAsync(model));
    }
}
