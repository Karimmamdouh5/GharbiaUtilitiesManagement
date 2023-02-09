using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.ViewModels.HR 
{
    public class HrEmployeeBlocks_ViewModel
    {
        public long Id { get; set; }
        public long CollectorID { get; set; }
        public string CollectorCode { get; set; }
        public string BlockCode { get; set; }
        public long BlockID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool CollectorBlockIsUpdated { get; set; }
        public bool IsReader { get; set; }
    }
}
