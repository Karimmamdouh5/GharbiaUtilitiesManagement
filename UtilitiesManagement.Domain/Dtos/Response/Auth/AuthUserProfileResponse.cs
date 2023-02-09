using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Response.Auth
{
    public class AuthUserProfileResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Job { get; set; }
      
        public string Code { get; set; }
        public int? UserTypeId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Section { get; set; }
        public bool IsActive { get; set; }
        public DateTime InsertDate { get; set; }
        public string UserType { get; set; }
        public bool OnlineOrNot { get; set; }
        public string ImagePath { get; set; }
        public List<string> Roles { get; set; }
        public long[] AssignBranchesIds { get; set; }
        public string AssignBranches { get; set; }
        public LastUserLogResponse UserLastLog { get; set; }
    }
}
