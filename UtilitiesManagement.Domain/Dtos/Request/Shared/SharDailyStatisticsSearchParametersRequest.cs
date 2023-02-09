namespace UtilitiesManagement.Domain.Dtos.Request.Shared
{
    public class SharDailyStatisticsSearchParametersRequest : SharPaginationRequest
    {
        [Required]
        public long CompanyId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }
    }
}
