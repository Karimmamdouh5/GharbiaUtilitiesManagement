using UtilitiesManagement.Domain.Models.Customer;

namespace UtilitiesManagement.Domain.Models.Bill
{
    [Table("Bill_PaymentSafes")]
    public class BillPaymentSafe
    {
        [Column("ID")]
        [Key]
        public long Id { get; set; }
        public int BillSafe_Id { get; set; }
        [ForeignKey(nameof(BillSafe_Id))]
        public BillSafe BillSafe { get; set; }

        public long HrEmployee_Id { get; set; }
        [ForeignKey(nameof(HrEmployee_Id))]
        public HrEmployee HrEmployee { get; set; }
        public double TotalAmount { get; set; }
        public bool IsPosted { get; set; } = false;
        public DateTime CreatedDate { get; set; }

        public ICollection<BillPayment> BillPayments { get; set; }

    } 
}
