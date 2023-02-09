using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Request.Notification
{
    public class MessageFcm
    {
        public string[] registration_ids { get; set; }
        public notificationFcm notification { get; set; }
    }
    public class notificationFcm
    {
        public string body { get; set; }
        public string title { get; set; }
    }
}
