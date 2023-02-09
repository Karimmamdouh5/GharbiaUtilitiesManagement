using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.ViewModels.Customer
{
    public class totalBillsOfCollector
    {
        public int collectorId { get; set; }
        public int sumBillAmount { get; set; }
        public int issueId { get; set; }
        public string isu_IsDate { get; set; }
        public string collectorName { get; set; }
    }
}
