using UtilitiesManagement.Domain.Dtos.Request.Notification;
using UtilitiesManagement.Services.IServices.Notifications;

namespace UtilitiesManagement.Api.Areas.Notification
{
    [Area(Modules.Notification)]
    [ApiController]
    [ApiExplorerSettings(GroupName = Modules.Notification)]
    public class NotiModulesController:ControllerBase
    {
        private readonly INotiModulesServices _fcmModulesServices;

        public NotiModulesController(INotiModulesServices fcmModulesServices)
        {
            _fcmModulesServices = fcmModulesServices;
        }
        [HttpGet(ApiRoutes.Notification.GetNotiModuleProfile)]
        public async Task<IActionResult> GetNotiModuleProfile(int Id) =>
           Ok(await _fcmModulesServices.GetNotiModuleProfile(Id));
        [HttpGet(ApiRoutes.Notification.GetAllNotiMoudles)]
        public async Task<IActionResult> GetAllNotiMoudles() =>
           Ok(await _fcmModulesServices.GetAllNotiModulesAsync());

        [HttpPost(ApiRoutes.Notification.AddNotiMoudle)]
        public async Task<IActionResult> AddNotiMoudle(AddNotiModuleRequest model)
        {
            var response = await _fcmModulesServices.AddNotiModulesAsync(model);
            if (response.IsSuccess)
                return Ok(response);
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError, response);
        }

        [HttpPut(ApiRoutes.Notification.UpdateNotiMoudle)]
        public async Task<IActionResult> UpdateNotiMoudle(int Id, UpdateNotiModuleRequest model)
        {
            var response = await _fcmModulesServices.UpdateNotiModulesAsync(Id, model);
            if (response.IsSuccess)
                return Ok(response);
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError, response);
        }

        [HttpDelete(ApiRoutes.Notification.DeleteNotiMoudle)]
        public async Task<IActionResult> DeleteNotiMoudle(int Id)
        {
            var response = await _fcmModulesServices.DeleteNotiModulesAsync(Id);
            if (response.IsSuccess)
                return Ok(response);
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError, response);
        }
    }
}
