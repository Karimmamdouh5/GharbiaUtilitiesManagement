namespace UtilitiesManagement.Api.Areas.Shared.Controllers
{
    [Area(Modules.Shared)]
    [ApiController]
    [ApiExplorerSettings(GroupName = Modules.Shared)]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companiesService;

        public CompanyController(ICompanyService companiesService) =>
            _companiesService = companiesService;

        [HttpGet(ApiRoutes.Companies.GetAllCompanies)]
        public async Task<IActionResult> GetAllCompaniesAsync() =>
            Ok(await _companiesService.GetAllCompaniesAsync());

        [HttpGet(ApiRoutes.Companies.ListOfCompanies)]
        public async Task<IActionResult> ListOfCompaniesAsync() =>
            Ok(await _companiesService.ListOfCompaniesAsync());

        [HttpGet(ApiRoutes.Companies.GetCompanyProfile)]
        public async Task<IActionResult> GetCompanyProfileAsync(int companyId) =>
            Ok(await _companiesService.GetCompanyProfileAsync(companyId));
        [AllowAnonymous]
        [HttpPost(ApiRoutes.Companies.CreateCompany)]
        public async Task<IActionResult> CreateCompanyAsync([FromForm] AddCompanyRequest addCompanyRequest)
        {
            var response = await _companiesService.AddCompanyAsync(addCompanyRequest);
            if (response.IsSuccess)
                return Ok(response);
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError, response);
        }

        [HttpPut(ApiRoutes.Companies.UpdateCompany)]
        public async Task<IActionResult> UpdateCompanyAsync(int companyId, UpdateCompanyRequest updateCompanyRequest)
        {
            var response = await _companiesService.UpdateCompanyAsync(companyId, updateCompanyRequest);
            if (response.IsSuccess)
                return Ok(response);
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError, response);
        }

        [HttpDelete(ApiRoutes.Companies.DeleteCompany)]
        public async Task<IActionResult> DeleteCompanyAsync(int companyId)
        {
            var response = await _companiesService.DeleteCompanyAsync(companyId);
            if (response.IsSuccess)
                return Ok(response);
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError, response);
        }

        [HttpPost(ApiRoutes.Companies.ChangeLogoWeb)]
        public async Task<IActionResult> ChangeLogoWeb([FromForm] ChangeCompanyLogoRequest changeCompanyLogoRequest)
        {
            var response = await _companiesService.ChangeLogoCompanyAsync(changeCompanyLogoRequest, true);
            if (response.IsSuccess)
                return Ok(response);
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError, response);
        }

        [HttpPost(ApiRoutes.Companies.ChangeLogoPrint)]
        public async Task<IActionResult> ChangeLogoPrint([FromForm] ChangeCompanyLogoRequest changeCompanyLogoRequest)
        {
            var response = await _companiesService.ChangeLogoCompanyAsync(changeCompanyLogoRequest, false);
            if (response.IsSuccess)
                return Ok(response);
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError, response);
        }

        [HttpPut(ApiRoutes.Companies.ActiveOrNot)]
        public async Task<IActionResult> CheckActiveOrNotAsync(int companyId)
        {
            var response = await _companiesService.ActiveOrNotAsync(companyId);
            if (response.IsSuccess)
                return Ok(response);
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError, response);
        }
    
  }
}
