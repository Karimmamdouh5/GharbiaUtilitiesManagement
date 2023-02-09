using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.ViewModels.Bills
{
    public class BillIssue_ViewModel
    {
        public long isu_id { get; set; }
        public DateTime isu_Date { get; set; }
        public string isu_IsDate { get; set; }
        public string def_desc { get; set; }
        public string isu_status { get; set; }
    }
}
