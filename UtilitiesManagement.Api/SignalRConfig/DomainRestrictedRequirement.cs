using Microsoft.AspNetCore.SignalR;

namespace UtilitiesManagement.Api.SignalRConfig
{
    public class DomainRestrictedRequirement :
     AuthorizationHandler<DomainRestrictedRequirement, HubInvocationContext>,
     IAuthorizationRequirement
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
            DomainRestrictedRequirement requirement,
            HubInvocationContext resource)
        {
            if (true)
            {
                context.Succeed(requirement);

            }
            return Task.CompletedTask;
        }

        //private bool IsUserAllowedToDoThis(string hubMethodName,
        //    string currentUsername)
        //{
        //    return !(currentUsername.Equals("asdf42@microsoft.com") &&
        //        hubMethodName.Equals("banUser", StringComparison.OrdinalIgnoreCase));
        //}
    }
}
