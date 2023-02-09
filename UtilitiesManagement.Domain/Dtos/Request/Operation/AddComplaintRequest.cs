namespace UtilitiesManagement.Domain.Dtos.Request.Operation
{
    public class AddComplaintRequest
    {
        public long Id { get; set; }
        public DateTime ComplaintDate { get; set; }
        public long CollectorId { get; set; }
        public long? CustomerId { get; set; }
        public long IssueId { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public string Details { get; set; }

        [DefaultValue(false)]
        public bool IsRevised { get; set; }
        public long ComplaintType_Id { get; set; }

        public bool IsPublic { get; set; } = false;
        public string? PublicAddress { get; set; }
        public long? BlockId { get; set; }

        //public string? ImagePath { get; set; }
        //public IFormFile? Image { get; set; }
    }
}
