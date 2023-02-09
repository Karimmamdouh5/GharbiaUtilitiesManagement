namespace UtilitiesManagement.Api.Areas.Auth.Controllers
{
    [Area(Modules.Auth)]
    [ApiController]
    [ApiExplorerSettings(GroupName = Modules.Auth)]
    public class PermissionsController : ControllerBase
    {
        private readonly IPermissionsService _PermissionsService;
        private readonly IPermMenuService _permMenuService;

        public PermissionsController(IPermissionsService perService , IPermMenuService permMenuService)
        {
            _permMenuService = permMenuService;
            _PermissionsService = perService;
        }

        [AllowAnonymous]
        [HttpPost(ApiRoutes.Permissions.addallpermissionToSuperAdmin)]
        //[Authorize(Permissions.AlignPermission.Create)]
        public async Task<IActionResult> AddAllPermissionToSuperAdmin()
        {
            var Result = await _PermissionsService.AddAllClaimsToRoleAsync();
            if (!Result.IsSuccess)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, Result);
            }
            return Ok(Result);
        }
        [Authorize(Permissions.Permission.View)]
        [HttpGet(ApiRoutes.Permissions.GetPermissionByRoleAsync)]
        public async Task<IActionResult> GetPermissionByRoleAsync(string roleId)        
        {
            var authResponse = await _PermissionsService.GetClaimsByRoleAsync(roleId);
            if (!authResponse.IsSuccess)
                return StatusCode(StatusCodes.Status500InternalServerError, authResponse);
            return Ok(authResponse);
        }
        [Authorize(Permissions.Permission.Manage)]
        [HttpPost(ApiRoutes.Permissions.ManageClaimsForRole)]
        public async Task<IActionResult> ManageClaimsForRole(PermissionsTreeByRoleResponse model)
        {
            var authResponse = await _PermissionsService.ManageClaimsByRoleAsync(model);
            if (!authResponse.IsSuccess)
                return StatusCode(StatusCodes.Status500InternalServerError, authResponse);
            return Ok(authResponse);
        } // Completed
        [HttpGet(ApiRoutes.Permissions.GetRulesForCompany)]
        [Authorize(Permissions.Permission.View)]
        public async Task<IActionResult> GetRulesForAdmin(int CompanyId)    // Completed
        { 
            var Data = await _PermissionsService.ListRulesForCompany(CompanyId);
            if (Data is null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, Data);
            }
            return Ok(Data);
        }
        [Authorize(Permissions.Permission.View)]
        [HttpGet(ApiRoutes.Permissions.GetRolesDetailsForCompany)]
        public async Task<IActionResult> GetRolesDetailsForCompany(int CompanyId)    // Completed
        {
            var Data = await _PermissionsService.GetRolesDetailsForCompany(CompanyId);
            if (Data is null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, Data);
            }
            return Ok(Data);
        }
        [Authorize(Permissions.Permission.Create)]
        [HttpPost((ApiRoutes.Permissions.AddRuleToCompany))]
        public async Task<IActionResult> AddRuleToAdmin(CompanyRoleDTO model)
        {
            var Result =  await _PermissionsService.AddRulesToCompany(model);
            if (Result.IsSuccess)
            {
                return Ok(Result);
            }
            return StatusCode(StatusCodes.Status500InternalServerError, Result);
        }
        [Authorize(Permissions.Permission.Manage)]
        [HttpPut((ApiRoutes.Permissions.EditRuleToCompany))]
        public async Task<IActionResult> EditRuleToAdmin(CompanyRoleDTO_Edit model,string roleId)
        {
            var Result = await _PermissionsService.EditRulesToCompany(model,roleId);
            if (Result.IsSuccess)
            {
                return Ok(Result);
            }
            return StatusCode(StatusCodes.Status500InternalServerError, Result);
        }
        [Authorize(Permissions.Permission.Manage)]
        [HttpDelete((ApiRoutes.Permissions.DeleteRuleToCompany))]
        public async Task<IActionResult> DeleteRuleToAdmin(string roleId)
        {
            var Result = await _PermissionsService.DeleteRulesToCompany(roleId);
            if (Result.IsSuccess)
            {
                return Ok(Result);
            }
            return StatusCode(StatusCodes.Status500InternalServerError, Result);
        }
        [Authorize(Permissions.Permission.View)]
        [HttpGet(ApiRoutes.Permissions.GetDefaultPermissionsForCompany)]
        public async Task<IActionResult> GetDefaultClaimsForCompany(int companyId)
        {
            var authResponse = await _PermissionsService.GetDefaultClaimsByCompanyIdAsync(companyId);
            if (!authResponse.IsSuccess)
                return StatusCode(StatusCodes.Status500InternalServerError, authResponse);
            return Ok(authResponse);
        }
        [Authorize(Permissions.AlignPermission.View)]
        [HttpGet(ApiRoutes.Permissions.GetClaimsForCompany)]
        public async Task<IActionResult> GetClaimsForCompany(int companyId)
        {
            var authResponse = await _PermissionsService.GetClaimsForCompanyAdminAsync(companyId);
            if (!authResponse.IsSuccess)
                return StatusCode(StatusCodes.Status500InternalServerError, authResponse);
            return Ok(authResponse);
        }

        [Authorize(Permissions.AlignPermission.Manage)]
        [HttpPost(ApiRoutes.Permissions.ManageClaimsForCompany)]
        public async Task<IActionResult> ManageClaimsForAdmin(PermissionsTreeByCompanyResponse model)
        {
            var authResponse = await _PermissionsService.ManageClaimsForCompanyAdminAsync(model);
            if (!authResponse.IsSuccess)
                return StatusCode(StatusCodes.Status500InternalServerError, authResponse);
            return Ok(authResponse);
        }
        [Authorize(Permissions.Permission.View)]
        [HttpGet(ApiRoutes.Permissions.GetUserRolesAsync)]
        public async Task<IActionResult> GetUserRolesAsync(string UserId)
        {
            var result = await _PermissionsService.GetUserRolesAsync(UserId);

            if (!result.IsSuccess)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, result);
            }

            return Ok(result);
        }
        [Authorize(Permissions.Permission.Manage)]
        [HttpPost(ApiRoutes.Permissions.ManageUserRolesAsync)]
        public async Task<IActionResult> ManageUserRolesAsync([FromBody] RolesByUserIdResponse model)
        {
         
            var result = await _PermissionsService.ManageUserRolesAsync(model);

            if (!result.IsSuccess)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, result);
            }

            return Ok(result);
        }
        [Authorize(Permissions.Permission.Create)]
        [HttpPost(ApiRoutes.Permissions.AddPermissionMenuItem)]
        public async Task<IActionResult> AddPermissionMenuItem([FromBody ] AuthAddPermMenuRequest model)
        {
            var Result =await _permMenuService.AddPermMunu(model);
            if (!Result.IsSuccess)
            {
                return StatusCode(500, Result);
            }
            return Ok(Result);
        }
        [Authorize(Permissions.Permission.Manage)]
        [HttpPut(ApiRoutes.Permissions.UpdatePermissionMenuItem)]
        public async Task<IActionResult> UpdatePermissionMenuItem([FromBody]AuthUpdatePermMenuRequest model)
        {
            var Result = await _permMenuService.UpdatePermMunu(model);
            if (!Result.IsSuccess)
            {
                return StatusCode(500, Result);
            }
            return Ok(Result);
        }
        [Authorize(Permissions.Permission.Manage)]
        [HttpDelete(ApiRoutes.Permissions.RemovePermissionMenuItem)]
        public async Task<IActionResult> RemovePermissionMenuItem(int Id)
        {
            var Result = await _permMenuService.RemovePermMunu(Id);
            if (!Result.IsSuccess)
            {
                return StatusCode(500, Result);
            }
            return Ok(Result);
        }
        [HttpGet(ApiRoutes.Permissions.GetMenu)]
        public async Task<IActionResult> GetMenu()
        {
            var Result = await _permMenuService.GetMenu();
            if (!Result.IsSuccess)
            {
                return StatusCode(500, Result);
            }
            return Ok(Result);
        }
        [HttpGet(ApiRoutes.Permissions.GetAdminMenu)]
        public async Task<IActionResult> GetAdminMenu()
        {
            var Result = await _permMenuService.GetAdminMenu();
            if (!Result.IsSuccess)
            {
                return StatusCode(500, Result);
            }
            return Ok(Result);
        }
        [HttpGet(ApiRoutes.Permissions.GetMenuPermissions)]
        public async Task<IActionResult> GetMenuPermissions()
        {
            var Result = await _permMenuService.GetMenuPermissions();
            if (!Result.IsSuccess)
            {
                return StatusCode(500, Result);
            }
            return Ok(Result);
        }
        [HttpPut(ApiRoutes.Permissions.ChangeNodeActivation)]
        public async Task<IActionResult> ChangeNodeActivation(int[] NodesIds)
        {
            var Result = await _permMenuService.ChangeActivation(NodesIds);
            if (!Result.IsSuccess)
            {
                return StatusCode(500, Result);
            }
            return Ok(Result);
        }
    }
}
