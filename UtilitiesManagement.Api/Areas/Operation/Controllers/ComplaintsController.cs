namespace UtilitiesManagement.Api.Areas.Operation.Controllers
{
    [Area(Modules.Operation)]
    [ApiController]
    [ApiExplorerSettings(GroupName = Modules.Operation)]
    public class ComplaintsController : ControllerBase
    {
        private readonly IComplaintsService _complaintsService;

        public ComplaintsController(IComplaintsService complaintsService) =>
            _complaintsService = complaintsService;

        //[Authorize(Permissions.Complaints.View)]
        [AllowAnonymous]
        [HttpGet(ApiRoutes.Complaints.GetAllComplaints)]
        public async Task<IActionResult> GetAllComplaintsAsync([FromQuery] SearchParametersRequest searchParametersRequest) =>
            Ok(await _complaintsService.GetAllComplaintsAsync(searchParametersRequest));

        [Authorize(Permissions.Complaints.Create)]
        [HttpPost(ApiRoutes.Complaints.CreateComplaint)]
        public async Task<IActionResult> CreateComplaintAsync(IEnumerable<AddComplaintRequest> addComplaintRequests)
        {
            var response = await _complaintsService.AddComplaintAsync(addComplaintRequests);
            if (response.IsSuccess)
                return Ok(response);
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError, response);
        }

        [Authorize(Permissions.Complaints.Manage)]
        [HttpPut(ApiRoutes.Complaints.UpdateComplaint)]
        public async Task<IActionResult> UpdateComplaintAsync(List<UpdateComplaintRequest> updateComplaintRequests)
        {
            var response = await _complaintsService.UpdateSpecificFieldForComplaintAsync(updateComplaintRequests);
            if (response.IsSuccess)
                return Ok(response);
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError, response);
        }

        [HttpPost(ApiRoutes.Complaints.UploadComplaintImages)]
        [Authorize(Permissions.Complaints.Create)]
        public async Task<IActionResult> UploadComplaintImagesAsync(List<IFormFile> photos, ImagePathRequest imagePath,string? internet_Speed)
        {
            var response = await _complaintsService.UploadComplaintImagesAsync(photos, imagePath, internet_Speed);
            if (response.IsSuccess)
                return Ok(response);
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError, response);
        }
    }
}