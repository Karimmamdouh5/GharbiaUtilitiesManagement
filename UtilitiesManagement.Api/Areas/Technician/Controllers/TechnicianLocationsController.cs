using UtilitiesManagement.Domain.Dtos.Request.Technician;
using UtilitiesManagement.Domain.Dtos.Response;
using UtilitiesManagement.Services.IServices.Technician;

namespace FacilityManagement.Api.Areas.Technician.Controllers
{
    [Area(Modules.Technician)]
    [ApiController]
    [ApiExplorerSettings(GroupName = Modules.Technician)]
    public class TechnicianLocationsController : ControllerBase
    {
        private readonly ITechnicianLocationsService _technicianLocationsService;

        public TechnicianLocationsController(ITechnicianLocationsService technicianLocationsService) =>
            _technicianLocationsService = technicianLocationsService;

        [HttpGet(ApiRoutes.Technicians.GetAllLocationsForTechnician)]
        [Authorize(Permissions.Technician.View)]
        public async Task<IActionResult> GetAllLocationsAsync([FromQuery] SharSearchForLocationRequest searchForLocationRequest)
        {
            var Data = await _technicianLocationsService.GetAllLocationsByFilterationForTechnicianAsync(searchForLocationRequest);
            if (!Data.IsSuccess)
                return StatusCode(500, Data);
            return Ok(Data);
        }

        [HttpGet(ApiRoutes.Technicians.GetLastLocationForUser)]
        [Authorize(Permissions.Technician.View)]
        public async Task<IActionResult> GetLastLocationForUserAsync([FromQuery] List<long> empsIds) {
            var Data = await _technicianLocationsService.GetLastLocationToUserAsync(empsIds);
            if (!Data.IsSuccess)
                return StatusCode(500, Data);
            return Ok(Data);
        }

        [HttpPost(ApiRoutes.Technicians.AddLocationsForTechnician)]
        [Authorize(Permissions.Technician.Create)]
        public async Task<IActionResult> CreateLocationsAsync(List<TechTechnicianLocationRequest> technicianLocationRequest)
        {
            var response = await _technicianLocationsService.AddTechniciansLocations(technicianLocationRequest);
            if (response.IsSuccess)
                return Ok(response);
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError, new Response<IEnumerable<TechTechnicianLocationRequest>>()
            {
                IsSuccess = false,
                Data = technicianLocationRequest,
                Errors = ModelState.Values.SelectMany(x => x.Errors.Select(y => y.ErrorMessage)),
                ErrorsCount = ModelState.ErrorCount
            });
        }

        [HttpGet(ApiRoutes.Technicians.getTechnicianLogs)]
        [Authorize(Permissions.Technician.View)]
        public async Task<IActionResult> getTechnicianLogs(int EmployeeId)
        {
            var Result = await _technicianLocationsService.getTechnicianLogs(EmployeeId);
            if (!Result.IsSuccess)
            {
                return StatusCode(500, Result);
            }
            return Ok(Result);
        }
        [HttpGet(ApiRoutes.Technicians.GetLastRecordTechnician)]
        [Authorize(Permissions.Technician.View)]
        public async Task<IActionResult> GetLastRecordTechnician(int employeeId)
        {
            var Data = await _technicianLocationsService.GetLastRecordTechnician(employeeId);
            if (!Data.IsSuccess)
            {
                return StatusCode(500, Data);
            }
            return Ok(Data);
        }
        [HttpPost(ApiRoutes.Technicians.AddNewTechnicianLog)]
        [Authorize(Permissions.Technician.Create)]
        public async Task<IActionResult> AddNewTechnicianLog(AddTechnicianLogRequest model)
        {
            var Result = await _technicianLocationsService.AddNewTechnicianLog(model);
            if (Result.IsSuccess == false)
            {
                return StatusCode(500, Result);
            }
            return Ok(Result);
        }
        [HttpPost(ApiRoutes.Technicians.StopTechnician)]
        [Authorize(Permissions.Technician.Manage)]
        public async Task<IActionResult> StopTechnician(int EmployeeId)
        {
            var Result = await _technicianLocationsService.StopTechnician(EmployeeId);
            if (!Result.IsSuccess)
            {
                return StatusCode(500, Result);
            }
            return Ok(Result);
        }
    }
}
