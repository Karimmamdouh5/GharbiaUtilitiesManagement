using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManagement.Domain.Dtos.Request.Operation;

namespace UtilitiesManagement.Domain.Dtos.Response.Operation
{
    public class AddUpdatedCustomerResponse: AddUpdatedCustomerRequest
    {
        public string? SysName { get; set; }
    }
}
