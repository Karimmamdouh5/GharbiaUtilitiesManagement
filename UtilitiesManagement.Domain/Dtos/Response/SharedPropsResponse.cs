namespace UtilitiesManagement.Domain.Dtos.Response
{
    public class SharedPropsResponse
    {
        public long BranchId { get; set; }
        public long AreaId { get; set; }
        public long BlockId{ get; set; }
        public long IssueId { get; set; }

        public string BranchName { get; set; }
        public string AreaName { get; set; }
        public string BlockName { get; set; }
        public string IssueName { get; set; }
    }
}
