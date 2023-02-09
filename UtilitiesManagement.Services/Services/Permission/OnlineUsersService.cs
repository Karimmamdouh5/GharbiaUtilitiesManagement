namespace  UtilitiesManagement.Services.Services.Permission
{
    public class OnlineUsersService : IOnlineUsersService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;
        private readonly ILoggingRepository _customLog;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public OnlineUsersService(IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharLocalizer,
                                   ILoggingRepository loggingRepository, IMapper mapper,UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _sharLocalizer = sharLocalizer;
            _customLog = loggingRepository;
            _mapper = mapper;
            _userManager = userManager;
        }

        #region Connected Or Disconnected Users

        public async Task<Response<List<AuthOnlineUserResponse>>> GetUsersAsync(bool? connectionStatus = null, int? companyId = null)
        {
            try
            {
                //var result = (await _unitOfWork.OnlineUsers.GetUsersAsync(connectionStatus, companyId))
                //    .DistinctBy(x => x.UserId).ToList();

                var result = (await _unitOfWork.OnlineUsers.GetSpecificSelectAsync(x => (!x.IsDeleted ==
                 connectionStatus || connectionStatus == null) && (companyId == null || x.User
                 .Employee.Branch.Company_Id == companyId)
                , ignoreQueryFilters: true,

                 select: x => new AuthOnlineUserResponse
                 {
                     Id = x.Id,
                     UserId = x.UserId,
                     EmpId = x.User.Employee_Id,
                     Name = x.User.Employee.Name,
                     Email = x.User.Email,
                     StartDate = x.InsertDate,

                     EndDate = x.IsDeleted ? x.DeleteDate.ToString()! : x.InsertDate.AddHours(8).ToString(),

                     RemainingTime = ConvertTimeSpanToFormattedString.ToReadableAsObject(x.InsertDate.AddHours
                     (8).Subtract(DateTime.UtcNow.AddHours(2)), x.IsDeleted, x.InsertDate.AddHours(8)),

                     BranchName = x.User.Employee.Branch.BranchName,
                     CompanyName = x.User.Employee.Branch.Company.CompanyName,
                     JobId = x.JobId,
                     Mobile = x.User.Employee.Mobile,
                     IsMobile = x.AndroidId != null,
                     IsConnected = DateTime.UtcNow.AddHours(2) > x.InsertDate.AddHours(8) ? false
                     : !x.IsDeleted
                 }))
                 .OrderBy(x => !x.IsConnected)
                 .ThenByDescending(x => x.Id)
                 .DistinctBy(x => x.UserId)
                 .ToList(); ;

                if (result == null || result.ToList().Count == 0)
                {
                    string resultMsg = _sharLocalizer[SDLocalization.NotFoundData];

                    return new Response<List<AuthOnlineUserResponse>>()
                    {
                        IsNotFound = true,
                        Errors = new string[] { resultMsg },
                        Message = resultMsg
                    };
                }

                return new Response<List<AuthOnlineUserResponse>>()
                {
                    IsSuccess = true,
                    Data = result.ToList()
                };
            }
            catch (Exception ex)
            {
                return new Response<List<AuthOnlineUserResponse>>()
                {
                    Errors = new string[] { _sharLocalizer[SDLocalization.Error] },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }
        }

        public async Task<Response<IEnumerable<AuthOnlineUserResponse>>> GetUserLogsAsync(AuthSearchForDisabledUsersRequest searchForDisabledUsersRequest)
        {
            try
            {
                searchForDisabledUsersRequest.EndDate = searchForDisabledUsersRequest.EndDate == null ?
                    searchForDisabledUsersRequest.EndDate : searchForDisabledUsersRequest.EndDate.Value.
                    AddHours(23).AddMinutes(59).AddSeconds(59);

                var result = (await _unitOfWork.OnlineUsers.GetSpecificSelectAsync(x => x.User.Employee_Id ==
                searchForDisabledUsersRequest.EmpId
                &&
                (searchForDisabledUsersRequest.StartDate == null || x.InsertDate >=
                 searchForDisabledUsersRequest.StartDate)
                &&
                (searchForDisabledUsersRequest.EndDate == null || x.InsertDate <=
                 searchForDisabledUsersRequest.EndDate),

                 ignoreQueryFilters: true,
                 select: x => new AuthOnlineUserResponse
                 {
                     Id = x.Id,
                     UserId = x.UserId,
                     EmpId = x.User.Employee_Id,
                     Name = x.User.Employee.Name,
                     Email = x.User.Email,
                     StartDate = x.InsertDate,
                     EndDate = x.IsDeleted ? x.DeleteDate.ToString()! : x.InsertDate.AddHours(8).ToString(),

                     RemainingTime = ConvertTimeSpanToFormattedString.ToReadableAsObject(x.InsertDate.AddHours
                     (8).Subtract(DateTime.UtcNow.AddHours(2)), x.IsDeleted, x.InsertDate.AddHours(8)),

                     BranchName = x.User.Employee.Branch.BranchName,
                     CompanyName = x.User.Employee.Branch.Company.CompanyName,
                     JobId = x.JobId,
                     Mobile = x.User.Employee.Mobile,
                     IsMobile = x.AndroidId != null,
                     IsConnected = DateTime.UtcNow.AddHours(2) <= x.InsertDate.AddHours(8) && !x.IsDeleted  
                 }))
                  .OrderBy(x => !x.IsConnected)
                 .AsEnumerable();

                if (result == null || result!.ToList().Count == 0)
                {
                    string resultMsg = _sharLocalizer[SDLocalization.NotFoundData];

                    return new Response<IEnumerable<AuthOnlineUserResponse>>()
                    {
                        IsNotFound = true,
                        Errors = new string[] { resultMsg },
                        Message = resultMsg
                    };
                }
                return new Response<IEnumerable<AuthOnlineUserResponse>>()
                {
                    IsSuccess = true,
                    Data = result
                };
            }
            catch (Exception ex)
            {
                return new Response<IEnumerable<AuthOnlineUserResponse>>()
                {
                    Errors = new string[] { _sharLocalizer[SDLocalization.Error] },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }
        }

        public async Task<Response<IEnumerable<AuthUserSelectListResponse>>> ListOfUsersAsync(int companyId)
        {
            var result = await _unitOfWork.Users.GetSpecificSelectAsync(x => x.Employee.Branch.Company.Id ==
            companyId && x.IsActive && !x.IsDeleted, ignoreQueryFilters: true,
            select: x => new AuthUserSelectListResponse
            {
                Id = x.Id,
                Name = x.Employee.Name
            });

            if (result == null || !result.Any())
            {
                string resultMsg = _sharLocalizer[SDLocalization.NotFoundData];

                return new Response<IEnumerable<AuthUserSelectListResponse>>()
                {
                    IsNotFound = true,
                    Errors = new string[] { resultMsg },
                    Message = resultMsg
                };
            }

            return new Response<IEnumerable<AuthUserSelectListResponse>>()
            {
                IsSuccess = true,
                Data = result
            };
        }

        public async Task<List<AuthCountOnlineUsersResponse>> GetNumOfOnlineUsersAsync(int? companyId) =>
            (await _unitOfWork.OnlineUsers.GetNumOfOnlineUsersAsync(companyId)).ToList();

        

        #endregion
    }
}
