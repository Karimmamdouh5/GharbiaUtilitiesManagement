namespace UtilitiesManagement.Domain.Models.Operation
{
    [Table("Opr_MeterReadings")]
    public class OprMeterReading : BaseEntity
    {
        [Column("ID")]
        [Key]
        public long Id { get; set; }

        public double Value { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public bool IsRevised { get; set; }
        public bool IsPosted { get; set; }
        public string? Notes { get; set; }
        public string? ReadingImagePath{ get; set; }
        public string? OperationUserId { get; set; }

        public int MeterStatus_Id { get; set; }
        [ForeignKey(nameof(MeterStatus_Id))]
        public OprMeterStatus MeterStatus { get; set; }

        public long Employee_Id { get; set; }
        [ForeignKey(nameof(Employee_Id))]
        public HrEmployee Employee { get; set; }

        public long Customer_Id { get; set; }
        [ForeignKey(nameof(Customer_Id))]
        public CustCustomerData CustomerData { get; set; }

  

        public long Issue_Details_Id { get; set; }
        [ForeignKey(nameof(Issue_Details_Id))]
        public BillIssueDetail IssueDetails { get; set; }

        public string? InternetSpeed { get; set; }

        public DateTime? MeterReadingDate { get; set; }
        public string? PreviousReading{ get; set; }
        public string? PreviousReadingIssueNumber{ get; set; }
        
    }
}
