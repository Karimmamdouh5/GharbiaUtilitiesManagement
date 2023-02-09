using System.ComponentModel.DataAnnotations;
using System.Text;
using UtilitiesManagement.Domain.Interfaces.Align;

namespace  UtilitiesManagement.Api.Areas.Auth.Controllers
{
    [Area(Modules.Auth)]
    [ApiController]
    [ApiExplorerSettings(GroupName = Modules.Auth)]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public IHttpContextAccessor _accessor { get; set; }
        public IStaticDataServices _staticDataService { get; }
        public ILogger<AuthController> Logger { get; }

        public AuthController(IAuthService authService, IHttpContextAccessor accessor, IStaticDataServices StaticDataService, ILogger<AuthController> logger) {
            _authService = authService;
            _accessor = accessor;
            _staticDataService = StaticDataService;
            Logger = logger;
        }

        //[HttpPost("register")]
        //public async Task<IActionResult> RegisterAsync([FromBody] RegisterRequest model)
        //{
        //    var result = await _authService.RegisterAsync(model);

        //    if (!result.IsAuthenticated)
        //        return BadRequest(result);

        //    return Ok(result);
        //}
        [AllowAnonymous]
        [HttpPost(ApiRoutes.Auth.CheckServer)]
        public async Task<IActionResult> CheckServer()
        {
            var checkingResult =await _authService.CheckConnection();
            if (checkingResult.Length == 0)
                return Ok(checkingResult);
            return BadRequest(checkingResult);
        }

        [AllowAnonymous]
        [HttpPost(ApiRoutes.Auth.Login)]
        public async Task<IActionResult> GetTokenAsync(LoginRequest model)
        {

            var result = await _authService.GetTokenAsync(model);
            return !result.IsAuthenticated ?
               StatusCode(StatusCodes.Status500InternalServerError, result) : Ok(result);
        }

        [AllowAnonymous]
        [HttpPost(ApiRoutes.Auth.CompanyConfiguration)]
        public async Task<IActionResult> CompanyConfiguration(string code)
        {
            var authResponse = await _authService.CheckCompanyActivationAndVersionAsync(code);
            if (!authResponse.IsSuccess)
                return StatusCode(StatusCodes.Status500InternalServerError, authResponse);
            return Ok(authResponse);
        }

        [AllowAnonymous]
        [HttpGet(ApiRoutes.Auth.GetUserData)]
        public async Task<IActionResult> getUser()
        {
            var userId = _accessor?.HttpContext?.User?.FindFirst("uid")?.Value ?? "";

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _authService.GetUserDataAsync(userId);
            if (!result.IsSuccess)
                return BadRequest(result.Errors);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpPost(ApiRoutes.Auth.Logout)]
        public async Task<IActionResult> LogoutAsync(string userId)
        {
            var authResponse = await _authService.LogoutAsync(userId);
            if (authResponse.IsSuccess)
                return Ok(authResponse);

            return NotFound(authResponse);
        }
        [AllowAnonymous]
        [HttpPost(ApiRoutes.Auth.UserRegister)]
        public async Task<IActionResult> UserRegister(AuthResigterRequest resigterRequest)
        {
            var Result = await _authService.UserRegister(resigterRequest);
            if (!Result.IsSuccess)
                return StatusCode(500, Result);
            return Ok(Result);
        }
        [HttpPut(ApiRoutes.Auth.ChangePassword)]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePassWordRequest model)
        {
            var Result = await _authService.ChangePassWord(model);
            if (!Result.IsSuccess)
                return StatusCode(500, Result);
            return Ok(Result);
        }

        [HttpPut(ApiRoutes.Auth.UpdateUser)]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserRequest model, string Id)
        {
            var Result = await _authService.UpdateUser(model, Id);
            if (!Result.IsSuccess)
                return StatusCode(500, Result);
            return Ok(Result);
        }
        [HttpGet(ApiRoutes.Auth.GetUserBranches)]
        public async Task<IActionResult> GetUserBranches([Required]string userId)
        {
            var Result = await _authService.GetUserBranches(userId);
            if (!Result.IsSuccess)
                return StatusCode(500, Result);
            return Ok(Result);
        }
        [Authorize(Permissions.Permission.View)]
        [HttpGet(ApiRoutes.Auth.GetCompanyUsers)]
        public async Task<IActionResult> GetCompanyUsers(int CompanyId , String? RoleId,string? UserName)
        {
            var Result = await _authService.GetCompanyUsers(CompanyId, RoleId, UserName);
            if (!Result.IsSuccess)
            {
                return StatusCode(500, Result);
            }
            return Ok(Result);
        }

        [HttpPost(ApiRoutes.Auth.ResetUserPassWord)]
        public async Task<IActionResult> ResetUserPassWord(string UserId)
        {
            var Result = await _authService.ResetUserPassWord(UserId);
            if (!Result.IsSuccess)
            {
                return StatusCode(500, Result);
            }
            return Ok(Result);
        }
        
        [HttpPost(ApiRoutes.Auth.ActivateUserOrNot)]
        public IActionResult ActivateOrNot(string UserId)
        {
            var Result =  _authService.ActivateorDeactivateUser(UserId);
            if (!Result.IsSuccess)
            {
                return StatusCode(500, Result);
            }
            return Ok(Result);
        }
        [HttpGet(ApiRoutes.Auth.GetAllUserTypes)]
        public IActionResult GetAllUserTypes()=> Ok(_staticDataService.GetAllUserTypes());
        //[Authorize]
        //[HttpPost("logout")]
        //public async Task<IActionResult> Logout()
        //{
        //    string rowUserId = HttpContext.User.FindFirstValue("uid");
        //    if (!Guid.TryParse(rowUserId, out Guid userId))
        //    {
        //        return Unauthorized();
        //    }
        //    await _authService.LogOutAsync(userId);
        //    return NoContent();
        //}
        //[HttpPost("addRoleToUser")]
        //public async Task<IActionResult> AddRoleToUserAsync([FromBody] AddRolesToUserRequest model)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);

        //    var result = await _authService.AddRolesToUserAsync(model);

        //    if (!string.IsNullOrEmpty(result))
        //        return BadRequest(result);

        //    return Ok(model);
        //}

        //[Authorize]
        //[HttpGet("GetBranchesAsynk")]
        //public async Task<IActionResult> GetBranchesAsynk()
        //{
        //    var result = await _authService.GetBranchesAsynk();

        //    return Ok(result);
        //}


        
    }
}
