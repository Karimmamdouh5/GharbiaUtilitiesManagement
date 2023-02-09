using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Request.Notification
{
    public class UpdateFcmConfigRequest: AddFcmConfigRequest
    {
        public int Id { get; set; }
    }
}
