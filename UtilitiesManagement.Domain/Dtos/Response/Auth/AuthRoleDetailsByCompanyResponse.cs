using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Response.Auth
{

    public class AuthRoleDetailsByCompanyResponse
    {
        public int CompanyId { get; set; }
        public List<RoleDetails> Roles { get; set; }
    }
    public class RoleDetails
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public int UsersCount { get; set; }
        public List<String> Claims { get; set; }
        public List<AuthUserProfileResponse> Users { get; set; }
        public DateTime CreationDateTime { get; set; }
    }
}
