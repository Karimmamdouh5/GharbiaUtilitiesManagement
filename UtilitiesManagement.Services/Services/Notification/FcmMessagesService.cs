using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManagement.Domain.Dtos.Request.Notification;
using UtilitiesManagement.Domain.Dtos.Response.Notification;
using UtilitiesManagement.Domain.Models.Notification;
using UtilitiesManagement.Services.IServices.Notifications;

namespace UtilitiesManagement.Services.Services.Notification
{
    public class FcmMessagesService : INotiMessagesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _accessor;
        private readonly ILoggingRepository _customLog;
        public FcmMessagesService(IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharLocalizer,
                               ILoggingRepository loggingRepository, IMapper mapper,
                               IHttpContextAccessor accessor)
        {
            _unitOfWork = unitOfWork;
            _sharLocalizer = sharLocalizer;
            _mapper = mapper;
            _accessor = accessor;
            _customLog = loggingRepository;
        }
        public async Task<Response<List<NotiMessageResponseWithNames>>> GetModuleMessages(int moduleId)
        {
            try
            {
                var module = await _unitOfWork.NotiModules.GetFirstOrDefaultAsync(filter: x => x.Id == moduleId && !x.IsDeleted, includeProperties: "UserModule,UserModule.User");
                if (module == null)
                    return new Response<List<NotiMessageResponseWithNames>>() { Message = _sharLocalizer[SDLocalization.CannotBeFound, moduleId], Data = new List<NotiMessageResponseWithNames>(), IsSuccess = true };
                var ModuleMessages = (await _unitOfWork.MessageUser.GetSpecificSelectAsync(filter: x => module!.UserModule!.Select(y => y.User_Id).ToList().Contains(x.User_Id), select: x => new NotiMessageResponseWithNames()
                {
                    UserSender_Id = x.Message.UserSender_Id,
                    Message = x.Message.Message,
                    ReadOnly = x.Message.ReadOnly,
                    Title = x.Message.Title,
                    UserId = x.User_Id,
                    From = x.Message.User.UserName,
                    To = x.User.UserName
                })).ToList();
                return new Response<List<NotiMessageResponseWithNames>>() { Data = ModuleMessages, IsSuccess = true, Message = _sharLocalizer[SDLocalization.Data] };
            }
            catch (Exception ex)
            {
                return new Response<List<NotiMessageResponseWithNames>>() { Message = _sharLocalizer[SDLocalization.Error], IsSuccess = false, Errors = new[] { ex.Message } };
            }
        }

        public async Task<Response<List<NotiMessageResponseWithNames>>> GetUserMessages(string userId)
        {
            try
            {
                var UserMessages = (await _unitOfWork.MessageUser.GetSpecificSelectAsync(filter: x => x.User_Id == userId && !x.IsDeleted, ignoreQueryFilters: true, select: x => new NotiMessageResponseWithNames() { Message = x.Message.Message, ReadOnly = x.Message.ReadOnly, Title = x.Message.Title, UserSender_Id = x.Message.UserSender_Id, UserId = x.User_Id,From = x.Message.User.UserName , To = x.User.UserName })).ToList();
                return new Response<List<NotiMessageResponseWithNames>>() { Data = UserMessages, IsSuccess = true, Message = _sharLocalizer[SDLocalization.Data] };
            }
            catch (Exception ex)
            {
                return new Response<List<NotiMessageResponseWithNames>>() { Message = _sharLocalizer[SDLocalization.Error], IsSuccess = false, Errors = new[] { ex.Message } };
            }
        }

        public async Task<Response<string>> SendMessage(AddNotiMessageRequest model)
        {
            try
            {
                var Sender = await _unitOfWork.Users.GetFirstOrDefaultAsync(filter: x => x.Id == model.UserSender_Id && !x.IsDeleted, ignoreQueryFilters: true);
                var GetSendingConfig = await _unitOfWork.NotiFcmConfig.GetFirstOrDefaultAsync(filter: x => x.IsAndroid == Sender.IsAndroid && !x.IsDeleted, ignoreQueryFilters: true);
                var UsersTokens = new List<string>();
                var userIds = new List<string>();

                var counter = 0;

                if (model.Module_Id != null)
                {
                    var module = await _unitOfWork.NotiModules.GetFirstOrDefaultAsync(filter: x => x.Id == model.Module_Id && !x.IsDeleted, ignoreQueryFilters: true, includeProperties: "UserModule,UserModule.User");
                    if (module == null) return new Response<string>() { Message = _sharLocalizer[SDLocalization.CannotBeFound, model.Module_Id], IsSuccess = false };
                    UsersTokens = module.UserModule.Where(x => x.User.UserToken != null).Select(x => x.User.UserToken).ToList();
                    userIds = module.UserModule.Where(x => x.User.UserToken != null).Select(x => x.User_Id).ToList();
                }
                else if (model.UserIds != null)
                {
                    UsersTokens = (await _unitOfWork.Users.GetSpecificSelectAsync(filter: x => model.UserIds.Contains(x.Id) && !x.IsDeleted && x.UserToken != null, ignoreQueryFilters: true, select: x => x.UserToken)).ToList();
                    userIds = model.UserIds;
                }

                else
                {
                    return new Response<string>() { Message = _sharLocalizer[SDLocalization.CannotSendDatatoNoOne], IsSuccess = false };
                }

                var isSuccess = await SendFcmMessageRequestAsync(UsersTokens.ToArray(), model.Title, model.Message, GetSendingConfig.ServerKey);
                if (!isSuccess)
                {
                    return new Response<string>() { Message = _sharLocalizer[SDLocalization.Error], IsSuccess = false };
                }
                var AddingMessage = _mapper.Map<NotiMessage>(model);
                var AddingMessageUsers = userIds.Select(x => new NotiMessageUser() { Message = AddingMessage, User_Id = x }).ToList();
                await _unitOfWork.MessageUser.AddRangeAsync(AddingMessageUsers);
                await _unitOfWork.CompleteAsync();

                return new Response<string>() { Message = _sharLocalizer[SDLocalization.Done], IsSuccess = true };
            }
            catch (Exception ex)
            {
                return new Response<string>() { IsSuccess = false, Errors = new[] { ex.Message } };
            }
        }
        private async Task<bool> SendFcmMessageRequestAsync(string[] usersTokens , string title , string body , string ServerKey)
        {
            try
            {
                    var FcmReqBody = new MessageFcm() { registration_ids = usersTokens, notification = new notificationFcm() { body = body, title = title } };
                    var client = new RestClient("https://fcm.googleapis.com/fcm/send");
                    var request = new RestRequest();
                    request.AddHeader("Content-Type", "application/json");
                    request.AddHeader("Authorization", $"key={ServerKey}");
                    request.AddJsonBody(JsonConvert.SerializeObject(FcmReqBody));
                    var Res = await client.PostAsync(request);
                
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
