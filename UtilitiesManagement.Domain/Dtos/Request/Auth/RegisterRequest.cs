namespace UtilitiesManagement.Domain.Dtos.Request.Auth
{
    public  class RegisterRequest
    {
        [EmailAddress]        
        [Required]
        public string Email { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
        [Required]
        public int UserType_Id { get; set; }
        public bool IsAndroid { get; set; }
    }
}
