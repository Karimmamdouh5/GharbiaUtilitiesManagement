namespace UtilitiesManagement.Domain.Dtos.Response.Operation
{
    public class GetMeterReadingResponse
    {
        public IEnumerable<GetMeterReading> Data { get; set; }
        public int TotalRecords { get; set; } = 0;
    }
    public class GetMeterReading : SharedPropsResponse
    {
        public long Id { get; set; }
        public long CollectorId { get; set; }
        public string CollectorName { get; set; }
        public long CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCode { get; set; }
        public string Notes { get; set; }
        public double Value { get; set; }
        public double? LastReading { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public string MeterStatus { get; set; }
        public string ReadingImagePath { get; set; }
        public string IssueStatus { get; set; }
        public DateTime IssueDate { get; set; }
        public bool IsRevised { get; set; }
        public bool IsPosted { get; set; } 
        public bool IsUpnormalReading { get; set; } 
        public DateTime? MeterReadingDate { get; set; }


    }

    public class GetMeterReadingForAllCustomersResponse
    {
        public IEnumerable<GetMeterReadingForAllCustomers> Data { get; set; }
        public int TotalRecords { get; set; } = 0;
    }
    public class GetMeterReadingForAllCustomers 
    {
        public string CollectorName { get; set; }
        public long CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Notes { get; set; }
        public double Value { get; set; }
        public double? LastReading { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public string MeterStatus { get; set; }
        public string ReadingImagePath { get; set; }
        public bool IsUpnormalReading { get; set; } 
        public DateTime? MeterReadingDate { get; set; }
        public string BranchName { get; set; }
        public string IssueName { get; set; }

    }
}
