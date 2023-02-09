using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManagement.Domain.Dtos.Request.Bill;

namespace UtilitiesManagement.Domain.Dtos.Response.Bill
{
    public class BillPaymentResponse : BillPaymentRequest
    {
        public string CollectorName { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public long BranchId { get; set; }
        public long AreaId { get; set; } 
        public long BlockId { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public string BranchName { get; set; }
        public string AreaName { get; set; }
        public string BlockName { get; set; }
        public bool IsRePrint { get; set; }
    }
}
