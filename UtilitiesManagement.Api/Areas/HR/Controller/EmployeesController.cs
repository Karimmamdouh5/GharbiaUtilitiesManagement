namespace UtilitiesManagement.Api.Areas.HR.Controller
{
    [Area(Modules.HR)]
    [ApiController]
    [ApiExplorerSettings(GroupName = Modules.HR)]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService) =>
            _employeeService = employeeService;

        [Authorize(Permissions.Employee.View)]
        [HttpGet(ApiRoutes.Employees.GetEmployeeProfile)]
        public async Task<IActionResult> GetEmployeeProfile(int employeeId)
        {
            var Result = await _employeeService.GetEmployeeProfile(employeeId);
            if (!Result.IsSuccess)
            {
                return StatusCode(500, Result);
            }
            return Ok(Result);
        }

        [Authorize(Permissions.Employee.View)]
        [HttpGet(ApiRoutes.Employees.GetEmployeesData)]
        public async Task<IActionResult> GetEmployeesData(int? branchId ,int? StateId ,int? CityId , int? areaId  , int? blockId )
        {
            var Result = await _employeeService.GetEmployeesData(branchId, StateId , CityId, areaId, blockId);
            if (!Result.IsSuccess)
            {
                return StatusCode(500, Result);
            }
            return Ok(Result);
        }

 
        [HttpGet(ApiRoutes.Employees.ListOfEmployees)]
        public async Task<IActionResult> ListOfEmployees(long? BranchId , int? StateId, int? CityId, long? areaId , long? blockId)
        {
            var Result = await _employeeService.ListOfEmployee(BranchId, StateId, CityId, areaId, blockId);
            if (!Result.IsSuccess)
            {
                return StatusCode(500, Result);
            }
            return Ok(Result);
        }
        [HttpGet(ApiRoutes.Employees.ListOfUsersEmployees)]
        public async Task<IActionResult> ListOfUsersEmployees(long? BranchId)
        {
            var Result = await _employeeService.ListOfUsersEmployee(BranchId);
            if (!Result.IsSuccess)
            {
                return StatusCode(500, Result);
            }
            return Ok(Result);
        }

        [Authorize(Permissions.Employee.Manage)]
        [HttpPost(ApiRoutes.Employees.ManageRemoteEmployeesData)]
        public async Task<IActionResult> ManageRemoteEmployeesData()
        {
            var Data = await _employeeService.ManageRemoteEmployeesData();
            if (!Data.IsSuccess)
            {
                return StatusCode(500, Data);
            }
            return Ok(Data);
        }
        
     
    }
}