namespace UtilitiesManagement.Domain.ViewModels.Shared
{
    public class SharArea_ViewModel 
    {
        public long AreaID { get; set; }
        public string AreaCode { get; set; }
        public string AreaName { get; set; }
        public long CityId { get; set; }
        public bool AreaIsUpdated { get; set; }
    }
}
