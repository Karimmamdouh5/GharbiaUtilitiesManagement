using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Models.Notification
{
    [Table("Noti_UserModule")]
    public class NotiUserModule:BaseEntity
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        public int? Module_Id { get; set; }
        [ForeignKey(nameof(Module_Id))]
        public NotiModules? Module { get; set; }
        public string? User_Id { get; set; }
        [ForeignKey(nameof(User_Id))]
        public ApplicationUser? User { get; set; }
    }
}
