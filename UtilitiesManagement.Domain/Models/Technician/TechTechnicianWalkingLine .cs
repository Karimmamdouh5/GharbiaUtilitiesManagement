namespace UtilitiesManagement.Domain.Models.Technician
{
    [Table("Tech_Technician_WalkingLines")]
    public class TechTechnicianWalkingLine : BaseEntity
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }

        public long Technician_Id { get; set; }

        [ForeignKey(nameof(Technician_Id))]
        public TechTechnician Technician { get; set; }

        //public int WalkingLine_Id { get; set; }

        //[ForeignKey(nameof(WalkingLine_Id))]
        //public CustWalkingLine WalkingLine { get; set; }

        public DateTime StartDate { get; set; } = DateTime.UtcNow.AddHours(2);
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime? DeActiveDate { get; set; }
        [MaxLength(100)]
        public string DeActiveBy { get; set; }
    }
}
