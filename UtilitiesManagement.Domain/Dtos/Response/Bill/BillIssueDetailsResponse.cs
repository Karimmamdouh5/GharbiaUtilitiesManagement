using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Response.Bill
{
    public class BillIssueDetailsResponse
    {
        public long IssueDetailsId { get; set; }
        public long IssueId { get; set; }
        public long BranchId { get; set; }
        public string IssueName { get; set; }
        public string BranchName { get; set; }
        public bool IssueStatus { get; set; }
        public bool IssueDetailsStatus { get; set; }
        public int BillStartNum { get; set; }
        public int BillEndNum { get; set; }
    }
}
