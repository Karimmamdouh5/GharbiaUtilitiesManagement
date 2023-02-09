namespace UtilitiesManagement.Domain.Models.Customer
{
    [Table("Cust_CustomerActivities")] //com_activity
    public class CustCustomerActivity : BaseEntity
    {
        [Column("ID")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; } 

        [MaxLength(150)]
        public string Name { get; set; }
    }
}
