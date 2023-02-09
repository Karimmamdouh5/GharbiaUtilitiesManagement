namespace UtilitiesManagement.Api.Areas.Operation.Controllers
{
    [Area(Modules.Operation)]
    [ApiController]
    [ApiExplorerSettings(GroupName = Modules.Operation)]
    public class ComplaintTypesController : ControllerBase
    {
        private readonly IComplaintTypesService _complaintTypesService;

        public ComplaintTypesController(IComplaintTypesService complaintTypesService) =>
            _complaintTypesService = complaintTypesService;

        [HttpGet(ApiRoutes.ComplaintTypes.GetAllComplaintTypes)]
        [Authorize(Permissions.Complaints.View)]
        public async Task<IActionResult> GetAllComplaintTypesAsync() =>
            Ok(await _complaintTypesService.GetAllComplaintTypesAsync());

        [HttpPost(ApiRoutes.ComplaintTypes.CreateComplaintType)]
        [Authorize(Permissions.Complaints.Create)]
        public async Task<IActionResult> CreateComplaintTypeAsync(AddComplaintTypeRequest addComplaintTypeRequest)
        {
            var response = await _complaintTypesService.AddComplaintTypeAsync(addComplaintTypeRequest);
            if (response.IsSuccess)
                return Ok(response);
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError, response);
        }

        [HttpPut(ApiRoutes.ComplaintTypes.UpdateComplaintType)]
        [Authorize(Permissions.Complaints.Manage)]
        public async Task<IActionResult> UpdateComplaintTypeAsync(int complaintTypeId, UpdateComplaintTypeRequest updateComplaintTypeRequest)
        {
            var response = await _complaintTypesService.UpdateComplaintTypeAsync(complaintTypeId, updateComplaintTypeRequest);
            if (response.IsSuccess)
                return Ok(response);
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError, response);
        }

        [HttpDelete(ApiRoutes.ComplaintTypes.DeleteComplaintType)]
        [Authorize(Permissions.Complaints.Manage)]
        public async Task<IActionResult> DeleteComplaintTypeAsync(int complaintTypeId)
        {
            var response = await _complaintTypesService.DeleteComplaintTypeAsync(complaintTypeId);
            if (response.IsSuccess)
                return Ok(response);
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError, response);
        }
    }
}
