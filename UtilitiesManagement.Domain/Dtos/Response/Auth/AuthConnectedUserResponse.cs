namespace UtilitiesManagement.Domain.Dtos.Response.Auth
{
    public class AuthConnectedUserResponse
    {
        public string? UserId { get; set; }
        public string? AndroidId { get; set; }
        public string? JobId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }
        public string? InsertBy { get; set; }
        public string? UpdateBy { get; set; }
        public string? DeleteBy { get; set; }
        public int CompanyBranchId { get; set; }
    }
}
