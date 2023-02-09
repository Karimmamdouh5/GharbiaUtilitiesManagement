namespace UtilitiesManagement.Domain.Dtos.Request.Operation
{
    public class AddComplaintImageRequest
    {
        public long Complaint_Id { get; set; }
        public List<string> ImagePathes { get; set; }
        public List<IFormFile> Images { get; set; }
    }
}
