using Microsoft.AspNetCore.Mvc;
using UtilitiesManagement.Services.IServices.Bill;

namespace UtilitiesManagement.Api.Areas.Bills
{
    [Area(Modules.Bill)]
    [ApiController]
    [ApiExplorerSettings(GroupName = Modules.Bill)]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class IssueController : ControllerBase
    {
        private readonly IIssueService _issueService;
        public IssueController(IIssueService IssueService)
        {
            _issueService = IssueService;
        }
        [HttpGet(ApiRoutes.Bills.GetIssues)]
        [Authorize(Permissions.Issues.View)]
        public async Task<IActionResult> GetIssues(bool all)
        {
            var Data = await _issueService.ListOfIssues(all);
            if (!Data.IsSuccess)
                return StatusCode(500, Data);
            return Ok(Data);
        }
        [HttpGet(ApiRoutes.Bills.GetIssuesDetails)]
        [Authorize(Permissions.Issues.View)]
        public async Task<IActionResult> GetIssuesDetails(bool all,long? branchId,long? issueId)
        {
            var Data = await _issueService.ListOfIssuessDetails(all, branchId, issueId);
            if (!Data.IsSuccess)
                return StatusCode(500, Data);
            return Ok(Data);
        }
        [HttpPost(ApiRoutes.Bills.ManageIssue)]
        [Authorize(Permissions.Issues.Manage)]
        public async Task<IActionResult> ManageIssue()
        {
            var Data = await _issueService.ManageIssueData();
            if (!Data.IsSuccess)
                return StatusCode(500, Data);
            return Ok(Data);
        }
    }
}
