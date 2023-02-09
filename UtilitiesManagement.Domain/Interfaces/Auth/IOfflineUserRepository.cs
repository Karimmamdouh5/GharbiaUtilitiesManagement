namespace  UtilitiesManagement.Domain.Interfaces.Auth
{
    public interface IOnlineUserRepository : IBaseRepository<PermOnlineUser>
    {
        Task<IEnumerable<AuthCountOnlineUsersResponse>> GetNumOfOnlineUsersAsync(int? companyId);
        //Task<List<AuthOnlineUserResponse>> GetUsersAsync(bool? connectionStatus = null, int? companyId = null);
    }
}
