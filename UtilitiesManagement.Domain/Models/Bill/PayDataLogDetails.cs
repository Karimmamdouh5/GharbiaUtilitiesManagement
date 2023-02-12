using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Models.Bill
{
    [Table("Bill_PayDataLogDetails")]
    public class PayDataLogDetails : BaseEntity
    {
        [Column("ID")]
        [Key]
        public long Id { get; set; }
        public long Bill_Id { get; set; }
        public double Amount { get; set; }
        [ForeignKey(nameof(Bill_Id))]
        public BillBillsData BillData { get; set; }
    }
}
