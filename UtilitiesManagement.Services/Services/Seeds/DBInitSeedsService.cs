
using UtilitiesManagement.Domain.Constants.Seed;
using UtilitiesManagement.Domain.Interfaces.Align;

using UtilitiesManagement.Services.IServices.Seeds;
using UtilitiesManagement.Services.IServices.Shared;
using static UtilitiesManagement.Domain.Constants.Permissions.Permissions;

namespace  UtilitiesManagement.Services.Services.Seeds
{
    public class DBInitSeedsService: IDbInitSeedsService
    {
        
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILoggingRepository _customLogging;
        private readonly ICompanyService _companiesService;
        public DBInitSeedsService(IUnitOfWork unitOfWork, IMapper mapper,RoleManager<ApplicationRole> roleManager, UserManager<ApplicationUser> userManager,   ILoggingRepository customLogging, ICompanyService companiesService)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _customLogging = customLogging; 
            _companiesService = companiesService;   
        }
        public async Task Initialize()
        {
            //try
            //{

            //    if (!await _unitOfWork.States.AnyAsync())
            //    {

            //        var states = SeedingData.ListOfStates();
            //        await _unitOfWork.States.AddRangeAsync(states);

            //    }
            //    if (!await _unitOfWork.Regions.AnyAsync())
            //    {
            //        var regions = SeedingData.ListOfRegions();
            //        await _unitOfWork.Regions.AddRangeAsync(regions);
            //    }
            //    if (!await _unitOfWork.Status.AnyAsync())
            //    {
            //        var status = SeedingData.ListOfStatus();
            //        await _unitOfWork.Status.AddRangeAsync(status);
            //    }
            //    if (!await _unitOfWork.MilitaryStatus.AnyAsync())
            //    {

            //        var militaryStatus = SeedingData.ListOfMilitaryStatus();
            //        await _unitOfWork.MilitaryStatus.AddRangeAsync(militaryStatus);
            //    }
            //    if (!await _unitOfWork.MartialStatus.AnyAsync())
            //    {
            //        var martialStatus = SeedingData.ListOfMartialStatus();
            //        await _unitOfWork.MartialStatus.AddRangeAsync(martialStatus);

            //    }
            //    await _unitOfWork.CompleteAsync();
            //}
            //catch (Exception ex)
            //{
            //    await _customLogging.LogExceptionInDb(ex, "seeding Shared Tables and HR exception");

            //}

            var companyIsExist = await _unitOfWork.Companies.AnyAsync();
            if (!companyIsExist)
            {
                AddCompanyRequest addCompanyRequest = new AddCompanyRequest()
                {
                    CompanyName = "Align",
                    CompanyCode = "aligntech",
                    Activity = "Tech",
                    Address = "New Cairo , Egypt",
                    IsActive = true,
                    PhoneNumber = "01557033852",
                    ManagerName = "Tarek",
                    MobileUsersCount = 100,
                    Job ="CEO",
                    RoleName=Roles.SuperAdmin.ToString(),
                    Is_SuperAdmin=true

                };
                var result =await _companiesService.AddCompanyAsync(addCompanyRequest);
                Console.WriteLine(result);
               
            }
               
 
           
           
        }
        public  async Task SeedRollesAsync()
        {
            if (!_roleManager.Roles.Any())
            {
                await _roleManager.CreateAsync(new ApplicationRole(){Name= Roles.SuperAdmin.ToString() });
                await _roleManager.CreateAsync(new ApplicationRole(){ Name= Roles.Admin.ToString() });
                await _roleManager.CreateAsync(new ApplicationRole() { Name= Roles.User.ToString() });
            }
        }


        public  async Task SeedBasicUserAsync()
        {
            var defaultUser = new ApplicationUser
            {
                UserName = "basicuser",
                Email = "basicuser@domain.com",
                EmailConfirmed = true
            };

            var user = await _userManager.FindByEmailAsync(defaultUser.Email);

            if (user == null)
            {
                await _userManager.CreateAsync(defaultUser, "123456");
                await _userManager.AddToRoleAsync(defaultUser, Roles.User.ToString());
            }
        }

        public  async Task SeedSuperAdminUserAsync()
        {
            var defaultUser = new ApplicationUser
            {
                UserName = "superadmin",
                Email = "superadmin@domain.com",
                EmailConfirmed = true
            };

            var user = await _userManager.FindByEmailAsync(defaultUser.Email);

            if (user == null)
            {
                await _userManager.CreateAsync(defaultUser, "123456");
                await _userManager.AddToRolesAsync(defaultUser, new List<string> { Roles.User.ToString(), Roles.Admin.ToString(), Roles.SuperAdmin.ToString() });
            }

            await SeedClaimsForSuperUser();
        }

        private  async Task SeedClaimsForSuperUser()
        {
            var adminRole = await _roleManager.FindByNameAsync(Roles.SuperAdmin.ToString());
            string module = PermissionsModules.HR_Employees.ToString();

            var allClaims = await _roleManager.GetClaimsAsync(adminRole);
            var allPermissions = Permissions.GeneratePermissionsList(module,module);

            foreach (var permission in allPermissions)
            {
                if (!allClaims.Any(c => c.Type == "Permission" && c.Value == permission))
                    await _roleManager.AddClaimAsync(adminRole, new Claim("Permission", permission));
            }

        }

       
    }
}