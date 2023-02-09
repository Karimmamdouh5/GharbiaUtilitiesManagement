namespace UtilitiesManagement.Domain.ViewModels.HR
{
    public class HrEmployee_ViewModel
    {
        public long CollectorID { get; set; } = 0;
        public string? Code { get; set; }
        public string CollectorName { get; set; }
        public string CollectorType { get; set; }
        public string BranchID { get; set; }
        public bool IsUpdated { get; set; }
        public bool? IsReader { get; set; }
    }
}
