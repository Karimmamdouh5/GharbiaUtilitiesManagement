namespace UtilitiesManagement.Domain.Models.Shared
{
    [Table("Shar_Branches")]
    public class SharBranch : BaseEntity
    {
        [Column("ID")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; } 
        public string BranchCode { get; set; }
        [MaxLength(200)]
        public string BranchName { get; set; }
        public bool IsUpdated { get; set; }
        public long Company_Id { get; set; }
        [ForeignKey(nameof(Company_Id))]
        public SharCompany? Company { get; set; }
        public ICollection<HrEmployee> Employees { get; set; }
        //public ICollection<SharArea> Areas { get; set; }
        public ICollection<ApplicationUserBranches>? UserBranches { get; set; }
        public ICollection<SharState> States { get; set; }
    }
}
