namespace UtilitiesManagement.Domain.Models.Operation
{
    [Table("Opr_UpdatedCustomers")]
    public class OprUpdatedCustomer : BaseEntity
    {
        [Column("ID")]
        [Key]
        public long Id { get; set; }

        public DateTime RequestDate { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public string? ImagePath { get; set; }
        [StringLength(50)]
        public string? NationalId { get; set; }
        public int? NumOfUnits { get; set; }
        public bool IsRevised { get; set; }

        public int UpdatedCustomerType_Id { get; set; }
        [ForeignKey(nameof(UpdatedCustomerType_Id))]
        public OprUpdatedCustomerType UpdatedCustomerType { get; set; }

        public long CustomerData_Id { get; set; }
        [ForeignKey(nameof(CustomerData_Id))]
        public CustCustomerData CustomerData { get; set; }

        public long Employee_Id { get; set; }
        [ForeignKey(nameof(Employee_Id))]
        public HrEmployee Employee { get; set; }

        public long Issue_Id { get; set; }
        [ForeignKey(nameof(Issue_Id))]
        public BillIssue Issue { get; set; }

        public int? CustomerActivity_Id { get; set; }
        [ForeignKey(nameof(CustomerActivity_Id))]
        public CustCustomerActivity CustomerActivity { get; set; }
        public bool IsPosted { get; set; }
        public string? InternetSpeed { get; set; }
    }
}
