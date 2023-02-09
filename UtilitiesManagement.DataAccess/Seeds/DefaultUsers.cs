using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace  UtilitiesManagement.DataAccess.Seeds
{
    public static class DefaultUsers
    {
        public static async Task SeedBasicUserAsync(UserManager<ApplicationUser> userManager)
        {
            var defaultUser = new ApplicationUser
            {
                UserName = "BasicUser",
                Email = "basicuser@align.com",
                EmailConfirmed = true
            };

            var user = await userManager.FindByEmailAsync(defaultUser.Email);

            if (user == null)
            {
                await userManager.CreateAsync(defaultUser, "123456");
                await userManager.AddToRoleAsync(defaultUser, Roles.User.ToString());
            }
        }

        public static async Task SeedSuperAdminUserAsync(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManger)
        {
            var defaultUser = new ApplicationUser
            {
                UserName = "SuperAdmin",
                Email = "superadmin@align.com",
                EmailConfirmed = true
            };
            var user = await userManager.FindByEmailAsync(defaultUser.Email);
            if (user == null)
            {
                await userManager.CreateAsync(defaultUser, "123456");
                await userManager.AddToRolesAsync(defaultUser, new List<string> { Roles.User.ToString(), Roles.Admin.ToString(), Roles.SuperAdmin.ToString() });
            }

            await roleManger.SeedClaimsForSuperUser();
        }

        private static async Task SeedClaimsForSuperUser(this RoleManager<ApplicationRole> roleManager)
        {
            var adminRole = await roleManager.FindByNameAsync(Roles.SuperAdmin.ToString());
            await roleManager.AddPermissionClaims(adminRole, PermissionsModules.HR_Employees.ToString());
        }

        public static async Task AddPermissionClaims(this RoleManager<ApplicationRole> roleManager, ApplicationRole role, string module)
        {
            var allClaims = await roleManager.GetClaimsAsync(role);
            var allPermissions = Permissions.GeneratePermissionsList(module,module);

            foreach (var permission in allPermissions)
            {
                if (!allClaims.Any(c => c.Type == "Permission" && c.Value == permission))
                    await roleManager.AddClaimAsync(role, new Claim("Permission", permission));
            }
        }
    }
}
