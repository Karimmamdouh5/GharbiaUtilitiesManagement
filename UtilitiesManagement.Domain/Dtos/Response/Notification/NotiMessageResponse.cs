using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Response.Notification
{
    public class NotiMessageResponse
    {
        public string UserSender_Id { get; set; }
        public bool ReadOnly { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string? UserId { get; set; }
    }
    public class NotiMessageResponseWithNames: NotiMessageResponse
    {
        public string From { get; set; }
        public string To { get; set; }
    }
}
