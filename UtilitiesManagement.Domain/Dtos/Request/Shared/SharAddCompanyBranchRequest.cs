using System.ComponentModel;

namespace UtilitiesManagement.Domain.Dtos.Request.Shared
{
    public class SharAddCompanyBranchRequest
    {
        public int Id { get; set; }

        [Display(Name = "BranchName"), Required(ErrorMessage = "The {0} is required"), MinLength(3, ErrorMessage = "The {0} field length must be grater than or equal {1}."), MaxLength(100, ErrorMessage = "The {0} field length must be less than or equal {1}.")]
        public string BranchName { get; set; }
        public int? IntegrationId { get; set; }

        [Display(Name = "Address"), Required(ErrorMessage = "The {0} is required"), MinLength(3, ErrorMessage = "The {0} field length must be grater than or equal {1}."), MaxLength(100, ErrorMessage = "The {0} field length must be less than or equal {1}.")]
        public string BranchAddress { get; set; }

        [DefaultValue(true)]
        public bool IsActive { get; set; }
        public bool IsMain { get; set; }

        public bool IsUseStock { get; set; }

        [Display(Name = "PhoneNumber"), Required(ErrorMessage = "The {0} is required"), MinLength(3, ErrorMessage = "The {0} field length must be grater than or equal {1}."), MaxLength(20, ErrorMessage = "The {0} field length must be less than or equal {1}.")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "The {0} format is not valid.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "EmailAddress")]
        [StringLength(250, ErrorMessage = "The {0} field length can not more than {1}.")]
        [EmailAddress(ErrorMessage = "The {0} format is not valid.")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "The {0} format is not valid.")]
        public string Email { get; set; }

        [DefaultValue(false)]
        public bool LockTechnicalsLogins { get; set; }
        public int Region_Id { get; set; }
        public int? BranchManager_Id { get; set; }
        public int Company_Id { get; set; }
    }
}
