namespace UtilitiesManagement.Domain.Dtos.Request.Operation
{
    public class AddMeterReadingRequest
    {
        public long Id { get; set; }
        public double Value { get; set; }
        public long CollectorId { get; set; }
        public long Customer_Id { get; set; }
        public long? IssueDetails_Id { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        [DefaultValue(false)]
        public bool IsRevised { get; set; }

        [DefaultValue(false)]
        public bool IsPosted { get; set; }
        public long MeterStatus_Id { get; set; }
        public string? Notes { get; set; }
        public string? OperationUserId { get; set; }
        public DateTime? MeterReadingDate { get; set; }
    }
}
