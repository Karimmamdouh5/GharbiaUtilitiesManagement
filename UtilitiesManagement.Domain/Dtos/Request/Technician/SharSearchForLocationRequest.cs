using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Request.Technician
{
    public class SharSearchForLocationRequest
    {
        public int? EmployeeId { get; set; }

        //[Required]
        //public int CompanyBranchId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
