using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Request.Bill
{
    public class BillChangeReprintRequest
    {
        public int billPaymentId { get; set; }
        public string userId { get; set; }
    }
}
