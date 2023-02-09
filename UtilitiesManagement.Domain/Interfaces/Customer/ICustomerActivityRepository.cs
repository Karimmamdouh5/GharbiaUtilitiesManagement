namespace  UtilitiesManagement.Domain.Interfaces.Customer
{
    public interface ICustomerActivityRepository : IBaseRepository<CustCustomerActivity>
    {
        Task<IEnumerable<CustCustomerActivity_ViewModel>> GetRemoteCustomerActivityAsync();
        Task<bool> CommitAllRemoteCustomerActivityChangesAsync();
    }
}
