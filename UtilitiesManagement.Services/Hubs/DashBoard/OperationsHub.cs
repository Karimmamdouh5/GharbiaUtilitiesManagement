using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace UtilitiesManagement.Services.Hubs.DashBoard
{
    [Authorize("DomainRestricted")]
    public class OperationsHub:Hub<GeneralInterfaces>
    {
    }
}
