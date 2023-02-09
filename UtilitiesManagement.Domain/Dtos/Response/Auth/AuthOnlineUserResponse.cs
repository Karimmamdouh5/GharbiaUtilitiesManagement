namespace UtilitiesManagement.Domain.Dtos.Response.Auth
{
    public class AuthOnlineUserResponse
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public long EmpId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string BranchName { get; set; }
        public string CompanyName { get; set; }
        public DateTime? StartDate { get; set; }
        public string EndDate { get; set; }
        public AuthRemainingTimeForUserResponse RemainingTime { get; set; }
        public string? JobId { get; set; }
        public string Mobile { get; set; }
        public bool? IsMobile { get; set; }
        public bool IsConnected { get; set; }  
    }
}
