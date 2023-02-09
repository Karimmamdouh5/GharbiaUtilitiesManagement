using UtilitiesManagement.Domain.Untility;
using System;

namespace  UtilitiesManagement.Domain.Models.Align
{
    public class AlignCompany : BaseEntity
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyLink { get; set; } = SD.DevelopmentLink;
        public int? MobileVersion { get; set; } = 1022;
        public bool IsActive { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? VersionCode { get; set; }
        public DateTime? VersionDate { get; set; }
        [StringLength(1000)]
        public string? DownloadUrl { get; set; }

    }
}
