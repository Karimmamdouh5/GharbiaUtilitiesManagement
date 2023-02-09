using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManagement.Domain.Models.Notification;

namespace UtilitiesManagement.Domain.Dtos.Request.Notification
{
    public class AddNotiMessageRequest
    {
        public string UserSender_Id { get; set; }
        public bool ReadOnly { get; set; }
        public string Title { get; set; } 
        public string Message { get; set; }
        public int? Module_Id { get; set; }
        public List<string>? UserIds { get; set; }
    }
}
