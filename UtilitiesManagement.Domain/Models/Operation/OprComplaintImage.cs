namespace UtilitiesManagement.Domain.Models.Operation
{
    [Table("Opr_ComplaintImages")]
    public class OprComplaintImage : BaseEntity
    {
        [Column("ID")]
        [Key]
        public long Id { get; set; }

        public string ImagePath { get; set; }

        public long Complaint_Id { get; set; }
        [ForeignKey(nameof(Complaint_Id))]
        public OprComplaint Complaint { get; set; }
        public string? InternetSpeed { get; set; }
        
    }
}
