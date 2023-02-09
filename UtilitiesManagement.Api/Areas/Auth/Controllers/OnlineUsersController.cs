namespace  UtilitiesManagement.Api.Areas.Auth.Controllers
{
    [Area(Modules.Auth)]
    [ApiController]
    [ApiExplorerSettings(GroupName = Modules.Auth)]
    public class OnlineUsersController : ControllerBase
    {
        private readonly IOnlineUsersService _usersService;

        public OnlineUsersController(IOnlineUsersService usersService) =>
            _usersService = usersService;

        [HttpGet(ApiRoutes.Users.GetUsers)]
        [Authorize(Permissions.Users.View)]
        public async Task<IActionResult> GetUsersAsync(bool? connectionStatus = null, int? companyId = null) =>
            Ok(await _usersService.GetUsersAsync(connectionStatus, companyId));

        [HttpGet(ApiRoutes.Users.GetUserLogs)]
        [Authorize(Permissions.Users.View)]
        public async Task<IActionResult> GetUserLogsAsync([FromQuery] AuthSearchForDisabledUsersRequest searchForDisabledUsersRequest) =>
            Ok(await _usersService.GetUserLogsAsync(searchForDisabledUsersRequest));

        [HttpGet(ApiRoutes.Users.GetNumOfOnlineUsers)]
        [Authorize(Permissions.Users.View)]
        public async Task<IActionResult> GetNumOfOnlineUsersAsync(int? companyId) =>
            Ok(await _usersService.GetNumOfOnlineUsersAsync(companyId));

        [HttpGet(ApiRoutes.Users.GetListOfUsers)]
        [Authorize(Permissions.Users.View)]
        public async Task<IActionResult> GetListOfUsersAsync(int companyId) =>
            Ok(await _usersService.ListOfUsersAsync(companyId));


    }
}
