namespace UtilitiesManagement.Domain.Models.Customer
{
    [Table("Cust_CustomerData")]
    public class CustCustomerData : BaseEntity
    {
        [Column("ID")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; } 
         
        [MaxLength(6)]
        public string? SubscriptionStartDate { get; set; } 

        [MaxLength(50)]
        public string Code { get; set; } 

        [MaxLength(250)]
        public string? Name { get; set; } 

        [MaxLength(100)]
        public string? ActualName { get; set; }

        [MaxLength(200)]
        public string? ActualActivity { get; set; }
        [MaxLength(100)]
        public string? CustomerStartIssue { get; set; }
        public int NumOfUnits { get; set; }
        [StringLength(50)]
        public string? ActivityStarIssue { get; set; }
        public bool CustomerHasSewage { get; set; }

        [MaxLength(50)]
        public string? MeterChassisNum { get; set; }
        [MaxLength(50)]
        public string? MeterDiameter { get; set; }    
        public DateTime MeterStartDate { get; set; }
        public int MeterStartReading { get; set; }
        [MaxLength(50)]
        public string? MeterStartIssue { get; set; }
        public double? X { get; set; } 
        public double? Y { get; set; }
        public string? ImagePath { get; set; }
        public bool IsDataComplete { get; set; } 

        public long Block_Id { get; set; } 
        [ForeignKey(nameof(Block_Id))]
        public SharBlock Block { get; set; }

        public int CustomerStatus_Id { get; set; }
        [ForeignKey(nameof(CustomerStatus_Id))]
        public CustCustomerStatus CustomerStatus { get; set; }

        public int CustomerActivity_Id { get; set; }
        [ForeignKey(nameof(CustomerActivity_Id))]
        public CustCustomerActivity CustomerActivity { get; set; }

        [MaxLength(50)]
        public string? PreviousReading { get; set; }
        [MaxLength(50)]
        public string? PreviousReadingIssueNumber { get; set; }
        public string? Address { get; set; }

        [MaxLength(50)]
        public string InstKey { get; set; } = "0";
        public bool IsPosted { get; set; }
    }
}
