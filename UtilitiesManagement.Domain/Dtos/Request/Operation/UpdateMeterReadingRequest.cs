namespace UtilitiesManagement.Domain.Dtos.Request.Operation
{
    public class UpdateMeterReadingRequest : UpdateComplaintRequest
    {
        [DefaultValue(false)]
        public bool IsPosted { get; set; }
    }
}
