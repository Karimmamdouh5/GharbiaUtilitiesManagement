using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Models.Notification
{
    [Table("Noti_Message")]
    public class NotiMessage:BaseEntity
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        public string UserSender_Id { get; set; }
        [ForeignKey(nameof(UserSender_Id))]
        public ApplicationUser User { get; set; }
        public bool ReadOnly { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public virtual ICollection<NotiMessageUser> MessageUsers { get; set; }
    }
}
