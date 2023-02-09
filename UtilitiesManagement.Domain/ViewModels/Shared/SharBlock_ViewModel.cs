namespace UtilitiesManagement.Domain.ViewModels.Shared
{
    public class SharBlock_ViewModel
    {
        public long BlockId { get; set; }
        public string BlockCode { get; set; }
        public string BlockName { get; set; }
        public bool BlockIsUpdated { get; set; } = false;
        public long AreaId { get; set; }
      
    }

}
 