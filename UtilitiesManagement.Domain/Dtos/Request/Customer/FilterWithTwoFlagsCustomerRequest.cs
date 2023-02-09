namespace UtilitiesManagement.Domain.Dtos.Request.Customer
{
    public class FilterWithTwoFlagsCustomerRequest
    {
        [Required]
        public long AreaId { get; set; }
        public long? BlockId { get; set; }
    }
}
