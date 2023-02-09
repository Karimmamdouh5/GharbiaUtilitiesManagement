using UtilitiesManagement.Domain.Constants.Permissions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Request.Shared
{
    public class AddCompanyRequest
    {
     
        public long Id { get; set; }

        [Display(Name = "Code"), Required(ErrorMessage = "The {0} is required"), MinLength(3, ErrorMessage = "The {0} field length must be grater than or equal {1}."), MaxLength(50, ErrorMessage = "The {0} field length must be less than or equal {1}.")]
        public string CompanyCode { get; set; }

        [Display(Name = "CompanyName"), Required(ErrorMessage = "The {0} is required"), MinLength(3, ErrorMessage = "The {0} field length must be grater than or equal {1}."), MaxLength(100, ErrorMessage = "The {0} field length must be less than or equal {1}.")]
        public string CompanyName { get; set; }
        [Display(Name = "Activity"), Required(ErrorMessage = "The {0} is required"), MinLength(3, ErrorMessage = "The {0} field length must be grater than or equal {1}."), MaxLength(100, ErrorMessage = "The {0} field length must be less than or equal {1}.")]
        public string Activity { get; set; }
        [Display(Name = "Address"), Required(ErrorMessage = "The {0} is required"), MinLength(3, ErrorMessage = "The {0} field length must be grater than or equal {1}."), MaxLength(100, ErrorMessage = "The {0} field length must be less than or equal {1}.")]
        public string Address { get; set; }
        [Display(Name = "PhoneNumber"), Required(ErrorMessage = "The {0} is required"), MinLength(3, ErrorMessage = "The {0} field length must be grater than or equal {1}."), MaxLength(11, ErrorMessage = "The {0} field length must be less than or equal {1}.")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "The {0} format is not valid.")]
        public string PhoneNumber { get; set; }
        public IFormFile LogoPrintPhoto { get; set; }
        public IFormFile LogoWebPhoto { get; set; }

       
        public bool IsActive { get; set; } = true;

        [Display(Name = "Technician User Number"), Required(ErrorMessage = "The {0} is required")]
        public int MobileUsersCount { get; set; }

        [Display(Name = "ManagerName"), Required(ErrorMessage = "The {0} is required"), MinLength(3, ErrorMessage = "The {0} field length must be grater than or equal {1}."), MaxLength(100, ErrorMessage = "The {0} field length must be less than or equal {1}.")]
        public string ManagerName { get; set; } 
        [Display(Name = "Job"), Required(ErrorMessage = "The {0} is required"), MinLength(3, ErrorMessage = "The {0} field length must be grater than or equal {1}."), MaxLength(50, ErrorMessage = "The {0} field length must be less than or equal {1}.")]
        public string Job { get; set; }
        public string RoleName { get; set; } = Roles.Admin.ToString();
        [IgnoreDataMember]
        public bool Is_SuperAdmin { get; set; } = false;

        public string CompanyServiceName { get; set; }


    }


}
