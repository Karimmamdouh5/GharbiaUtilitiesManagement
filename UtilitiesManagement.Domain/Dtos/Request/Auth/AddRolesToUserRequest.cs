using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Request.Auth
{
    public class AddRolesToUserRequest
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string[]? Roles { get; set; }
    }
    public class ListRolesForUser
    {
        public string UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
