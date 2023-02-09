namespace UtilitiesManagement.Domain.Dtos.Request.Operation
{
    public class AddComplaintTypeRequest
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsAttachedImage { get; set; }
    }
}
