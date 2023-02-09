namespace UtilitiesManagement.Domain.Models.Customer
{
    [Table("Cust_CustomerStatus")]
    public class CustCustomerStatus : BaseEntity
    {
        [Column("ID")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; } 

        [MaxLength(250)]
        public string Name { get; set; } 
    }
}
