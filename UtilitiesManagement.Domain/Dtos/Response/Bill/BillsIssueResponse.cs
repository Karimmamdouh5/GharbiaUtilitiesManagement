using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Response.Bill
{
    public class BillsIssueResponse
    {
        public long Id { get; set; }
        public string IssueName { get; set; }
        public bool IssueState { get; set; }
        public DateTime IssueDate { get; set; }
    }
}
