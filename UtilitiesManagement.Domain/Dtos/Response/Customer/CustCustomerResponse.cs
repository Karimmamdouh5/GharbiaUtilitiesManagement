namespace UtilitiesManagement.Domain.Dtos.Response.Customer
{
    public class CustCustomerResponse 
    {
        //public IEnumerable<CustCustomer> Data { get; set; }
        //public int PageSize { get; set; } = 0;
        public long Id { get; set; }
        public string? SubscriptionStartDate { get; set; }
        public string Code { get; set; }
        public string? Name { get; set; }
        public string ActualName { get; set; }
        public int ActivityId { get; set; }
        public string StartIssue { get; set; }
        public string ActivityStartIsuue { get; set; }
        public string ActivityName { get; set; }
        public string ActualActivity { get; set; }
        public int NumOfUnits { get; set; }
        public int MeterChassisNum { get; set; }
        public int MeterStartReading { get; set; }
        public DateTime MeterStartDate { get; set; }
        public string MeterStartIssue { get; set; }
        public bool HasSewage { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public string ImagePath { get; set; }
        public bool IsDataComplete { get; set; }
        public long BlockId { get; set; }
        public long AreaId { get; set; }
        public string BlockName { get; set; }
        public string AreaName { get; set; }
        public int StatusId { get; set; }
    }
    public class CustCustomer
    {
        public long Id { get; set; }
        public string? SubscriptionStartDate { get; set; }
        public string Code { get; set; }
        public string? Name { get; set; }
        public string ActualName { get; set; }
        public int ActivityId { get; set; }
        public string StartIssue { get; set; }
        public string ActivityStartIsuue { get; set; }
        public string ActivityName { get; set; }
        public string ActualActivity { get; set; }
        public int NumOfUnits { get; set; }
        public int MeterChassisNum { get; set; }
        public int MeterStartReading { get; set; }
        public DateTime MeterStartDate { get; set; }
        public string MeterStartIssue { get; set; }
        public bool HasSewage { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public string ImagePath { get; set; }
        public bool IsDataComplete { get; set; }
        public long BlockId { get; set; }
        public long AreaId { get; set; }
        public string BlockName { get; set; }
        public string AreaName { get; set; }
        public int StatusId { get; set; }
    }
}
