using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Request.HR
{
    public class HrListOfEmployeesRequest
    {
        public long? BranchId { get; set; }
        public long? areaId { get; set; }
        public long[]? blockIds { get; set; }
    }
}
