

namespace UtilitiesManagement.Domain.Models.Bill
{
    [Table("Bill_IssueDetail")]
    public class BillIssueDetail : BaseEntity
    {
        [Column("ID")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public long Id { get; set; }

        public int BillStartNum { get; set; }
        public int BillEndNum { get; set; }

        [MaxLength(100)]
        public string BranchIssueStatus { get; set; }

        public bool CanPostReading { get; set; }

        public long Issue_Id { get; set; }
        [ForeignKey(nameof(Issue_Id))]
        public BillIssue Issue { get; set; }

        public long Branch_Id { get; set; }
        [ForeignKey(nameof(Branch_Id))]
        public SharBranch Branch { get; set; }
        public bool IsActive { get; set; }
    }
}
