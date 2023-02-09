using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Threading.Tasks;

namespace  UtilitiesManagement.Api.Filters
{
    public class PermissionAuthorizationHandler : AuthorizationHandler<PermissionRequirement>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public PermissionAuthorizationHandler(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement)
        {
            if (context.User == null)
                return;

            var CheckHubAuth = _httpContextAccessor!.HttpContext!.Request.Path == "/OperationsHub" && ! string.IsNullOrEmpty(_httpContextAccessor.HttpContext.Request.Headers.Authorization);
            if (CheckHubAuth)
            {
                context.Succeed(requirement);
                return;
            }

            var permission = requirement.Permission.Split('.');
            string AllClaimsPer = $"{permission[0]}.{permission[1]}.{permission[2]}.Full";

            var canAccess = context.User.Claims.Any(c => c.Type == "Permission" && (c.Value == requirement.Permission || c.Value == AllClaimsPer)/*&& c.Issuer == "LOCAL AUTHORITY"*/);
            
            if (canAccess)
            {
                context.Succeed(requirement);
                return;
            }
        }
    }
}