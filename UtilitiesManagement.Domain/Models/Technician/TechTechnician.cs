namespace UtilitiesManagement.Domain.Models.Technician
{
    [Table("Tech_Technicians")]
    public class TechTechnician : BaseEntity
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }
        public long Employee_Id { get; set; }
        [ForeignKey(nameof(Employee_Id))]
        public HrEmployee Employee { get; set; }
        public bool IsActive { get; set; } = true;
        public bool CanCollect { get; set; }
        public bool CanRead { get; set; }
        public bool CanComplain { get; set; }
        public bool CanEditCustomer { get; set; } 
        public bool AttachImageRead { get; set; }
        public bool AttachImageEditCustomer { get; set; }
        public int MaxOfflineWorkingHours { get; set; }
        public int MaxOfflineWorkingBills { get; set; }
    }
}