namespace UtilitiesManagement.Domain.Models.Operation
{
    [Table("Opr_Complaints")]
    public class OprComplaint : BaseEntity
    {
        [Column("ID")]
        [Key]
        public long Id { get; set; }

        public DateTime ComplaintDate { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public string Notes { get; set; }

        public bool IsRevised { get; set; }

        public long Employee_Id { get; set; }
        [ForeignKey(nameof(Employee_Id))]
        public HrEmployee Employee { get; set; }

        public long? Customer_Id { get; set; }
        [ForeignKey(nameof(Customer_Id))]
        public CustCustomerData? CustomerData { get; set; }

        public long Issue_Id { get; set; }
        [ForeignKey(nameof(Issue_Id))]
        public BillIssue Issue { get; set; }

        public int ComplaintType_Id { get; set; }
        [ForeignKey(nameof(ComplaintType_Id))]
        public OprComplaintType ComplaintType { get; set; }

        public bool IsPublic { get; set; } = false;
        public bool IsCustomerComplaint { get; set; } = false;
       
        public string? PublicAddress { get; set; }

        public long? BlockId { get; set; }
        [ForeignKey(nameof(BlockId))]
        public SharBlock? Block { get; set; }
        public ICollection<OprComplaintImage> ComplaintImages { get; set; } = new HashSet<OprComplaintImage>();
    }
}
