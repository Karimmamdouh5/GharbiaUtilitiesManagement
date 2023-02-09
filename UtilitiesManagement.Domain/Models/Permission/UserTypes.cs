using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Models.Permission
{
    [Table("Perm_UserTypes")]
    public class UserTypes
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        public string Name { get; set; }
        public long CompanyId { get; set; }
        [ForeignKey(nameof(CompanyId))]
        public SharCompany Company { get; set; }
        public TimeSpan TimeOfToken { get; set; }
        public string SysName { get; set; }
    }
}
