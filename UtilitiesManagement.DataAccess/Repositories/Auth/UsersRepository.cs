using UtilitiesManagement.Domain.Interfaces.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  UtilitiesManagement.DataAccess.Repositories.Auth
{
    public class UsersRepository : BaseRepository<ApplicationUser>, IUsersRepository
    {
       
        public UsersRepository(UtilitiesDbContext context, IMapper mapper, ILoggingRepository loggingRepository, ILogger logger, IConfiguration config, IHttpContextAccessor accessor) : base(context, loggingRepository,logger,mapper,config, accessor)
        {
        }
        public async Task<ApplicationUser> GetTheUser(string CompanyCode, string UserName)
        {
            UserName = $"{CompanyCode.Trim()}_{UserName.Trim()}";
            var user= await _context.Users.IgnoreQueryFilters().AsNoTracking().AsSplitQuery()
                .Include(x => x.UserType)
                .Include(x => x.Employee)
                .ThenInclude(x => x.Branch)
                .ThenInclude(x => x.Company)
                .AsSplitQuery()
                .FirstOrDefaultAsync(x =>
                      x.IsActive && !x.IsDeleted && x.UserName.ToLower() == UserName.ToLower()
                      && x.Employee.IsActive && !x.Employee.IsDeleted
                   /*&& !x.Employee.Branch.LockTechnicalsLogins && x.Employee.Branch.IsActive*/ && !x.Employee.Branch.IsDeleted  && x.Employee.Branch.Company.CompanyCode.Trim().ToLower() == CompanyCode.Trim().ToLower() );
            return user;
        }
        public async Task<long[]> GetAssignedBranches(string UserId)
        {
            var ids = await _context.UserBranches.Where(a => a.User_Id == UserId && !a.IsDeleted).Select(x => x.Branch_Id).ToArrayAsync();
            return ids;
        }


    }
}

