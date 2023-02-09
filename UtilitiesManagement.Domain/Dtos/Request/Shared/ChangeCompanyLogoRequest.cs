using UtilitiesManagement.Domain.Constants.Permissions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Request.Shared
{
    public class ChangeCompanyLogoRequest
    {
        public int Company_Id { get; set; }
        public IFormFile CompanyLogo { get; set; }
       
    }

  
}
