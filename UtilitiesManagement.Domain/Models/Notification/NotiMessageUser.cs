using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Models.Notification 
{
    [Table("Noti_MessageUser")]
    public class NotiMessageUser : BaseEntity
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        public string User_Id { get; set; }
        [ForeignKey(nameof(User_Id))]
        public ApplicationUser User { get; set; }
        public int Message_Id { get; set; }
        [ForeignKey(nameof(Message_Id))]
        public NotiMessage Message { get; set; }
    }
}
