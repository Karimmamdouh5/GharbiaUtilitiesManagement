using UtilitiesManagement.Domain.Dtos.Request.DashBoard;

namespace UtilitiesManagement.Api.Areas.Report.Controllers
{
    [Area(Modules.DashBoard)]
    [ApiController]
    [ApiExplorerSettings(GroupName = Modules.DashBoard)]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class DashBoardController:ControllerBase
    {
        private readonly IDashBoardServices _dashBoardServices;
        public DashBoardController(IDashBoardServices dashBoardServices)
        {
            _dashBoardServices = dashBoardServices;
        }
        [HttpGet(ApiRoutes.DashBoard.GetURLs)]
        public async Task<IActionResult> GetURLs()
        {
            var Data = await _dashBoardServices.GetURLs();
            if (!Data.IsSuccess)
            {
                return StatusCode(500, Data);
            }
            return Ok(Data);
        }
        [HttpGet(ApiRoutes.DashBoard.GetBillsStatistics)]
        public async Task<IActionResult> GetBillsStatistics([FromQuery]DashBoardCustomerBillsStatRequest model)
        {
            var Data = await _dashBoardServices.GetCustomerBillsStatistics(model);
            if (!Data.IsSuccess)
            {
                return StatusCode(500, Data);
            }
            return Ok(Data);
        }
        [HttpGet(ApiRoutes.DashBoard.TotalMonthlyStatisticsForEmployee)]
        public async Task<IActionResult> TotalMonthlyStatisticsForEmployee([FromQuery] StatisticsRequest model)
        {
            var Data = await _dashBoardServices.TotalMonthlyStatisticsForEmployee(model);
            if (!Data.IsSuccess)
            {
                return StatusCode(500, Data);
            }
            return Ok(Data);
        }
        [HttpGet(ApiRoutes.DashBoard.TotalDailyStatisticsForEmployee)]
        public async Task<IActionResult> TotalDailyStatisticsForEmployee([FromQuery] StatisticsRequest model)
        {
            var Data = await _dashBoardServices.TotalDailyStatisticsForEmployee(model);
            if (!Data.IsSuccess)
            {
                return StatusCode(500, Data);
            }
            return Ok(Data);
        }
    }
}
