namespace UtilitiesManagement.Domain.Dtos.Response.Auth
{
    public class AuthCountOnlineUsersResponse
    {
        public long CompanyId { get; set; }
        public int CountOnlineUsers { get; set; }
        public string CompanyName { get; set; }
    }
}
