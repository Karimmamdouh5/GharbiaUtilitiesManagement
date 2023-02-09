using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Request.Notification
{
    public class AddNotiModuleRequest
    {
        public string Name { get; set; }
        public List<string>? UsersIds { get; set; }
    }
}
