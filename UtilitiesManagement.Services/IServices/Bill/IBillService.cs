namespace UtilitiesManagement.Services.IServices.Bill
{
    public interface IBillService
    {
        Task<Response<List<BillData_ViewModel>>> GetBillDataByEmployee(long EmployeeId,long[] BlockIds);
        Task<Response<BillDataResponseWithPaggination>> GetPaymentData(SearchParametersForBillsDataRequest searchParametersRequest);
        Task<Response<MemoryStream>> GetPaymentExcelFile(SearchParametersForBillsDataRequest searchParametersRequest);
        Task<Response<string>> PayBill(List<BillPaymentRequest> model);
        Task<Response<List<BillPaymentResponse>>> GetEmployeeBills(int EmployeeId);
        Task<Response<string>> AddPaymentsSafe(BillPaymentSafeRequest model);
        Task<Response<GetBillPaymentSafesResponse>> GetPaymentSafes(SearchParametersForBillPaymentSafesDataRequest model);
        Task<Response<string>> ChangeIsPosted(BillChangeIsPostedRequest model);
        Task<Response<BillPaymentResponse>> ChangeIsReprint(int billPaymentId , string userId);
        Task<Response<List<BillPaymentLogResponse>>> GetBillPaymentLogs(long EmployeeId);
        Task<Response<List<BillPaymentLogRequest>>> AddPaymentLog(BillPaymentLogRequest[] model);
        Task<Response<MemoryStream>> GetParentPaymentExcelFile(SearchParametersForBillsDataRequest searchParametersRequest);
    }
}
