using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Models.Permission
{
    [Table("Perm_UserBranches")]
    public class ApplicationUserBranches : BaseEntity
    {
        [Column("ID")]
        [Key]
        public int Id { get; set; }
        public string User_Id { get; set; }
        [ForeignKey(nameof(User_Id))]
        public ApplicationUser User { get; set; }
        public long Branch_Id { get; set; }
        [ForeignKey(nameof(Branch_Id))]
        public SharBranch Branch { get; set; }
    }
}
