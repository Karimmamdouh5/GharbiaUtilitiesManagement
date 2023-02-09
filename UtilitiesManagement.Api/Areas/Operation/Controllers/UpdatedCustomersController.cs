namespace UtilitiesManagement.Api.Areas.Operation.Controllers
{
    [Area(Modules.Operation)]
    [ApiController]
    [ApiExplorerSettings(GroupName = Modules.Operation)]
    public class UpdatedCustomersController : ControllerBase
    {
        private readonly IUpdatedCustomersService _updatedCustomersService;

        public UpdatedCustomersController(IUpdatedCustomersService updatedCustomersService) =>
            _updatedCustomersService = updatedCustomersService;

        [Authorize(Permissions.Customer.View)]
        [HttpGet(ApiRoutes.UpdatedCustomers.GetAllUpdatedCustomers)]
        public async Task<IActionResult> GetAllUpdatedCustomersAsync([FromQuery] SearchParametersRequest searchParametersRequest) =>
            Ok(await _updatedCustomersService.GetAllUpdatedCustomersAsync(searchParametersRequest));

        [Authorize(Permissions.Customer.Create)]
        [HttpPost(ApiRoutes.UpdatedCustomers.CreateUpdatedCustomer)]
        public async Task<IActionResult> CreateUpdatedCustomerAsync(IEnumerable<AddUpdatedCustomerRequest> addUpdatedCustomerRequests)
        {
            var response = await _updatedCustomersService.AddUpdatedCustomerAsync(addUpdatedCustomerRequests);
            if (response.IsSuccess)
                return Ok(response);
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError, response);
        }

        [Authorize(Permissions.Customer.Manage)]
        [HttpPut(ApiRoutes.UpdatedCustomers.UpdateEditingCustomer)]
        public async Task<IActionResult> UpdateEditingCustomerAsync(IEnumerable<UpdateUpdatedCustomerRequest> updateUpdatedCustomerRequests)
        {
            var response = await _updatedCustomersService.UpdateSpecificFieldForUpdatedCustomerAsync(updateUpdatedCustomerRequests);
            if (response.IsSuccess)
                return Ok(response);
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError, response);
        }

        [HttpPost(ApiRoutes.UpdatedCustomers.UploadUpdatedCustomerImages)]
        [Authorize(Permissions.Customer.Create)]
        public async Task<IActionResult> UploadUpdatedCustomerImagesAsync(List<IFormFile> photos, ImagePathRequest imagePath)
        {
            var response = await _updatedCustomersService.UploadUpdatedCustomerImagesAsync(photos, imagePath);
            if (response.IsSuccess)
                return Ok(response);
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError, response);
        }

        [HttpGet(ApiRoutes.UpdatedCustomers.ListOfUpdatedCustomerTypes)]
        public async Task<IActionResult> ListOfUpdatedCustomerTypesAsync() =>
            Ok(await _updatedCustomersService.ListOfUpdatedCustomerTypeAsync());
    }
}
