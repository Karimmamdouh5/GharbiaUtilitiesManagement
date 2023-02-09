using UtilitiesManagement.Domain.Dtos.Request.Notification;
using UtilitiesManagement.Domain.Models.Notification;

namespace UtilitiesManagement.Api.Profiles
{
    public class NotificationProfiler: Profile
    {
        public NotificationProfiler()
        {
            #region FcmConfig
            CreateMap<NotiFcmConfig, AddFcmConfigRequest>()
                .ReverseMap();
            CreateMap<NotiFcmConfig, UpdateFcmConfigRequest>()
                .ReverseMap();
            #endregion
            #region FcmModule
            CreateMap<NotiModules, AddNotiModuleRequest>()
                 .ForMember(x => x.UsersIds, o => o.Ignore())
                    .ReverseMap();
            CreateMap<NotiModules, UpdateNotiModuleRequest>()
                 .ForMember(x => x.UsersIds, o => o.Ignore())
                .ReverseMap();
            #endregion
            #region Message

            CreateMap<AddNotiMessageRequest, NotiMessage>()
                .ForMember(x => x.MessageUsers, o => o.Ignore())
                .ForMember(x => x.User, o => o.Ignore());
            #endregion
        }
    }
}
