using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Request.Auth
{
    public class AuthResigterRequest
    {
        public int EmployeeId { get; set; }
        [MinLength(3),MaxLength(150)]
        public string UserName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [MinLength(11),MaxLength(11)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public int Company_Id { get; set; }
        [Required]
        public int UserType_Id { get; set; }
        public string[] AddingRoles { get; set; }
        public bool IsAndroid { get; set; }
        public long[] Branch_Ids { get; set; }
    }
}
