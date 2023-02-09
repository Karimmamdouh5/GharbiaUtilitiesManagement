namespace UtilitiesManagement.Domain.Dtos.Request.Customer
{
    public class FilterForCustomerProfileRequest
    {
        public long? CustomerId { get; set; }
        public string? CustomerCode { get; set; }
    }
}
