namespace UtilitiesManagement.Domain.Dtos.Response.Operation
{
    public class GetComplaintResponse
    {
        public IEnumerable<GetComplaint> Data { get; set; }
        public int TotalRecords { get; set; } = 0;
    }
    public class GetComplaint : SharedPropsResponse
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public string CollectorName { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerCode { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public string Details { get; set; }
        public bool IsRevised { get; set; }
        public string ComplaintTypeName { get; set; }
        public List<string> ComplaintImagesPath { get; set; }
        public bool? IsPublic { get; set; }
        public string? PublicAddress { get; set; }

    }
}
