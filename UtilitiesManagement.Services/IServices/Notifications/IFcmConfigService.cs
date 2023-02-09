using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManagement.Domain.Dtos.Request.Notification;

namespace UtilitiesManagement.Services.IServices.Notifications
{
    public interface IFcmConfigService
    {
        Task<Response<IEnumerable<UpdateFcmConfigRequest>>> GetAllFcmConfigAsync();
        Task<Response<UpdateFcmConfigRequest>> AddFcmConfigAsync(AddFcmConfigRequest addFcmConfigRequest);
        Task<Response<UpdateFcmConfigRequest>> UpdateFcmConfigAsync(int FcmConfigId, UpdateFcmConfigRequest updateFcmConfigRequest);
        Task<Response<string>> DeleteFcmConfigAsync(int FcmConfigId);
    }
}
