using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Response.Customer
{
    public class CustomerBillStatistics : totalBillsOfCollector
    {
        public int collectionAmount { get; set; } = 0;
    }
}
