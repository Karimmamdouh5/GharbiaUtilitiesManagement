using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Request.Auth
{
    public class UpdateUserRequest
    {
        public string User_Id { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int? UserType_Id { get; set; }
        public long[] Branches_Ids { get; set; }
    }
}
