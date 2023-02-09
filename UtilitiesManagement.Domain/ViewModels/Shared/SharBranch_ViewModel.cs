namespace UtilitiesManagement.Domain.ViewModels.Shared
{
    public class SharBranch_ViewModel
    {
        public long BranchID { get; set; }
        public string BranchCode { get; set; } 
        public string BranchName { get; set; }
        public bool BranchIsUpdated { get; set; }
        public long? CompanyId { get; set; } 
    }
}
