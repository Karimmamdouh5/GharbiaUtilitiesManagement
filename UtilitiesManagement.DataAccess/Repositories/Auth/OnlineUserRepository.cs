

namespace  UtilitiesManagement.DataAccess.Repositories.Auth
{
    public class OnlineUserRepository : BaseRepository<PermOnlineUser>, IOnlineUserRepository
    {
      
        public OnlineUserRepository(UtilitiesDbContext context, IMapper mapper,
                                     ILoggingRepository loggingRepository, ILogger logger, IConfiguration config, IHttpContextAccessor accessor)
                                   : base(context, loggingRepository, logger,mapper, config, accessor)
        {
           
        }

        public async Task<IEnumerable<AuthCountOnlineUsersResponse>> GetNumOfOnlineUsersAsync(int? companyId)
        {
          
            return await _context.PermOnlineUsers.IgnoreQueryFilters()
           .Include(x => x.User.Employee)
           .ThenInclude(x => x.Branch)
           .ThenInclude(a => a.Company)
           .Where(x => !x.IsDeleted && (x.User.Employee.Branch.Company_Id == companyId ||
            companyId == null))
           .GroupBy(x => new
           {
               x.User.Employee.Branch.Company.Id,
               x.User.Employee.Branch.Company.CompanyName
           })

           .Select(x => new AuthCountOnlineUsersResponse
           {
               CompanyId = x.Key.Id,
               CompanyName = x.Key.CompanyName,
               CountOnlineUsers = x.Count()
           }).ToListAsync();
        }

        //public async Task<List<AuthOnlineUserResponse>> GetUsersAsync(bool? connectionStatus = null, int? companyId = null)
        //{
        //    return await _context.PermOnlineUsers.IgnoreQueryFilters()
        //        .Include(x => x.ApplicationUser.Employee)
        //        .ThenInclude(x => x.Branch)
        //        .ThenInclude(a => a.Company)
        //        .Where(x => (!x.IsDeleted == connectionStatus || connectionStatus == null) &&
        //        (companyId == null || x.ApplicationUser.Employee.Branch.Company_Id == companyId))

        //        .Select(x => new AuthOnlineUserResponse
        //        {
        //            Id = x.Id,
        //            UserId = x.UserId,
        //            Name = x.ApplicationUser.Employee.Name,
        //            Email = x.ApplicationUser.Email,
        //            StartDate = x.InsertDate,
        //            EndDate = x.DeleteDate,
        //            RemainingTime = ConvertTimeSpanToFormattedString.ToReadableString(x.InsertDate.AddHours(8).Subtract(DateTime.UtcNow.AddHours(2))),
        //            BranchName = x.ApplicationUser.Employee.Branch.BranchName,
        //            CompanyName = x.ApplicationUser.Employee.Branch.Company.CompanyName,
        //            JobId = x.JobId,
        //            Mobile = x.ApplicationUser.Employee.Mobile,
        //            IsMobile = string.IsNullOrEmpty(x.AndroidId),
        //            IsConnected = !x.IsDeleted
        //        })
        //        .OrderBy(x => !x.IsConnected)
        //        .ThenByDescending(x => x.Id)
        //        .ToListAsync();
        //}
    }
}
