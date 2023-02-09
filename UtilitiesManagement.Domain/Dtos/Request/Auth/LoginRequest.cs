namespace UtilitiesManagement.Domain.Dtos.Request.Auth
{
    public class LoginRequest
    {
        [Display(Name = "UserName"), Required(ErrorMessage = "The {0} is required")]    
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Password"), Required(ErrorMessage = "The {0} is required")]
        public string Password { get; set; }
        public string? AndroidId { get; set; }
        public string CompanyCode { get; set; }
        public string? UserToken { get; set; }
    }
}
