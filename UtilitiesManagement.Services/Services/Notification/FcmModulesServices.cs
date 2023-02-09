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
    public class FcmModulesServices : INotiModulesServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _accessor;
        private readonly ILoggingRepository _customLog;
        public FcmModulesServices(IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharLocalizer,
                               ILoggingRepository loggingRepository, IMapper mapper,
                               IHttpContextAccessor accessor)
        {
            _unitOfWork = unitOfWork;
            _sharLocalizer = sharLocalizer;
            _mapper = mapper;
            _accessor = accessor;
            _customLog = loggingRepository;
        }

        public async Task<Response<UpdateNotiModuleRequest>> AddNotiModulesAsync(AddNotiModuleRequest addFcmModuleRequest)
        {
            using (var transaction = _unitOfWork.BeginTransaction())
            {
                try
                {
                    var data = _mapper.Map<NotiModules>(addFcmModuleRequest);
                    data = await _unitOfWork.NotiModules.AddAsync(data);
                    await _unitOfWork.CompleteAsync();

                    var users = (await _unitOfWork.Users.GetAllAsync(filter: x => addFcmModuleRequest.UsersIds.Contains(x.Id) && !x.IsDeleted, ignoreQueryFilters: true)).ToList();
                    await _unitOfWork.NotiUserModules.AddRangeAsync(users.Select(x => new NotiUserModule() { User_Id = x.Id, Module_Id = data.Id }).ToList());
                    await _unitOfWork.CompleteAsync();

                    transaction.Commit();

                    return new Response<UpdateNotiModuleRequest>()
                    {
                        Data = _mapper.Map<UpdateNotiModuleRequest>(data),
                        IsSuccess = true,
                        Message = _sharLocalizer[SDLocalization.Done]
                    };


                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return new Response<UpdateNotiModuleRequest>() { Message = _sharLocalizer[SDLocalization.Error], IsSuccess = false, Errors = new[] { ex.Message } };
                }
            }
        }

        public async Task<Response<string>> DeleteNotiModulesAsync(int FcmModuleId)
        {
            using (var transaction = _unitOfWork.BeginTransaction())
            {
                try
                {
                    var data = await _unitOfWork.NotiModules.GetFirstOrDefaultAsync(filter: x => x.Id == FcmModuleId, ignoreQueryFilters: true);
                    if (data == null)
                        return new Response<string>() { Message = _sharLocalizer[SDLocalization.CannotBeFound, FcmModuleId], IsSuccess = false };
                    var UserModules = (await _unitOfWork.NotiUserModules.GetAllAsync(filter: x => x.Module_Id == data.Id && !x.IsDeleted, ignoreQueryFilters: true)).ToList();
                    _unitOfWork.NotiUserModules.RemoveRange(UserModules);
                    await _unitOfWork.CompleteAsync();

                    await _unitOfWork.NotiModules.Remove(data);
                    await _unitOfWork.CompleteAsync();

                    transaction.Commit();

                    return new Response<string>() { Message = _sharLocalizer[SDLocalization.Deleted], IsSuccess = true };
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return new Response<string>() { Message = _sharLocalizer[SDLocalization.Error], IsSuccess = false, Errors = new[] { ex.Message } };
                }
            }
        }

        public async Task<Response<IEnumerable<NotiUserModuleResponse>>> GetAllNotiModulesAsync()
        {
                try
            {
                var data = await _unitOfWork.NotiModules.GetSpecificSelectAsync(filter: x => !x.IsDeleted, ignoreQueryFilters: true,
                    select: x => new NotiUserModuleResponse()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Users = x.UserModule.Where(x => !x.IsDeleted).Select(y => new SelectListWithStringIdStringResponse() { Id = y.User_Id, Name = y.User.UserName }).ToList()
                    });
                return new Response<IEnumerable<NotiUserModuleResponse>>()
                {
                    Data = data,
                    IsSuccess = true,
                    Message = _sharLocalizer[SDLocalization.Data]
                };
            }
            catch (Exception ex)
            {
                return new Response<IEnumerable<NotiUserModuleResponse>>() { Message = _sharLocalizer[SDLocalization.Error], IsSuccess = false, Errors = new[] { ex.Message } };
            }
        }

        public async Task<Response<NotiUserModuleResponse>> GetNotiModuleProfile(int FcmModuleId)
        {
            try
            {
                var data = (await _unitOfWork.NotiModules.GetSpecificSelectAsync(filter: x => x.Id == FcmModuleId && !x.IsDeleted, select: x => new NotiUserModuleResponse()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Users = x.UserModule.Where(x => !x.IsDeleted).Select(y => new SelectListWithStringIdStringResponse() { Id = y.User_Id, Name = y.User.UserName }).ToList()
                })).FirstOrDefault();
                return new Response<NotiUserModuleResponse>() { Data = data, Message = _sharLocalizer[SDLocalization.Data], IsSuccess = true };
            }
            catch (Exception ex)
            {
                return new Response<NotiUserModuleResponse>() { Message = _sharLocalizer[SDLocalization.Error], IsSuccess = false, Errors = new[] { ex.Message } };
            }
        }

        public async Task<Response<UpdateNotiModuleRequest>> UpdateNotiModulesAsync(int FcmModuleId, UpdateNotiModuleRequest updateFcmConfigRequest)
        {
            using (var transaction = _unitOfWork.BeginTransaction())
            {
                try
                {
                    if (FcmModuleId != updateFcmConfigRequest.Id)
                        return new Response<UpdateNotiModuleRequest>() { Message = _sharLocalizer[SDLocalization.CannotBeFound, FcmModuleId], IsSuccess = false };
                    var data = await _unitOfWork.NotiModules.GetFirstOrDefaultAsync(filter: x => x.Id == FcmModuleId && !x.IsDeleted, ignoreQueryFilters: true);
                    if (data == null)
                        return new Response<UpdateNotiModuleRequest>() { Message = _sharLocalizer[SDLocalization.CannotBeFound, FcmModuleId], IsSuccess = false };


                    data = _mapper.Map<UpdateNotiModuleRequest, NotiModules>(updateFcmConfigRequest, data);
                    _unitOfWork.NotiModules.Update(data);
                    await _unitOfWork.CompleteAsync();

                    var UserModules = (await _unitOfWork.NotiUserModules.GetAllAsync(filter: x => x.Module_Id == FcmModuleId && !x.IsDeleted, ignoreQueryFilters: true )).ToList();

                    var AddingUsers = updateFcmConfigRequest!.UsersIds!.Except(UserModules.Select(x => x.User_Id).ToList()).ToList();
                    var DeletingUsers = UserModules.Select(x => x.User_Id).ToList().Except(updateFcmConfigRequest.UsersIds);

                    await _unitOfWork.NotiUserModules.AddRangeAsync(AddingUsers.Select(x => new NotiUserModule() { Module_Id = data.Id, User_Id = x }));
                    _unitOfWork.NotiUserModules.RemoveRange(UserModules.Where(x => x.Module_Id == FcmModuleId && DeletingUsers.Contains(x.User_Id)));
                    await _unitOfWork.CompleteAsync();

                    transaction.Commit();

                    return new Response<UpdateNotiModuleRequest>() { Data = _mapper.Map<UpdateNotiModuleRequest>(data), Message = _sharLocalizer[SDLocalization.Updated], IsSuccess = true };
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return new Response<UpdateNotiModuleRequest>() { Message = _sharLocalizer[SDLocalization.Error], IsSuccess = false, Errors = new[] { ex.Message } };
                }
            }
        }
    }
}
