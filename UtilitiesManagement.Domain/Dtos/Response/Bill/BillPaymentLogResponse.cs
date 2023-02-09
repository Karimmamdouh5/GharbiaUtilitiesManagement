using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManagement.Domain.Dtos.Request.Bill;

namespace UtilitiesManagement.Domain.Dtos.Response.Bill
{
    public class BillPaymentLogResponse : BillPaymentLogRequest
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string EmployeeName { get; set; }
    }
}
