namespace UtilitiesManagement.Domain.Dtos.Response.Shared
{
    public class GetListResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
    public class SelectListResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
    public class SelectIntListResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class SelectListResponseWithDate
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public int? BranchId { get; set; }
    }
    public class SelectListSysNameResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string SysName { get; set; }
    }
    public class SelectListResponseIdInt
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
    public class SelectListWithStringIdStringResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class SelectListComplaintTypeResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsAttachedImage { get; set; }
    }
}
