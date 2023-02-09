namespace UtilitiesManagement.Domain.Dtos.Response.Shared
{
    public class SharTotalDailyStatisticsPerEmployeeReportResponse
    {
        public IEnumerable<SharTotalDailyStatisticsPerEmployeeReport> Data { get; set; }
        public int TotalRecords { get; set; }
    }
    public class SharTotalDailyStatisticsPerEmployeeReport
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int ComplaintsCount { get; set; }
        public int MeterReadingsCount { get; set; }
        public int UpdatedCustomersCount { get; set; }
        public int BillsPaymentCount { get; set; }
    }
}
