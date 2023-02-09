namespace UtilitiesManagement.Domain.Dtos.Response.Shared
{
    public class GetCompanyResponse
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string CompanyName { get; set; }
        public string Activity { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string LogoPrint { get; set; }
        public string LogoWeb { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; } = true;
        public int MobileUsersCount { get; set; }
        public string CompanyServiceName { get; set; }
    }
}
