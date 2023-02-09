using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Response.Auth
{
    public class AuthUserRegisterResponse
    {
        public string id { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
    }
}
