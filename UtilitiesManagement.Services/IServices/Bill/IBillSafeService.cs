using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Services.IServices.Bill
{
    public interface IBillSafeService
    {
        Task<Response<IEnumerable<SelectListResponse>>> GetAllBillSafesAsync();
        Task<Response<AddListRequest>> AddBillSafeAync(AddListRequest BillSafeAddListRequest);
        Task<Response<AddListRequest>> UpdateBillSafeAsync(int BillSafeId, AddListRequest UpdateBillSafeRequest);
        Task<Response<string>> DeleteBillSafeAsync(int BillSafeId);
    }
}
