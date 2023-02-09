using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Models.HR
{
    [Table("Hr_Employees_Temp")]
    public class HrEmployee_Temp : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID")]
        public long Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeType { get; set; }
        public long BranchID { get; set; }
        public bool IsUpdated { get; set; }
    }
}
