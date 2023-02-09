using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManagement.Domain.Dtos.Request.Notification;
using UtilitiesManagement.Domain.Dtos.Response.Notification;

namespace UtilitiesManagement.Services.IServices.Notifications
{
    public interface INotiModulesServices
    {
        Task<Response<IEnumerable<NotiUserModuleResponse>>> GetAllNotiModulesAsync();
        Task<Response<UpdateNotiModuleRequest>> AddNotiModulesAsync(AddNotiModuleRequest addFcmModuleRequest);
        Task<Response<UpdateNotiModuleRequest>> UpdateNotiModulesAsync(int FcmModuleId, UpdateNotiModuleRequest updateFcmConfigRequest);
        Task<Response<string>> DeleteNotiModulesAsync(int FcmModuleId);
        Task<Response<NotiUserModuleResponse>> GetNotiModuleProfile(int FcmModuleId);
    }
}
