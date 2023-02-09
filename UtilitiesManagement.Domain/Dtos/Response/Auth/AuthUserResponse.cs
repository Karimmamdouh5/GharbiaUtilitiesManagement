namespace UtilitiesManagement.Domain.Dtos.Response.Auth
{
    public class AuthUserResponse
    {
        public bool IsActive { get; set; }
        public string? UserName { get; set; }
        public bool IsAndroid { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string? InsertBy { get; set; }
        public string? UpdateBy { get; set; }
        public string? DeleteBy { get; set; }
        public int? CompanyTenantId { get; set; }
    }
}
