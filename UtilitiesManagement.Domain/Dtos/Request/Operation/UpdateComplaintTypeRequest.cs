namespace UtilitiesManagement.Domain.Dtos.Request.Operation
{
    public class UpdateComplaintTypeRequest 
    {
        public long Id { get; set; }

        public string Name { get; set; }

        [DefaultValue(false)]
        public bool IsAttachedImage { get; set; }
    }
}
