using UtilitiesManagement.Domain.Dtos.Request.Auth;

namespace  UtilitiesManagement.Domain.Dtos.Response
{
    public class Response<T> where T : class
    {
        public long IdOfAddedObject { get; set; }
        public int ErrorsCount { get; set; }
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public bool IsUpdated { get; set; }
        public bool IsExists { get; set; }
        public bool IsNotFound { get; set; }
        public bool IsNotificationSuccess { get; set; }
        public int TotalPages { get; set; }
        public T Data { get; set; }
        public IEnumerable<string> Errors { get; set; } = new List<string>();
    }
}
