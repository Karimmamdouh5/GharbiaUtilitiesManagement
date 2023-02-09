namespace UtilitiesManagement.Domain.Models.Bill
{
    [Table("Bill_Issues")]
    public class BillIssue : BaseEntity
    {
        [Column("ID")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long Company_Id { get; set; }
        [ForeignKey(nameof(Company_Id))]
        public SharCompany Company { get; set; }
        [MaxLength(150)]
        public string IssueName{ get; set; }

        public DateTime IssueDate { get; set; }

        [MaxLength(100)]
        public string Status { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<BillIssueDetail> IssueDetails { get; set; }
    }
}
