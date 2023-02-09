

using UtilitiesManagement.Domain.Models.Customer;

namespace UtilitiesManagement.Domain.Models.Bill
{ 
    [Table("Bill_BillData")]
    public class BillBillsData:BaseEntity
    {
        [Column("ID")] 
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        public long? BillIssue_Id { get; set; }
        [ForeignKey(nameof(BillIssue_Id))]
        public BillIssue BillIssue { get; set; }
        public long Customer_Id { get; set; }        //Cust_Key
        [ForeignKey(nameof(Customer_Id))]
        public CustCustomerData CustomerData { get; set; } 
        public string BillNum { get; set; }
        public DateTime PayDate { get; set; }
        public double BillValue { get; set; }
        public double WaterValue { get; set; }
        public double Installment { get; set; }
        public double Others { get; set; }
        public double Maintenance { get; set; }
        public double ContenutityService { get; set; } 
        public double RegularityService { get; set; } 
        public double WaterInstallment { get; set; } 
        public double WastWaterInstallment { get; set; } 
        public double Tax14Percent { get; set; }
        public DateTime? CustomerPayingDate { get; set; } = null;
        public double PrevReading { get; set; } = 0;
        public double CurrentReading { get; set; } = 0;
    }
}
