using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.ViewModels.Customer
{
    public class PreviousReadingForCustomer_ViewModel
    {
        public long CustomerId { get; set; }
        public double PrevReading { get; set; }
        public string IssueName { get; set; }

    }
}
