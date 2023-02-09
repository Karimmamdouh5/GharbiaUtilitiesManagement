namespace  UtilitiesManagement.Domain.Interfaces.Customer
{
    public interface ICustomerStatusRepository : IBaseRepository<CustCustomerStatus>
    {
        Task<IEnumerable<CustCustomerStatus_ViewModel>> GetRemoteCustomerStatusAsync(long maxlength, bool isUpdated);
        Task<bool> CommitAllRemoteCustomerStatusChangesAsync();
    }
}
