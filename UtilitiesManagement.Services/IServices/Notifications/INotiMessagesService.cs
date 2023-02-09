using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManagement.Domain.Dtos.Request.Notification;
using UtilitiesManagement.Domain.Dtos.Response.Notification;

namespace UtilitiesManagement.Services.IServices.Notifications
{
    public interface INotiMessagesService
    {
        Task<Response<string>> SendMessage(AddNotiMessageRequest model);
        Task<Response<List<NotiMessageResponseWithNames>>> GetUserMessages(string userId);
        Task<Response<List<NotiMessageResponseWithNames>>> GetModuleMessages(int moduleId);
    }
}
