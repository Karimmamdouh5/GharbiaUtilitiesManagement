namespace UtilitiesManagement.Services.Services.Shared
{
    public class BranchService : IBranchService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;
        private readonly ILoggingRepository _customLog;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _accessor;

        public BranchService(IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharLocalizer,
                                ILoggingRepository loggingRepository, IMapper mapper , IHttpContextAccessor accessor

                              )
        {
            _unitOfWork = unitOfWork;
            _sharLocalizer = sharLocalizer;
            _customLog = loggingRepository;
            _mapper = mapper;
            _accessor = accessor;

        }

        public async Task<Response<IEnumerable<SelectListResponse>>> GetBranchesAsync(int? companyId, int? employeeId, bool? assignedUserOnly)
        {
            try
            {
                if (employeeId==null)
                {
                    string UserId = _accessor!.HttpContext == null ? "" : _accessor!.HttpContext!.User.GetUserId();
                    
                    var BranchesUsersIds = await _unitOfWork.Users.GetAssignedBranches(UserId);
                    return new Response<IEnumerable<SelectListResponse>>()
                    {
                        Data = _mapper.Map<List<SelectListResponse>>(_unitOfWork.Branches.GetAll( x => x.Company_Id == companyId && (assignedUserOnly == true ? (BranchesUsersIds.Contains(x.Id)) : true)).ToList()),
                        IsSuccess = true,
                        Message = _sharLocalizer[SDLocalization.Data]
                    };
                }
                return new Response<IEnumerable<SelectListResponse>>()
                {
                    Data = (await _unitOfWork.EmployeeBlocks.GetSpecificSelectAsync(filter: x => x.Collector_Id == employeeId , select: g => new SelectListResponse { Id = g.Block.Area.City.State.Branch.Id, Name = g.Block.Area.City.State.Branch.BranchName })).DistinctBy(a => a.Id),
                    IsSuccess = true,
                    Message = _sharLocalizer[SDLocalization.Data]
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, "");
                return new Response<IEnumerable<SelectListResponse>>()
                {
                    Errors = new[] { ex.Message },
                    Message = _sharLocalizer[SDLocalization.Error]
                };
            }
        }

        public async Task<bool> ManageBranchsDataAsync()
        {
            try
            {
                var LastObject = _unitOfWork.Branches.GetFirstOrDefault(orderBy: x => x.OrderByDescending(x => x.Id));
                var Data = _mapper.Map<List<SharBranch>>(await _unitOfWork.Branches.Remote_GetBranchesData(LastObject != null ? LastObject.Id : 0 , false));
                Data.ForEach(x => { x.Company = null;x.Company_Id = 2; });
                await _unitOfWork.Branches.AddRangeAsync(Data);
                var UpdattingData = _mapper.Map<List<SharBranch>>(await _unitOfWork.Branches.Remote_GetBranchesData(0, true)).Where(x => Data.All(y => y.Id != x.Id)).ToList();
                UpdattingData.ForEach(x => { x.Company = null;x.Company_Id = 2;x.IsUpdated = false; });
                _unitOfWork.Branches.UpdateRange(UpdattingData);
                _unitOfWork.Complete();
                _unitOfWork.Branches.CommitAllBranchsChanges();
                return true;
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, "");
                return false;
            }
        }

        #region Branches
        //public async Task<IEnumerable<SharBranch_ViewModel>> Remote_GetBranchesDataAsync()=>
        //     await _unitOfWork.Branches.Remote_GetBranchesData();

        #endregion
    }
}
