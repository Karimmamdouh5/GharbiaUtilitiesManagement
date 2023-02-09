using System.ComponentModel.DataAnnotations;
using UtilitiesManagement.Domain.Dtos.Request.Notification;
using UtilitiesManagement.Services.IServices.Notifications;

namespace UtilitiesManagement.Api.Areas.Notification
{
    [Area(Modules.Notification)]
    [ApiController]
    [ApiExplorerSettings(GroupName = Modules.Notification)]
    public class NotiMessagesController:ControllerBase
    {
        private readonly INotiMessagesService _fcmMessagesService;

        public NotiMessagesController(INotiMessagesService fcmMessagesService)
        {
            _fcmMessagesService = fcmMessagesService;
        }
        [HttpGet(ApiRoutes.Notification.GetModuleMessages)]
        public async Task<IActionResult> GetModuleMessages([Required]int id) =>
           Ok(await _fcmMessagesService.GetModuleMessages(id));

        [HttpGet(ApiRoutes.Notification.GetUsersMessages)]
        public async Task<IActionResult> GetUsersMessages([Required]string id) =>
           Ok(await _fcmMessagesService.GetUserMessages(id));

        [HttpPost(ApiRoutes.Notification.SendMessage)]
        public async Task<IActionResult> SendMessage(AddNotiMessageRequest model)
        {
            var result = await _fcmMessagesService.SendMessage(model);
            if(result.IsSuccess)
                return Ok(result);
            return StatusCode(StatusCodes.Status500InternalServerError, result);
        }
    }
}
