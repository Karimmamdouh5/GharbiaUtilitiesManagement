using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Request.Customer
{
    public class UpdateCustomerDataRequest
    {
        public long Customer_Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerActivity { get; set; }
        public int CustomerActivity_fk { get; set; }
    }
}
