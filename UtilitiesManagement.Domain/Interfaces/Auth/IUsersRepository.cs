using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  UtilitiesManagement.Domain.Interfaces.Auth
{
    public interface IUsersRepository : IBaseRepository<ApplicationUser>
    {
        Task<ApplicationUser> GetTheUser(string CompanyCode, string UserName);
        Task<long[]> GetAssignedBranches(string UserId);
    }
}
