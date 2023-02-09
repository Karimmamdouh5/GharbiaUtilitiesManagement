using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Request.Auth
{
    public class AddNewRollRequest
    {
        public int CompanyId { get; set; }
        public string RoleName { get; set; }
    }
}
