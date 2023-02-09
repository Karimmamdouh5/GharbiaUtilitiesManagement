namespace UtilitiesManagement.Domain.Models.Technician
{
    [Table("Tech_TechnicianLocations")]
    public class TechTechnicianLocation : BaseEntity
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }

        public long Technician_Id { get; set; }

        [ForeignKey(nameof(Technician_Id))]
        public TechTechnician Technician { get; set; }

        public double? X { get; set; }
        public double? Y { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? MobileDate { get; set; }
    }
}
