namespace UtilitiesManagement.Api.Areas.Operation.Controllers
{
    [Area(Modules.Operation)]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [ApiExplorerSettings(GroupName = Modules.Operation)]
    public class MeterReadingsController : ControllerBase
    {
        private readonly IMeterReadingsService _meterReadingsService;

        public MeterReadingsController(IMeterReadingsService meterReadingsService) =>
            _meterReadingsService = meterReadingsService;

        [Authorize(Permissions.MeterReading.View)]
        [HttpGet(ApiRoutes.MeterReadings.GetAllMeterReadings)]
        public async Task<IActionResult> GetAllMeterReadingsAsync([FromQuery] SearchParametersForMeterReadingsRequest searchParametersRequest) =>
            Ok(await _meterReadingsService.GetAllMeterReadingsAsync(searchParametersRequest));


        [Authorize(Permissions.MeterReading.Create)]
        [HttpPost(ApiRoutes.MeterReadings.CreateMeterReading)]
        public async Task<IActionResult> CreateMeterReadingAsync(IEnumerable<AddMeterReadingRequest> addMeterReadingRequests)
        {
            var response = await _meterReadingsService.AddMeterReadingAsync(addMeterReadingRequests);
            if (response.IsSuccess)
                return Ok(response);
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError, response);
        }

        [Authorize(Permissions.MeterReading.Manage)]
        [HttpPut(ApiRoutes.MeterReadings.UpdateMeterReading)]
        public async Task<IActionResult> UpdateMeterReadingAsync(IEnumerable<UpdateMeterReadingRequest> updateMeterReadingRequests)
        {
            var response = await _meterReadingsService.UpdateTwoSpecificFieldsForMeterReadingAsync(updateMeterReadingRequests);
            if (response.IsSuccess)
                return Ok(response);
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError, response);
        }

        [Authorize(Permissions.MeterReading.Create)]
        [HttpPost(ApiRoutes.MeterReadings.UploadMeterReadingImage)]
        public async Task<IActionResult> UploadMeterReadingImageAsync(List<IFormFile> photos, ImagePathRequest imagePath)
        {
            var response = await _meterReadingsService.UploadMeterReadingImageAsync(photos, imagePath);
            if (response.IsSuccess)
                return Ok(response);
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError, response);
        }
    
        [HttpGet(ApiRoutes.MeterReadings.ListOfMeterReadingStatus)]
        public async Task<IActionResult> ListOfMeterReadingStatusAsync() =>
            Ok(await _meterReadingsService.ListOfMeterReadingStatusAsync());

        [HttpPost(ApiRoutes.MeterReadings.UpdateMeterReadingValue)]
        public async Task<IActionResult> UpdateMeterReadingValueAsync(UpdateMeterReadingValueRequest model)
        {
            var response = await _meterReadingsService.UpdateMeterReadingValueAsync(model);
            if (response.IsSuccess)
                return Ok(response);
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError, response);
        }
    }
}