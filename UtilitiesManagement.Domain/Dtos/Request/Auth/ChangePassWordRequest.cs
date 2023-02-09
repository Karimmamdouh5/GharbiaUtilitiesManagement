using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Request.Auth
{
    public class ChangePassWordRequest
    {
        public string User_Id { get; set; }
        public string OldPassWord { get; set; }
        public string NewPassWord { get; set; }
        public string ConfirmNewPassWord { get; set; }
    }
}
