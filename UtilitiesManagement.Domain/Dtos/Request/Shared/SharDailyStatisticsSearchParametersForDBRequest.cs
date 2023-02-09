namespace UtilitiesManagement.Domain.Dtos.Request.Shared
{
    public class SharDailyStatisticsSearchParametersForDBRequest
    {
        public long CompanyId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Take { get; set; }
        public int Skip { get; set; }
    }
}
