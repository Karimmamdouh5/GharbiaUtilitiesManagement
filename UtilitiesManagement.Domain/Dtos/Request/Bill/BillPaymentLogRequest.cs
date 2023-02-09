using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Request.Bill
{
    public class BillPaymentLogRequest
    {
        public long Customer_Id { get; set; }
        public DateTime PayDate { get; set; }
        public long Employee_Id { get; set; }
        public List<PayDataLogDetailsRequest> PayDataLogDetails { get; set; }
    }
    public class PayDataLogDetailsRequest
    {
        public long Bill_Id { get; set; }
        public double Amount { get; set; }
    }
}
