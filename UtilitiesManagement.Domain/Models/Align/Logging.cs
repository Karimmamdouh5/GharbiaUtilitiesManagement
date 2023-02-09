namespace  UtilitiesManagement.Domain.Models.Align
{
    public class Logging : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public LogType LogType { get; set; } = LogType.Bug;
        public string StackTrace { get; set; }
        public string ExceptionPath { get; set; }
        public string ExceptionInnerPath { get; set; }
        public string Message { get; set; }
        public string ObjJson { get; set; }
        public string InnerException { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow.AddHours(2);
    }

    public enum LogType
    {
        Bug,
        Integrationbug
    }
}
