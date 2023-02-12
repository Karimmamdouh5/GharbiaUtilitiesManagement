namespace UtilitiesManagement.Domain.Dtos.Request.Operation
{
    public class UpdateUpdatedCustomersRequest
    {
        public long Id { get; set; }

        [DefaultValue(false)]
        public bool IsPosted { get; set; }
    }
}
