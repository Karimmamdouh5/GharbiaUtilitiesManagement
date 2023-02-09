namespace UtilitiesManagement.Services.Services.Operation
{
    public class ComplaintTypesService : IComplaintTypesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;
        private readonly ILoggingRepository _customLog;
        private readonly IMapper _mapper;

        public ComplaintTypesService(IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharLocalizer,
                                     ILoggingRepository loggingRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _sharLocalizer = sharLocalizer;
            _customLog = loggingRepository;
            _mapper = mapper;
        }

        #region Complaint Types

        public async Task<Response<IEnumerable<SelectListComplaintTypeResponse>>> GetAllComplaintTypesAsync()
        {
            try
            {
                var result = await _unitOfWork.ComplaintTypes.GetAllAsync(x => !x.IsDeleted);
                var mappedComplaintType = _mapper.Map<IEnumerable<SelectListComplaintTypeResponse>>(result);

                if (result == null || result.ToList().Count == 0)
                {
                    string resultMsg = _sharLocalizer[SDLocalization.NotFoundData];

                    return new Response<IEnumerable<SelectListComplaintTypeResponse>>()
                    {
                        IsNotFound = true,
                        Errors = new string[] { resultMsg },
                        Message = resultMsg,
                        Data = new List<SelectListComplaintTypeResponse>()
                    };
                }

                return new Response<IEnumerable<SelectListComplaintTypeResponse>>()
                {
                    IsSuccess = true,
                    Data = mappedComplaintType
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex,"");
                return new Response<IEnumerable<SelectListComplaintTypeResponse>>()
                {
                    Errors = new string[] { _sharLocalizer[SDLocalization.Error] },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }

        }

        public async Task<Response<AddComplaintTypeRequest>> AddComplaintTypeAsync(AddComplaintTypeRequest addComplaintTypeRequest)
        {
            bool exists = false;

            exists = await _unitOfWork.ComplaintTypes.ExistAsync(x => x.Name.Trim().ToUpper() ==
            addComplaintTypeRequest.Name.Trim().ToUpper() && !x.IsDeleted);

            if (exists)
            {
                string resultMsg = string.Format(_sharLocalizer[SDLocalization.IsExist],
                    _sharLocalizer[SDLocalization.ComplaintType]);

                return new Response<AddComplaintTypeRequest>()
                {
                    IsExists = true,
                    Errors = new string[] { resultMsg },
                    Message = resultMsg
                };
            }
            string err = _sharLocalizer[SDLocalization.Error];
            try
            {
                var objResult = await _unitOfWork.ComplaintTypes.AddAsync(_mapper.Map<OprComplaintType>(addComplaintTypeRequest));
                bool result = await _unitOfWork.CompleteAsync() > 0;

                return new Response<AddComplaintTypeRequest>()
                {
                    IsSuccess = result,
                    IdOfAddedObject = (int)objResult.Id,
                    Data = addComplaintTypeRequest,
                    Errors = new string[] { },
                    Message = result ? _sharLocalizer[SDLocalization.Done] : err
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(addComplaintTypeRequest), LogType.Bug);
                return new Response<AddComplaintTypeRequest>()
                {
                    Errors = new string[] { err },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }
        }

        public async Task<Response<UpdateComplaintTypeRequest>> UpdateComplaintTypeAsync(int complaintTypeId, UpdateComplaintTypeRequest updateComplaintTypeRequest)
        {
            bool exists = false;
            string err = _sharLocalizer[SDLocalization.Error];
            string localizedComplaintType = _sharLocalizer[SDLocalization.ComplaintType];

            var complaintType = await _unitOfWork.ComplaintTypes.GetFirstOrDefaultAsync(a => a.Id == 
            complaintTypeId && !a.IsDeleted);

            if (complaintType == null || updateComplaintTypeRequest.Id != complaintTypeId)
            {
                string resultMsg = string.Format(_sharLocalizer[SDLocalization.CannotBeFound], localizedComplaintType, complaintTypeId);

                return new Response<UpdateComplaintTypeRequest>()
                {
                    IsNotFound = true,
                    Data = updateComplaintTypeRequest,
                    Errors = new string[] { resultMsg },
                    Message = resultMsg
                };
            }
            exists = await _unitOfWork.ComplaintTypes
                .ExistAsync(x => x.Name.Trim().ToUpper() == updateComplaintTypeRequest.Name.Trim().ToUpper() && x.Id != complaintTypeId);
            if (!exists)
            {
                try
                {
                    var obj = _mapper.Map<UpdateComplaintTypeRequest, OprComplaintType>(updateComplaintTypeRequest, complaintType);
                    var objResult = _unitOfWork.ComplaintTypes.Update(obj);
                    bool result = await _unitOfWork.CompleteAsync() > 0;

                    return new Response<UpdateComplaintTypeRequest>()
                    {
                        IsSuccess = result,
                        IsUpdated = true,
                        IdOfAddedObject = (int)objResult.Id,
                        Data = updateComplaintTypeRequest,
                        Errors = new string[] { },
                        Message = result ? _sharLocalizer[SDLocalization.Updated] : err
                    };

                }
                catch (Exception ex)
                {
                    await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(updateComplaintTypeRequest));
                    return new Response<UpdateComplaintTypeRequest>()
                    {
                        Errors = new string[] { err },
                        Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                    };
                }

            }
            string msg = string.Format(_sharLocalizer[SDLocalization.IsExist], localizedComplaintType);
            return new Response<UpdateComplaintTypeRequest>()
            {
                IsExists = true,
                Errors = new string[] { msg },
                Message = msg
            };
        }

        public async Task<Response<string>> DeleteComplaintTypeAsync(int complaintTypeId)
        {
            var complaintType = await _unitOfWork.ComplaintTypes.GetFirstOrDefaultAsync(a => a.Id == 
            complaintTypeId && !a.IsDeleted);
            string resultMsg = string.Format(_sharLocalizer[SDLocalization.CannotBeFound],
                _sharLocalizer[SDLocalization.ComplaintType], complaintTypeId);

            if (complaintType == null)
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
                await _unitOfWork.ComplaintTypes.Remove(complaintType);
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
                        {JsonConvert.SerializeObject(complaintType)}");
                return new Response<string>()
                {
                    Errors = new string[] { err },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }
        }

        #endregion
    }

}