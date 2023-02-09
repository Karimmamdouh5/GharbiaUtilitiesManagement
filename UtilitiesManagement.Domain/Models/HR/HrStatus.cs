namespace  UtilitiesManagement.Domain.Models.HR
{
    [Table("Hr_Status")]
    public class HrStatus : BaseEntity
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }
    }
}
