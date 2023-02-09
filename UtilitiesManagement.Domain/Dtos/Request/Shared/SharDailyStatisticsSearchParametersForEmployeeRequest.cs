namespace UtilitiesManagement.Domain.Dtos.Request.Shared
{
    public class SharDailyStatisticsSearchParametersForEmployeeRequest
    {
        [Required]
        public long EmployeeId { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }

    public class SharDailyStatisticsSearchParametersForEmployee
    {
        [Required]
        public long EmployeeId { get; set; }

        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
    }
}
