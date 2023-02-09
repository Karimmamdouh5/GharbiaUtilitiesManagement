namespace UtilitiesManagement.Domain.Dtos.Request.Shared
{
    public class UpdateCompanyRequest
    {  
        public int Id { get; set; }

        [Display(Name = "CompanyName"), Required(ErrorMessage = "The {0} is required"), MinLength(3, ErrorMessage = "The {0} field length must be grater than or equal {1}."), MaxLength(100, ErrorMessage = "The {0} field length must be less than or equal {1}.")]
        public string CompanyName { get; set; }

        [Display(Name = "Code"), Required(ErrorMessage = "The {0} is required"), MinLength(3, ErrorMessage = "The {0} field length must be grater than or equal {1}."), MaxLength(50, ErrorMessage = "The {0} field length must be less than or equal {1}.")]
        public string CompanyCode { get; set; }

        [Display(Name = "Activity"), Required(ErrorMessage = "The {0} is required"), MinLength(3, ErrorMessage = "The {0} field length must be grater than or equal {1}."), MaxLength(100, ErrorMessage = "The {0} field length must be less than or equal {1}.")]
        public string Activity { get; set; }

        [Display(Name = "Address"), Required(ErrorMessage = "The {0} is required"), MinLength(3, ErrorMessage = "The {0} field length must be grater than or equal {1}."), MaxLength(100, ErrorMessage = "The {0} field length must be less than or equal {1}.")]
        public string Address { get; set; }

        [Display(Name = "PhoneNumber"), Required(ErrorMessage = "The {0} is required"), MinLength(3, ErrorMessage = "The {0} field length must be grater than or equal {1}."), MaxLength(20, ErrorMessage = "The {0} field length must be less than or equal {1}.")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "The {0} format is not valid.")]
        public string PhoneNumber { get; set; }

        public bool IsActive { get; set; } = true;   
    } 
}
