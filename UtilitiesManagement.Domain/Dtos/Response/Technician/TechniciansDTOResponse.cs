using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Response.Technician
{
    public class TechniciansDTOResponse
    {
        public long Id { get; set; }
        public bool CanCollect { get; set; }
        public bool CanRead { get; set; }
        public bool CanComplain { get; set; }
        public bool CanEditCustomer { get; set; }
        public bool AttachImageRead { get; set; }
        public bool AttachImageEditCustomer { get; set; }
        public int MaxOfflineWorkingHours { get; set; }
        public int MaxOfflineWorkingBills { get; set; }
        public bool IsActive { get; set; } = false;
    } 
}
