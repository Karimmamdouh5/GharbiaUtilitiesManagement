namespace UtilitiesManagement.Domain.Dtos.Request.Operation
{
    public class SearchParametersRequest : SearchParametersForCustomerDataRequest
    {
        public long? BranchId { get; set; }
        public int? UpdatingTypeId { get; set; }
        public bool? IsPublic { get; set; }
        public bool? IsPosted { get; set; }
        public bool? IsCustomerComplaint { get; set; }

    }
}
