using System;
using System.Collections.Generic;
using System.Linq;
namespace UtilitiesManagement.Domain.Dtos.Request.Auth
{
    public class LogoutRequest
    {
        public string UserId { get; set; }
        public string JobId { get; set; }
    }
}
