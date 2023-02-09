using UtilitiesManagement.Domain.ViewModels.Bills;

namespace UtilitiesManagement.Domain.Interfaces.Bill
{
    public interface IBillRepository : IBaseRepository<BillBillsData>
    {
        Task<IEnumerable<BillData_ViewModel>> Remote_GetBillData(long EmployeeId, string BlockIds);
        bool CommitAllBillChanges();
        Task<bool> PayBill(long CustomerId , string[] BillNumber , long[] BillIds, double[] BillAmount, long CollectorId , DateTime PayDate , long DeviceId);
    }
}
