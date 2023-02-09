using UtilitiesManagement.Domain.Dtos.Request.Notification;
using UtilitiesManagement.Services.IServices.Notifications;

namespace UtilitiesManagement.Api.Areas.Notification
{
    [Area(Modules.Notification)]
    [ApiController]
    [ApiExplorerSettings(GroupName = Modules.Notification)]
    public class FcmConfigController:ControllerBase
    {
        private readonly IFcmConfigService _fcmConfigService;

        public FcmConfigController(IFcmConfigService fcmConfigService)
        {
            _fcmConfigService = fcmConfigService;
        }
        [HttpGet(ApiRoutes.Notification.GetAllFcmConf)]
        public async Task<IActionResult> GetAllFcmConf() =>
           Ok(await _fcmConfigService.GetAllFcmConfigAsync());

        [HttpPost(ApiRoutes.Notification.AddFcmConf)]
        public async Task<IActionResult> AddFcmConf(AddFcmConfigRequest model)
        {
            var response = await _fcmConfigService.AddFcmConfigAsync(model);
            if (response.IsSuccess)
                return Ok(response);
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError, response);
        }

        [HttpPut(ApiRoutes.Notification.UpdateFcmConf)]
        public async Task<IActionResult> UpdateFcmConf(int Id, UpdateFcmConfigRequest model)
        {
            var response = await _fcmConfigService.UpdateFcmConfigAsync(Id, model);
            if (response.IsSuccess)
                return Ok(response);
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError, response);
        }

        [HttpDelete(ApiRoutes.Notification.DeleteFcmConf)]
        public async Task<IActionResult> DeleteFcmConf(int Id)
        {
            var response = await _fcmConfigService.DeleteFcmConfigAsync(Id);
            if (response.IsSuccess)
                return Ok(response);
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError, response);
        }
    }
}
