using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Request.Technician
{
    public class AddTechnicianRequest
    {
        public int Id { get; set; }
        public int Employee_Id { get; set; }
        public bool IsActive { get; set; } = true;
        public bool CanCollect { get; set; }
        public bool CanRead { get; set; }
        public bool CanComplain { get; set; }
        public bool CanEditCustomer { get; set; }
        public bool AttachImageRead { get; set; }
        public bool AttachImageEditCustomer { get; set; }
        public int MaxOfflineWorkingHours { get; set; }
        public int MaxOfflineWorkingBills { get; set; }
    }
}
