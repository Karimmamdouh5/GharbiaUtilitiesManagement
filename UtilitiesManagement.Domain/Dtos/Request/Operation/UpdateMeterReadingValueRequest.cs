namespace UtilitiesManagement.Domain.Dtos.Request.Operation
{
    public class UpdateMeterReadingValueRequest
    {
        [Required]
        public long MeterReadings_Id { get; set; }
        [Required]
        public double NewValue { get; set; }
    }
}
