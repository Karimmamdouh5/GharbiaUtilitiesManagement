using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Models.Bill
{
    [Table("Bill_PayDataLog")]
    public class PayDataLog:BaseEntity
    {
        [Column("ID")]
        [Key]
        public int Id { get; set; }
        public long Customer_Id { get; set; }
        [ForeignKey(nameof(Customer_Id))]
        public CustCustomerData CustomerData { get; set; }
        public DateTime PayDate { get; set; }
        public long Employee_Id { get; set; }
        [ForeignKey(nameof(Employee_Id))]
        public HrEmployee Employee { get; set; }
        public ICollection<PayDataLogDetails>? PayDataLogDetails { get; set; }
    }
}
