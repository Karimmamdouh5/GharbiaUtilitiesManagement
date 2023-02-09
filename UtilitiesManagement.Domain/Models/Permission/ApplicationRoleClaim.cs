
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  UtilitiesManagement.Domain.Models.Permission
{
    public class ApplicationRoleClaim : IdentityRoleClaim<string>,IBaseEntity
    {
        public bool IsDeleted { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string? InsertBy { get; set; }
        public string? UpdateBy { get; set; }
        public string? DeleteBy { get; set; }
        public int? CompanyTenantId { get; set; }
        public string? HistoryDisc { get; set; }

        public virtual ApplicationRole Role { get; set; }
    }
}
