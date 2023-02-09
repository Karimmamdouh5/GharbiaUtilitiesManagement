
using UtilitiesManagement.Domain.Dtos.Request.Auth;

namespace UtilitiesManagement.Domain.Dtos.Response.Auth
{
    public class AuthResponse
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public string? RefreshToken { get; set; }
        public string? JobId { get; set; }
        public string UserId { get; set; }
        public bool IsAuthenticated { get; set; }
        public List<string> Roles { get; set; }
        public DateTime ExpiresOn { get; set; }
        public long CompanyId{ get; set; }
        public long branchId { get; set; }
        public IEnumerable<string>? Errors { get; set; }
    }
    public class GetUserResponse
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string? RefreshToken { get; set; }
        public string? JobId { get; set; }
        public string UserId { get; set; }
        public bool IsAuthenticated { get; set; }
        public List<string> Roles { get; set; }
        public long CompanyId { get; set; }
        public long branchId { get; set; }
        public long? Technician_Id { get; set; }
        public bool appHasTutorial { get; set; }
        public string CompanyCode { get; set; }
        public string UserCode { get; set; }
         
        public TechGetLastTechnician? Technician{ get; set; }
        public string? ImgPath { get; set; }
        public long EmployeeId { get; set; }
        public List<PermMenuNodeObject> Menu { get; set; }

    }
}
