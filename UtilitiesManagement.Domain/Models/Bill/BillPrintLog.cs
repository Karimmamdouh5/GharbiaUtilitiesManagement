using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Models.Bill
{
    [Table("Bill_PrintLog")]
    public class BillPrintLog:BaseEntity
    {
        [Column("ID")]
        [Key]
        public int Id { get; set; }
        public long BillPayment_Id { get; set; }
        [ForeignKey(nameof(BillPayment_Id))]
        public BillPayment BillPayment { get; set; }
        public string Disc { get; set; }
        public DateTime LogDate { get; set; }
        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }
    }
}
