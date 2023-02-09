namespace UtilitiesManagement.Domain.Models.Shared
{
    [Table("Shar_Areas")]
    public class SharArea : BaseEntity
    { 
        [Column("ID")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; } 

        public string AreaCode { get; set; }

        [MaxLength(200)]
        public string AreaName { get; set; }
        public bool IsUpdated { get; set; }
        public long City_Id { get; set; }
        [ForeignKey(nameof(City_Id))]
        public SharCity City { get; set; }
        public ICollection<SharBlock> Blocks { get; set; }
    }
}
