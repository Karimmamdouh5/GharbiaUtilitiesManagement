namespace UtilitiesManagement.Domain.Dtos.Request.Shared
{
    public class SharPaginationRequest
    {
        public int PageSize { get; set; } = 5;
        public int PageNumber { get; set; } = 1;
    }
}
