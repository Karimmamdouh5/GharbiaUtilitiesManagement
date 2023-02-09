using UtilitiesManagement.Domain.Models.Customer;

namespace UtilitiesManagement.Domain.Models.Bill
{
    [Table("Bill_Payment")]
    public class BillPayment
    {
        [Column("ID")]
        [Key] 
        public long Id { get; set; }  
        public long CustomerData_Id { get; set; }
        [ForeignKey(nameof(CustomerData_Id))]
        public CustCustomerData CustomerData { get; set; }
        public long Employee_Id { get; set; }
        public long? BillPaymentSafe_Id { get; set; }
        [ForeignKey(nameof(BillPaymentSafe_Id))]
        public BillPaymentSafe? billPaymentSafe { get; set; }
        [ForeignKey(nameof(Employee_Id))]
        public HrEmployee Employee { get; set; }
        [MaxLength(500)]
        public string Notes { get; set; }
        public DateTime PayDate { get; set; }
        public double X { get; set; }
        public double Y { get; set; }    
        public ICollection<BillPaymentTransaction> Transactions { get; set; }
        public bool? IsCollected { get; set; }
        public DateTime? CollectionDate { get; set; }
        public bool IsRePrint { get; set; } = false;
    }
}
