namespace UtilitiesManagement.Services.Services.Bill
{
    public class IssueService : IIssueService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;
        private readonly IHttpContextAccessor _accessor;
        private readonly ILoggingRepository _customLog;
        private readonly IMapper _mapper;
        public IssueService(IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharLocalizer,
                            IHttpContextAccessor accessor, ILoggingRepository loggingRepository, 
                            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _sharLocalizer = sharLocalizer;
            _accessor = accessor;
            _customLog = loggingRepository;
            _mapper = mapper;
        }

        public async Task<Response<List<BillsIssueResponse>>> ListOfIssues(bool All)
        {
            try
            {
                long? companyId = _accessor!.HttpContext == null ? null : _accessor!.HttpContext!.User.GetCompanyId();
                var Data = (await _unitOfWork.Issue.GetSpecificSelectAsync(filter: x => x.Company_Id == companyId && (All || x.IsActive == !All), select: w => new BillsIssueResponse() { Id = w.Id, IssueDate = w.IssueDate, IssueName = w.IssueName, IssueState = w.IsActive })).OrderByDescending(x => x.Id).ToList();
                return new Response<List<BillsIssueResponse>>()
                {
                    Data = Data,
                    Message = _sharLocalizer[SDLocalization.Data],
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex,"");
                return new Response<List<BillsIssueResponse>>()
                {
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] { ex.Message }
                };
            }
        }
        public async Task<Response<List<BillIssueDetailsResponse>>> ListOfIssuessDetails(bool All , long? BranchId , long? IssueId)
        {

            try
            {
                var Data = (await _unitOfWork.IssueDetails.GetSpecificSelectAsync(filter: x => (x.Branch_Id == BranchId|| BranchId==null) && (IssueId == null || x.Issue_Id == IssueId) && (All || x.IsActive == !All), select: y => new BillIssueDetailsResponse()
                {
                    IssueDetailsId = y.Id,
                    BranchId = y.Branch_Id,
                    BranchName = y.Branch.BranchName,
                    IssueDetailsStatus = y.IsActive,
                    BillEndNum = y.BillEndNum,
                    BillStartNum = y.BillStartNum,
                    IssueId = y.Issue_Id,
                    IssueName = y.Issue.IssueName,
                    IssueStatus = y.Issue.IsActive
                })).OrderByDescending(x => x.IssueDetailsId).ToList();
                return new Response<List<BillIssueDetailsResponse>>()
                {
                    Data = Data,
                    Message = _sharLocalizer[SDLocalization.Data],
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, "");
                return new Response<List<BillIssueDetailsResponse>>()
                {
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] {ex.Message}
                };
            }
        }

        public async Task<Response<string>> ManageIssueData()
        {

            try 
            {
                // var LastIssueData = await _unitOfWork.Issue.GetFirstOrDefaultAsync(filter: x => true,orderBy:x => x.OrderByDescending(y =>y.Id));
                //await _unitOfWork.Issue.CommitAllIssuesChanges(LastIssueData != null ? LastIssueData.IssueDate : new DateTime(1990,1,1));

                // SubQuery To Get BranchId From BranchName
                var existingIssueData = await _unitOfWork.Issue.GetAllAsync(filter: x => x.IsActive && !x.IsDeleted, ignoreQueryFilters: true);

                var BillIssues = await _unitOfWork.Issue.RemoteDataLoading();

                var mainIssue = _mapper.Map<List<BillIssue>>(BillIssues);

                var addingIssue = mainIssue.Where(x => !existingIssueData.Any(y => y.IssueDate == x.IssueDate && y.IssueName == x.IssueName && y.IsActive));

                var deletingIssue = existingIssueData.Where(x => !mainIssue.Any(y => y.IssueName == x.IssueName && y.IssueDate == x.IssueDate && x.IsActive));

                await _unitOfWork.Issue.AddRangeAsync(addingIssue);

                _unitOfWork.Issue.RemoveRange(deletingIssue);

                await _unitOfWork.CompleteAsync();

                return new Response<string>()
                {
                    Message = _sharLocalizer[SDLocalization.Done],
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                    
                await _customLog.LogExceptionInDb(ex,"");
                return new Response<string>()
                {
                    Message = _sharLocalizer[SDLocalization.Error],
                    IsSuccess = false,
                    Errors = new[] {ex.Message}
                };
            }
            
        }
    }
}
