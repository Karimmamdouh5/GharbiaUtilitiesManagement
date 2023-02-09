namespace UtilitiesManagement.Domain.Dtos.Response.Shared
{
    public class SharTotalDailyStatisticsForEmployeeReportResponse
    {
        public DateTime GroupedDate { get; set; }
        public int ComplaintsCount { get; set; }
        public int MeterReadingsCount { get; set; }
        public int UpdatedCustomersCount { get; set; }
        public int BillsPaymentCount { get; set; }
    }
}
