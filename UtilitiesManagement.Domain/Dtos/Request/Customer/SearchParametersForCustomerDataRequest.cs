namespace UtilitiesManagement.Domain.Dtos.Request.Customer
{
    public class SearchParametersForCustomerDataRequest : SharPaginationRequest
    {
        public long? CustomerId { get; set; }
        public string? CustomerCode { get; set; }
        public long? AreaId { get; set; }
        public long? BlockId { get; set; }
        public long? CityId { get; set; }
        public long? StateId { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsRevised { get; set; }
    }
}
