namespace UtilitiesManagement.Api.Areas.Operation.Controllers
{
    [Area(Modules.Customer)]
    [ApiController]
    [ApiExplorerSettings(GroupName = Modules.Customer)]
    public class CustomerDataController : ControllerBase
    {
        private readonly ICustomerDataService _customerDataService;

        public CustomerDataController(ICustomerDataService customerDataService) =>
            _customerDataService = customerDataService;

        [HttpGet(ApiRoutes.CustomerData.GetAllCustomerData)]
        [Authorize(Permissions.Customer.View)]
        public async Task<IActionResult> GetAllCustomerDataAsync([FromQuery] SearchParametersForCustomerDataRequest searchParametersForCustomerDataRequest) =>
            Ok(await _customerDataService.GetAllCustomerDataAsync(searchParametersForCustomerDataRequest));

        [HttpGet(ApiRoutes.CustomerData.GetAllCustomerDataByCollector)]
        [Authorize(Permissions.Customer.View)]
        public async Task<IActionResult> GetAllCustomerDataByCollectorAsync(long collectorId, [FromQuery] long[] BlockIds) =>
            Ok(await _customerDataService.GetAllCustomerDataByCollectorAsync(collectorId, BlockIds));

        [HttpGet(ApiRoutes.CustomerData.GetCustomerDataProfile)]
        [Authorize(Permissions.Customer.View)]
        public async Task<IActionResult> GetCustomerDataProfileAsync([FromQuery] FilterForCustomerProfileRequest filterForCustomerProfileRequest) =>
            Ok(await _customerDataService.GetCustomerDataProfileAsync(filterForCustomerProfileRequest));

        [HttpGet(ApiRoutes.CustomerData.ListOfCustomer)]
        public async Task<IActionResult> ListOfCustomerAsync([FromQuery] FilterWithTwoFlagsCustomerRequest filterWithTwoFlagsCustomerRequest) =>
            Ok(await _customerDataService.ListOfCustomer(filterWithTwoFlagsCustomerRequest));

        [HttpPut(ApiRoutes.CustomerData.ChangeActiveOrNot)]
        [Authorize(Permissions.Customer.Manage)]
        public async Task<IActionResult> UpdateActivateOrDeactivateForCompletedDataAsync(int customerDataId)
        {
            var response = await _customerDataService.ActiveOrDeActiveForCompletedDataAsync(customerDataId);
            if (response.IsSuccess)
                return Ok(response);
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError, response);
        }


        [HttpGet(ApiRoutes.CustomerData.ListOfCustomerActivities)]
        public async Task<IActionResult> ListOfCustomerActivitiesAsync() =>
            Ok(await _customerDataService.ListOfCustomerActivitesAsync());
    }
}
