using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  UtilitiesManagement.Services.IServices.Seeds
{
    public interface IDbInitSeedsService
    {
        Task Initialize();
        Task SeedRollesAsync();
        Task SeedBasicUserAsync();
        Task SeedSuperAdminUserAsync();
    }
}
