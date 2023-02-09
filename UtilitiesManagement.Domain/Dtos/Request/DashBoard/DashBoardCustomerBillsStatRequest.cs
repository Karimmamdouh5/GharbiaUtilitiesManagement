using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Request.DashBoard
{
    public class DashBoardCustomerBillsStatRequest
    {
        public int? Collector_Id { get; set; }
        [Required]
        public int Branch_Id { get; set; }
        public string? IssueDate { get; set; }
    }
}
