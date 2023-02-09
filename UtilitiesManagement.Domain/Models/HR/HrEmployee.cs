

namespace UtilitiesManagement.Domain.Models.HR
{
    [Table("Hr_Employees")]
    public class HrEmployee : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public long Id { get; set; } 

        [MaxLength(10)]
        public string? Code { get; set; }
        [MaxLength(300) , MinLength(6)]
        public string Name { get; set; }

        [Display(Name = "EmailAddress")]
        [MaxLength(250, ErrorMessage = "The {0} field length can not more than {1}.")]
        [EmailAddress(ErrorMessage = "The {0} format is not valid.")]
        public string? Email { get; set; }

        [Display(Name = "Mobile"), MinLength(11, ErrorMessage = "The {0} field length must be grater than or equal {1}."), MaxLength(11, ErrorMessage = "The {0} field length must be less than or equal {1}.")]
        public string? Mobile { get; set; }
        public string? ImagePath { get; set; } = "";

        public string Job { get; set; }
      
        public int? Status_Id { get; set; }   // = 1; Make it مفعل  و تتحط SEEDING Data
        [ForeignKey(nameof(Status_Id))]
        public HrStatus Status { get; set; }
        public bool IsActive { get; set; } = true;
        public bool? IsReader { get; set; } = false;
        public long Branch_Id { get; set; }

        [ForeignKey(nameof(Branch_Id))]
        public SharBranch Branch { get; set; }
        public bool IsTechnician { get; set; } = false;

        public virtual List<ApplicationUser> Users { get; set; }
        public ICollection<TechTechnician> TechnicianLogs { get; set; }
        public ICollection<HrEmployeeBlocks> EmployeeBlocks { get; set; }
    }
}
 