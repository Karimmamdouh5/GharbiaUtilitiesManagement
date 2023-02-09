
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Response.Auth
{
    public class PermissionsByRoleResponse
    {
        public string RoleId { get; set; }
        public List<CheckBox> RoleCalims { get; set; }
    }
    public class PermissionsTreeByRoleResponse
    {
        public string RoleId { get; set; } 
        public string RoleName { get; set; }
        public List<AuthPermissionsTreeResponse> RoleTree { get; set; }
    }
    public class PermissionsTreeByCompanyResponse
    {
        public int CompanyId { get; set; }
        public List<AuthPermissionsTreeResponse> RoleTree { get; set; }
    }
    public class RolesByUserIdResponse
    {
        public string UserId { get; set; }
        public List<CheckBox_WithIdString> UserRoles { get; set; }
    }
}
