using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Request.Auth
{
    public class AuthAddPermMenuRequest
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public long? ParentId { get; set; } = null;
        public bool? IsLast { get; set; }
        public string? Route { get; set; }
        public string? Permission { get; set; }
        public string? Icon { get; set; }
        public int? OrderBy { get; set; }
    }
}
