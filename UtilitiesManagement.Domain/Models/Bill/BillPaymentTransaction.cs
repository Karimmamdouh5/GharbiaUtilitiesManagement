namespace UtilitiesManagement.Domain.Models.Bill
{
    [Table("Bill_PaymentTransactions")]
    public class BillPaymentTransaction
    {
        [Column("ID")]
        [Key]
        public long Id { get; set; }
        public double Amount { get; set; }
        public long Bill_Id { get; set; }
        [ForeignKey(nameof(Bill_Id))]
        public BillBillsData Bill { get; set; }
        public long BillPayment_Id { get; set; }
        [ForeignKey(nameof(BillPayment_Id))]
        public BillPayment BillPayment { get; set; }
    }
}