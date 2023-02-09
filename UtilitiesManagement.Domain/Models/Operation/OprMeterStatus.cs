namespace UtilitiesManagement.Domain.Models.Operation
{
    [Table("Opr_MeterStatus")]
    public class OprMeterStatus : BaseEntity
    {
        [Column("ID")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
