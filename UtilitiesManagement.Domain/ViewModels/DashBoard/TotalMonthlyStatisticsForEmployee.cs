using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.ViewModels.DashBoard
{
    public class TotalMonthlyStatisticsForEmployee
    {
        public string GroupedDate { get; set; }
        public long ComplaintsCount { get; set; }
        public long MeterReadingsCount { get; set; }
        public long UpdatedCustomersCount { get; set; }
        public long BillsPaymentCount { get; set; }
    }
}
