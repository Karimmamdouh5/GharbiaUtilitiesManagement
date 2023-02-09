using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  UtilitiesManagement.Domain.Dtos
{
    public class TreeObject
    {
        public string PermissionItem { get; set; }
        public int RoleClaimsId { get; set; }
        public bool RoleClaimsSelectedFlag { get; set; }
    }
}
