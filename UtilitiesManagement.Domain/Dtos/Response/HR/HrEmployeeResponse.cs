namespace UtilitiesManagement.Domain.Dtos.Response.HR
{
    public class HrEmployeeProfileResponse
    {
        public long Id { get; set; }
        public String EmployeeName { get; set; }
        public String EmployeeJob { get; set; }
        public String BranchName { get; set; }
        public bool UserIsActive { get; set; }
        public List<CollectorBlocks> Blocks { get; set; } 
        public bool IsTechnician { get; set; }
        public TechnicianObj Technician { get; set; }
    }
    public class CollectorBlocks
    {
        public long Id { get; set; }
        public string BlockName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } 
        public string BlockCode { get; set; }
        public String AreaName { get; set; }
    }
    public class TechnicianObj
    {
        public bool CanCollect { get; set; }
        public bool CanRead { get; set; }
        public bool CanComplain { get; set; }
        public bool CanEditCustomer { get; set; }
        public bool AttachImageRead { get; set; }
        public bool AttachImageEditCustomer { get; set; }
        public int MaxOfflineWorkingHours { get; set; }
        public int MaxOfflineWorkingBills { get; set; }
    }
}