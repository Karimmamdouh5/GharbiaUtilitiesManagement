using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using UtilitiesManagement.Services.IServices.Shared;

namespace UtilitiesManagement.Api.Areas.Shared.Controllers
{
    [Area(Modules.Shared)]
    [ApiController]
    [ApiExplorerSettings(GroupName = Modules.Shared)]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class GeographicController : ControllerBase
    {
        private readonly IBranchService _branchService;
        private readonly IAreaService _areaService;
        private readonly IBlockService _blockService;
        private readonly IGeneralService _generalService;
        private readonly IStateService stateService;
        private readonly ICityService _cityService;

        public GeographicController(IBranchService branchService, IAreaService areaService, IBlockService blockService, IGeneralService generalService, IStateService StateService, ICityService cityService)
        {
            _branchService = branchService;
            _areaService = areaService;
            _blockService = blockService;
            _generalService = generalService;
            stateService = StateService;
            _cityService = cityService;
        }

        //[HttpGet(ApiRoutes.Branches.CreateBranch)]
        //[AllowAnonymous]
        //public async Task<IActionResult> GetBranchesData()
        //{
        //    var Result = await _branchService.Remote_GetBranchesDataAsync();
        //    //if (!Result.IsSuccess)
        //    //{
        //    //    return StatusCode(500, Result);
        //    //}
        //    return Ok(Result);
        //}

        //[HttpPost(ApiRoutes.Geographic.LoadAllGeoData)]
        //[Authorize(Permissions.Geographic.Manage)]
        //public async Task<IActionResult> LoadAllGeoData()
        //{
        //    try
        //    {
        //        await _branchService.ManageBranchsDataAsync();
        //        await _areaService.ManageAreasDataAsync();
        //        await _blockService.ManageBlocksDataAsync();
        //        return Ok(true);
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(500, false);
        //    }
        //}
        [Authorize(Permissions.Geographic.Manage)]
        [HttpPost(ApiRoutes.Geographic.LoadAllBillTemp)]
        public async Task<IActionResult> LoadGeneralBillTableData()
        {
            var result = await _generalService.LoadMainBillsTableData();
            if(result.IsSuccess)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet(ApiRoutes.Geographic.ListOfBranches)]
        public async Task<IActionResult> ListOfBranches(int? CompanyId , int? EmployeeId, bool? assignedUserOnly)
        {

            var Data = await _branchService.GetBranchesAsync(CompanyId, EmployeeId,assignedUserOnly);
            if (!Data.IsSuccess)
            {
                return StatusCode(500, Data);
            }
            return Ok(Data);
        }

        [HttpGet(ApiRoutes.Geographic.ListOfStates)]
        public async Task<IActionResult> ListOfStates(int? BranchId, int? EmployeeId)
        {
            var Data = await stateService.GetStatesAsync(BranchId, EmployeeId);
            if (!Data.IsSuccess)
            {
                return StatusCode(500, Data);
            }
            return Ok(Data);
        }
        [HttpGet(ApiRoutes.Geographic.ListOfCities)]
        public async Task<IActionResult> ListOfCities(int? StateId, int? EmployeeId)
        {
            var Data = await _cityService.GetCityAsync(StateId, EmployeeId);
            if (!Data.IsSuccess)
            {
                return StatusCode(500, Data);
            }
            return Ok(Data);
        }
        [HttpGet(ApiRoutes.Geographic.ListOfAreas)]
        public async Task<IActionResult> ListOfAreas(int? cityId, int? employeeId)
        {
            var Data = await _areaService.GetAreasAsync(cityId, employeeId);
            if (!Data.IsSuccess)
            {
                return StatusCode(500, Data);
            }
            return Ok(Data);
        }
        [HttpGet(ApiRoutes.Geographic.ListOfBlocks)]
        public async Task<IActionResult> ListOfBlocks(int? AreaId, int? EmployeeId)
        {
            var Data = await _blockService.GetBlocksAsync(AreaId, EmployeeId);
            if (!Data.IsSuccess)
            {
                return StatusCode(500, Data);
            }
            return Ok(Data);
        }
        [HttpGet(ApiRoutes.Geographic.GetBlocksByEmployeeAsync)]
        [Authorize(Permissions.Geographic.View)]
        public async Task<IActionResult> GetBlocksByEmployeeAsync(int EmployeeId)
        {
            var Data = await _blockService.GetBlocksByEmployeeAsync(EmployeeId);
            if (!Data.IsSuccess)
            {
                return StatusCode(500, Data);
            }
            return Ok(Data);
        }
        [HttpPost(ApiRoutes.Geographic.ManageData)]
        [Authorize(Permissions.Geographic.Manage)]
        public async Task<IActionResult> ManageData()
        {
            var Data = await _generalService.ManageData();
            if (!Data.IsSuccess)
                return StatusCode(500, Data);
            return Ok(Data);
        }
    }
}