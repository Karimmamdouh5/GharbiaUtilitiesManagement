using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Request.Notification
{
    public class AddFcmConfigRequest
    {
        public bool IsAndroid { get; set; }
        public string apiKey { get; set; }
        public string authDomain { get; set; }
        public string projectId { get; set; }
        public string storageBucket { get; set; }
        public string messagingSenderId { get; set; }
        public string appId { get; set; }
        public string measurementId { get; set; }
        public string ServerKey { get; set; }
        public string SenderId { get; set; }
        public string PublicKey { get; set; }
    }
}
