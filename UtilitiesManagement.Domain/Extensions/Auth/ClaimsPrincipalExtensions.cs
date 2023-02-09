using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace  UtilitiesManagement.Domain.Extensions.Auth
{
    public static class ClaimsPrincipalExtensions
    {
        public static int? GetCompanyId(this ClaimsPrincipal principal)
        {
            string Company = principal.FindFirstValue("companyid") ?? "";
            int i;
            if (int.TryParse(Company, out i)) return i;
            return null;
           
        } 
        public static string GetUserId(this ClaimsPrincipal principal)
        {
            return principal.FindFirstValue("uid");
         
        }
    }
}
