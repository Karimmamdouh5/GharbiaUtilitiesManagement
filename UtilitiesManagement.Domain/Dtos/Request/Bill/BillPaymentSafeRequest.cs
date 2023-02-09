using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Request.Bill
{
    public class BillPaymentSafeRequest
    {
        public int SafeId { get; set; }
        public double Total { get; set; }
        public long EmployeeId { get; set; }
        public List<long> paymentIds { get; set; }

    }
}
