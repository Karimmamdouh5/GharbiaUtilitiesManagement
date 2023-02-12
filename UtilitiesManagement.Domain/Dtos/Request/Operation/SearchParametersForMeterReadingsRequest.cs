namespace UtilitiesManagement.Domain.Dtos.Request.Operation
{
    public class SearchParametersForMeterReadingsRequest : SearchParametersForCustomerDataRequest
    {
        public long BranchId { get; set; }
        public int? UpdatingTypeId { get; set; }
        public bool? IsPosted { get; set; }
        public long? EmployeeId { get; set; }
    }
}
