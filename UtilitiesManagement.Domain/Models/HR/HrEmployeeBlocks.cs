namespace UtilitiesManagement.Domain.Models.HR
{
    [Table("Hr_EmployeeBlocks")]
    public class HrEmployeeBlocks
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }
        public long Collector_Id { get; set; }
        [ForeignKey(nameof(Collector_Id))]
        public HrEmployee Employee { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public long Block_Id { get; set; }
        [ForeignKey(nameof(Block_Id))]
        public SharBlock Block { get; set; }
        //[ForeignKey(nameof(Collector_Id))]
        //public HrEmployee Employee { get; set; }
    }
}
