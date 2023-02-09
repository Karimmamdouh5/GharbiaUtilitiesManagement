namespace UtilitiesManagement.Api.Areas.Operation.Controllers
{
    [Area(Modules.Customer)]
    [ApiController]
    [ApiExplorerSettings(GroupName = Modules.Customer)]
    public class ManageCustomersRemotelyController : ControllerBase
    {
        private readonly ICustomerDataService _customerDataService;

        public ManageCustomersRemotelyController(ICustomerDataService customerDataService) =>
            _customerDataService = customerDataService;

        [HttpPost(ApiRoutes.CustomerData.ManageRemoteCustomers)]
        [Authorize(Permissions.Customer.Manage)]
        public async Task<IActionResult> ManageRemoteCustomersAsync() =>
            Ok(await _customerDataService.ManageRemoteCustomersAsync());
    }
}
