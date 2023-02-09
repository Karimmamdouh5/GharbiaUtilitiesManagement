namespace UtilitiesManagement.Domain.Models.Operation
{
    [Table("Opr_UpdatedCustomerTypes")]
    public class OprUpdatedCustomerType : BaseEntity
    {
        [Column("ID")]
        [Key]
        public int Id { get; set; }

        [MaxLength(200)]
        public string Name { get; set; }
        public string SysName { get; set; }
    }
}
