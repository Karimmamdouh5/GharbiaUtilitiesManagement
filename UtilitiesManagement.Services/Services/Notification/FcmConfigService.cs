using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManagement.Domain.Dtos.Request.Notification;
using UtilitiesManagement.Domain.Models.Notification;
using UtilitiesManagement.Services.IServices.Notifications;

namespace UtilitiesManagement.Services.Services.Notification
{
    public class FcmConfigService : IFcmConfigService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _accessor;
        private readonly ILoggingRepository _customLog;
        public FcmConfigService(IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharLocalizer,
                               ILoggingRepository loggingRepository, IMapper mapper,
                               IHttpContextAccessor accessor)
        {
            _unitOfWork = unitOfWork;
            _sharLocalizer = sharLocalizer;
            _mapper = mapper;
            _accessor = accessor;
            _customLog = loggingRepository;
        }
        public async Task<Response<UpdateFcmConfigRequest>> AddFcmConfigAsync(AddFcmConfigRequest addFcmConfigRequest)
        {
            try
            {
                var data = _mapper.Map<NotiFcmConfig>(addFcmConfigRequest);
                data = await _unitOfWork.NotiFcmConfig.AddAsync(data);
                await _unitOfWork.CompleteAsync();
                return new Response<UpdateFcmConfigRequest>() { Data = _mapper.Map<UpdateFcmConfigRequest>(data), Message = _sharLocalizer[SDLocalization.Done], IsSuccess = true };
            }
            catch (Exception ex)
            {
                return new Response<UpdateFcmConfigRequest>() { Message = _sharLocalizer[SDLocalization.Error], Errors = new[] { ex.Message }, IsSuccess = false };
            }
        }

        public async Task<Response<string>> DeleteFcmConfigAsync(int FcmConfigId)
        {
            try
            {
                var data = await _unitOfWork.NotiFcmConfig.GetFirstOrDefaultAsync(filter: x => x.Id == FcmConfigId && !x.IsDeleted, ignoreQueryFilters: true);
                if (data == null)
                    return new Response<string>() { Message = _sharLocalizer[SDLocalization.CannotBeFound, FcmConfigId], IsSuccess = false };
                await _unitOfWork.NotiFcmConfig.Remove(data);
                await _unitOfWork.CompleteAsync();
                return new Response<string>() { Message = _sharLocalizer[SDLocalization.Deleted], IsSuccess = true };
            }
            catch (Exception ex)
            {
                return new Response<string>() { Message = _sharLocalizer[SDLocalization.Error], Errors = new[] { ex.Message }, IsSuccess = false };
            }
        }

        public async Task<Response<IEnumerable<UpdateFcmConfigRequest>>> GetAllFcmConfigAsync()
        {
            try
            {
                var data = _mapper.Map<List<UpdateFcmConfigRequest>>((await _unitOfWork.NotiFcmConfig.GetAllAsync(filter: x => !x.IsDeleted, ignoreQueryFilters: true)).ToList());
                return new Response<IEnumerable<UpdateFcmConfigRequest>>() { Data = data, IsSuccess = true, Message = _sharLocalizer[SDLocalization.Data] };
            }
            catch (Exception ex)
            {
                return new Response<IEnumerable<UpdateFcmConfigRequest>>() { Message = _sharLocalizer[SDLocalization.Error], Errors = new[] { ex.Message }, IsSuccess = false };
            }
        }

        public async Task<Response<UpdateFcmConfigRequest>> UpdateFcmConfigAsync(int FcmConfigId, UpdateFcmConfigRequest updateFcmConfigRequest)
        {
            try
            {
                if (FcmConfigId != updateFcmConfigRequest.Id)
                    return new Response<UpdateFcmConfigRequest>() { Message = _sharLocalizer[SDLocalization.CannotBeFound, FcmConfigId], IsSuccess = false };
                var searchedItem = await _unitOfWork.NotiFcmConfig.GetFirstOrDefaultAsync(filter: x => x.Id == FcmConfigId, ignoreQueryFilters: true);
                if (searchedItem == null)
                    return new Response<UpdateFcmConfigRequest>() { Message = _sharLocalizer[SDLocalization.CannotBeFound, FcmConfigId], IsSuccess = false };
                var data = _mapper.Map<UpdateFcmConfigRequest, NotiFcmConfig>(updateFcmConfigRequest, searchedItem);
                data = _unitOfWork.NotiFcmConfig.Update(data);
                await _unitOfWork.CompleteAsync();
                return new Response<UpdateFcmConfigRequest>() { IsSuccess = true, Message = _sharLocalizer[SDLocalization.Updated], Data = _mapper.Map<UpdateFcmConfigRequest>(data) };
            }
            catch (Exception ex)
            {
                return new Response<UpdateFcmConfigRequest>() { Message = _sharLocalizer[SDLocalization.Error], Errors = new[] { ex.Message }, IsSuccess = false };
            }
        }
    }
}
