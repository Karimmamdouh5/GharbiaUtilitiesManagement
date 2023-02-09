using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Response.Notification
{
    public class NotiUserModuleResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SelectListWithStringIdStringResponse> Users { get; set; }
    }
}
