using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.ViewModels.Bills
{
    public class BillIssueDetails_ViewModel
    {
        public long isu_Details_id { get; set; }
        public long BranchID { get; set; } // Not Exist
        public long isu_id { get; set; }    //
        public string BranchName { get; set; }
        public string isu_IsDate { get; set; }
        public string isu_details_status { get; set; }
        public long def_id { get; set; }
        public bool CanPostReading { get; set; }
        public int InvoicesStartNo { get; set; }
        public int InvoicesEndNo { get; set; }
    }
}
