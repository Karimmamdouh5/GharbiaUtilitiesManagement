using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Response.Auth
{
    public class LastUserLogResponse
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public AuthRemainingTimeForUserResponse RemainingTime { get; set; }
        public bool? IsMobile { get; set; }
        public bool IsConnected { get; set; }
    }
}
