namespace UtilitiesManagement.Domain.Models.Operation
{
    [Table("Opr_ComplaintTypes")]
    public class OprComplaintType : BaseEntity
    {
        [Column("ID")]
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public bool IsAttachedImage { get; set; }
    }
}
