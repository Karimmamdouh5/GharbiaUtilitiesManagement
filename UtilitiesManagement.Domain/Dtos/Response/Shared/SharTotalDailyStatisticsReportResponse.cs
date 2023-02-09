namespace UtilitiesManagement.Domain.Dtos.Response.Shared
{
    public class SharTotalDailyStatisticsReportResponse
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int ComplaintsCount { get; set; }
        public int MeterReadingsCount { get; set; }
        public int UpdatedCustomersCount { get; set; }
        public int BillsPaymentCount { get; set; }
    }
}
