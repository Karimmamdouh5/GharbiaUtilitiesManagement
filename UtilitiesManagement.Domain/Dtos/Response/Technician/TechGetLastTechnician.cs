using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Response.Technician
{
    public class TechGetLastTechnician
    {
        public long EmployeeId { get; set; }
        public bool CanCollect { get; set; }
        public bool CanRead { get; set; }
        public bool CanComplain { get; set; }
        public bool CanEditCustomer { get; set; }
        public bool AttachImageRead { get; set; }
        public bool AttachImageEditCustomer { get; set; }
        public int MaxOfflineWorkingHours { get; set; }
        public int MaxOfflineWorkingBills { get; set; }
        public DateTime InsertDate { get; set ; } =  new DateTime().NowEg();
        public DateTime? UpdateDate { get; set; }
       // public DateTime? UpdateDate { get{return UpdateDate ; }  set{ IsActive == true ? UpdateDate : null ; } }
        public DateTime? DeleteDate { get; set; } = new DateTime().NowEg();
        public bool IsActive { get; set; } 
        
    }
}
