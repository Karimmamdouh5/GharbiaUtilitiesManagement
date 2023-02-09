namespace UtilitiesManagement.Domain.Dtos.Request.Operation
{
    public class AddComplaintImage
    {
        public string ImagePath { get; set; }
        public long Complaint_Id { get; set; }
        public string? InternetSpeed { get; set; }
    }
}
