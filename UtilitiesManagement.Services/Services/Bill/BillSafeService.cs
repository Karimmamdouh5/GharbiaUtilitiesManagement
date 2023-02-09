using UtilitiesManagement.Services.IServices.Bill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManagement.DataAccess.Repositories.Align;
using UtilitiesManagement.DataAccess.Repositories;
using UtilitiesManagement.Domain.Dtos.Request.Operation;
using static UtilitiesManagement.Domain.Contracts.V1.ApiRoutes;

namespace UtilitiesManagement.Services.Services.Bill
{
    public class BillSafeService : IBillSafeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;
        private readonly ILoggingRepository _customLog;
        private readonly IMapper _mapper;

        public BillSafeService(IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharLocalizer, ILoggingRepository loggingRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _sharLocalizer = sharLocalizer;
            _customLog = loggingRepository;
            _mapper = mapper;
        }

        public async Task<Response<AddListRequest>> AddBillSafeAync(AddListRequest BillSafeAddListRequest)
        {
            bool exists = false;

            exists = await _unitOfWork.BillSafes.ExistAsync(x => x.Name.Trim().ToUpper() == BillSafeAddListRequest.Name.ToUpper());

            if (exists)
            {
                string resultMsg = string.Format(_sharLocalizer[SDLocalization.IsExist],
                    _sharLocalizer[SDLocalization.ComplaintType]);

                return new Response<AddListRequest>()
                {
                    IsExists = true,
                    Errors = new string[] { resultMsg },
                    Message = resultMsg
                };
            }
            string err = _sharLocalizer[SDLocalization.Error];
            try
            {
                var objResult = await _unitOfWork.BillSafes.AddAsync(_mapper.Map<BillSafe>(BillSafeAddListRequest));
                bool result = await _unitOfWork.CompleteAsync() > 0;

                return new Response<AddListRequest>()
                {
                    IsSuccess = result,
                    IdOfAddedObject = objResult.Id,
                    Data = BillSafeAddListRequest,
                    Errors = new string[] { },
                    Message = result ? _sharLocalizer[SDLocalization.Done] : err
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(BillSafeAddListRequest), LogType.Bug);
                return new Response<AddListRequest>()
                {
                    Errors = new string[] { err },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }

        }

        public async Task<Response<string>> DeleteBillSafeAsync(int BillSafeId)
        {
            var BillSafe = await _unitOfWork.BillSafes.GetFirstOrDefaultAsync(a => a.Id == BillSafeId && !a.IsDeleted);
            string resultMsg = string.Format(_sharLocalizer[SDLocalization.CannotBeFound],
                _sharLocalizer[SDLocalization.ComplaintType], BillSafeId);

            if (BillSafe == null)
                return new Response<string>()
                {
                    IsNotFound = true,
                    Data = null!,
                    Errors = new string[] { resultMsg },
                    Message = resultMsg
                };
            string err = _sharLocalizer[SDLocalization.Error];
            try
            {
                await _unitOfWork.BillSafes.Remove(BillSafe);
                bool result = await _unitOfWork.CompleteAsync() > 0;

                if (!result)
                    return new Response<string>()
                    {
                        IsSuccess = false,
                        Data = null!,
                        Errors = new string[] { err },
                        Message = err
                    };
                return new Response<string>()
                {
                    IsSuccess = true,
                    Data = null!,
                    Errors = new string[] { },
                    Message = _sharLocalizer[SDLocalization.Deleted]
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, @$"{LoggingMessages.ErrorWhileDeleting}
                        {LoggingMessages.ComplaintType}{LoggingMessages.Id}{LoggingMessages.Obj}
                        {JsonConvert.SerializeObject(BillSafe)}");
                return new Response<string>()
                {
                    Errors = new string[] { err },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }

        }

        public async Task<Response<IEnumerable<SelectListResponse>>> GetAllBillSafesAsync()
        {
            try
            {
                var result = _mapper.Map<List<SelectListResponse>>(await _unitOfWork.BillSafes.GetAllAsync());

                if (result == null || result.ToList().Count == 0)
                {
                    string resultMsg = _sharLocalizer[SDLocalization.NotFoundData];

                    return new Response<IEnumerable<SelectListResponse>>()
                    {
                        IsNotFound = true,
                        IsSuccess=true,
                        Errors = new string[] { resultMsg },
                        Message = resultMsg,
                        Data = new List<SelectListResponse>()
                    };
                }

                return new Response<IEnumerable<SelectListResponse>>()
                {
                    IsSuccess = true,
                    Data = result.ToList()
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, "");
                return new Response<IEnumerable<SelectListResponse>>()
                {
                    Errors = new string[] { _sharLocalizer[SDLocalization.Error] },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }

        }

        public async Task<Response<AddListRequest>> UpdateBillSafeAsync(int BillSafeId, AddListRequest UpdateBillSafeRequest)
        {
            bool exists = false;
            string err = _sharLocalizer[SDLocalization.Error];
            string localizedComplaintType = _sharLocalizer[SDLocalization.ComplaintType];

            var BillSafe = await _unitOfWork.BillSafes.GetFirstOrDefaultAsync(a => a.Id == BillSafeId );

            if (BillSafe == null || UpdateBillSafeRequest.Id != BillSafeId)
            {
                string resultMsg = string.Format(_sharLocalizer[SDLocalization.CannotBeFound], localizedComplaintType, BillSafeId);

                return new Response<AddListRequest>()
                {
                    IsNotFound = true,
                    Data = UpdateBillSafeRequest,
                    Errors = new string[] { resultMsg },
                    Message = resultMsg
                };
            }
            exists = await _unitOfWork.ComplaintTypes
                .ExistAsync(x => x.Name.Trim().ToUpper() == UpdateBillSafeRequest.Name.Trim().ToUpper() && x.Id != BillSafeId);
            if (!exists)
            {
                try
                {
                    var obj = _mapper.Map(UpdateBillSafeRequest, BillSafe);
                    var objResult = _unitOfWork.BillSafes.Update(obj);
                    bool result = await _unitOfWork.CompleteAsync() > 0;

                    return new Response<AddListRequest>()
                    {
                        IsSuccess = result,
                        IsUpdated = true,
                        IdOfAddedObject = objResult.Id,
                        Data = UpdateBillSafeRequest,
                        Errors = new string[] { },
                        Message = result ? _sharLocalizer[SDLocalization.Updated] : err
                    };

                }
                catch (Exception ex)
                {
                    await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(UpdateBillSafeRequest));
                    return new Response<AddListRequest>()
                    {
                        Errors = new string[] { err },
                        Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                    };
                }

            }
            string msg = string.Format(_sharLocalizer[SDLocalization.IsExist], localizedComplaintType);
            return new Response<AddListRequest>()
            {
                IsExists = true,
                Errors = new string[] { msg },
                Message = msg
            };


        }
    }
}
