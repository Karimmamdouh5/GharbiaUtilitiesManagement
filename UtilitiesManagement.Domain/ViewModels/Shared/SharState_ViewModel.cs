using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.ViewModels.Shared
{
    public class SharState_ViewModel
    {
        public long StateId { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public bool IsUpdated { get; set; }
        public long Branch_Id { get; set; }
    }
}
