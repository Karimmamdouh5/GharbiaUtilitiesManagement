

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  UtilitiesManagement.DataAccess.Seeds
{
    public static class DefaultRoles
    {
        public static async Task SeedAsync(RoleManager<ApplicationRole> roleManger)
        {
            if (!roleManger.Roles.Any())
            {
                await roleManger.CreateAsync(new ApplicationRole() { Name = Roles.SuperAdmin.ToString() });
                await roleManger.CreateAsync(new ApplicationRole() {Name= Roles.Admin.ToString() });
                await roleManger.CreateAsync(new ApplicationRole() { Name = Roles.User.ToString() });
            }
        }
    }
}
