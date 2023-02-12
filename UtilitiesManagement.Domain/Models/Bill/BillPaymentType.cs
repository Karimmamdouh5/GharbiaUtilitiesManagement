using UtilitiesManagement.Domain.Models.Customer;

namespace UtilitiesManagement.Domain.Models.Bill
{
    [Table("Bill_PaymentType")]
    public class BillPaymentType : BaseEntity
    {
        [Column("ID")]
        [Key] 
        public long Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public string SysName { get; set; }

    }
}
