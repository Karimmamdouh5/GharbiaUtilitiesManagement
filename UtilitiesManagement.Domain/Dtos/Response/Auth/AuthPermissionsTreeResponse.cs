using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Response.Auth
{
    public class AuthPermissionsTreeResponse
    {
        public string Name { get; set; }
        public string Name_Ar { get; set; }
        public int Id { get; set; }
        public bool IsSelected { get; set; }
        public List<AuthPermissionsTreeResponse>? Children { get; set; } = new List<AuthPermissionsTreeResponse>();
    }
}
