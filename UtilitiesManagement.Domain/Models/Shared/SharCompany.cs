namespace UtilitiesManagement.Domain.Models.Shared
{
    [Table("Shar_Company")]
    public class SharCompany : BaseEntity
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [MaxLength(10)]
        public string CompanyCode { get; set; }
        [MaxLength(100)]
        public string CompanyName { get; set; }
        [MaxLength(100)]
        public string Activity { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [MaxLength(20)]
        public string? PhoneNumber { get; set; }
        public string? LogoPrint { get; set; }
        public string? LogoWeb { get; set; }
        [MaxLength(50)]
        public bool IsActive { get; set; } = true;

        public int MobileUsersCount { get; set; }
        public string CompanyServiceName { get; set; }
        public ICollection<SharBranch>? branches { get; set; }
    }
}
