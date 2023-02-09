namespace UtilitiesManagement.Domain.Models.Operation
{
    [Table("Opr_MeterReadings_Logs")]
    public class OprMeterReadingLog : BaseEntity
    {
        [Column("ID")]
        [Key]
        public long Id { get; set; }

        public double OldValue { get; set; }
        public double NewValue { get; set; }

        public long MeterReadings_Id { get; set; }
        [ForeignKey(nameof(MeterReadings_Id))]
        public OprMeterReading MeterReading { get; set; }
    }
}
