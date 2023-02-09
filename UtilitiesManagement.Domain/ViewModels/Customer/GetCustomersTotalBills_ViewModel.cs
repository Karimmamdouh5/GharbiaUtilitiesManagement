using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.ViewModels.Customer
{
    public class GetCustomersTotalBills_ViewModel
    {
        public long CustomerID { get; set; }
        public double BillsTotalAmount { get; set; }
        public int BillsCounts { get; set; }
    }
}
