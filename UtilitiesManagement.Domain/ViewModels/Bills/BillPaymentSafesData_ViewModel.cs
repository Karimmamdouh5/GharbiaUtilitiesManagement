using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManagement.Domain.Dtos.Response.Operation;

namespace UtilitiesManagement.Domain.ViewModels.Bills
{

    public class GetBillPaymentSafesResponse
    {
        public IEnumerable<BillPaymentSafesData> Data { get; set; }
        public int TotalRecords { get; set; } = 0;
    }

    public class BillPaymentSafesData
    {
        public long PaymentSafeId { get; set; }
        public string SafeName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string EmployeeName { get; set; }
        public double TotalAmount { get; set; }
    }
}
