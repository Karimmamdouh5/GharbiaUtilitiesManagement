using UtilitiesManagement.Domain.Dtos.Request.DashBoard;

namespace  UtilitiesManagement.Domain.Interfaces.Customer
{
    public interface ICustomerDataRepository : IBaseRepository<CustCustomerData>
    {
        Task<IEnumerable<CustCustomerData_ViewModel>> GetRemoteCustomerDataAsync(long LastId);
        Task<bool> CommitAllRemoteCustomerDataChanges();
        Task<IEnumerable<GetCustomersTotalBills_ViewModel>> GetCustomersTotalBillsAsync(long Collector_Id, string BlockIds);
        Task<IEnumerable<totalBillsOfCollector>> GetRemoteCustomerBillsCount(DashBoardCustomerBillsStatRequest model);
        Task<bool> UpdateCustomer(long Customer_Id , string CustomerName , string CustomerActivity);
    }
}
