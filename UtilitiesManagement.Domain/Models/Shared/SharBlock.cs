namespace UtilitiesManagement.Domain.Models.Shared
{
    [Table("Shar_Blocks")]
    public class SharBlock : BaseEntity
    {
        [Column("ID")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        public string BlockCode { get; set; }
        [MaxLength(200)]
        public string BlockName { get; set; }
        public bool IsUpdated { get; set; } 
        public long Area_Id { get; set; }
        [ForeignKey(nameof(Area_Id))]
        public SharArea Area { get; set; }
        public virtual ICollection<HrEmployeeBlocks> EmployeeBlocks { get; set; }
    }
}
 