namespace UtilitiesManagement.Domain.Dtos.Request.Operation
{
    public class UpdateComplaintRequest
    {
        public long Id { get; set; }

        [DefaultValue(false)]
        public bool IsRevised { get; set; }
    }
}
