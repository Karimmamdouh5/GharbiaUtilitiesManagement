namespace UtilitiesManagement.Domain.ViewModels.Customer
{
    public class CustCustomerData_ViewModel 
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string? Name { get; set; }
        public string? ActualName { get; set; }
        public string? ActualActivity { get; set; }
        public string CustomerStartIssue { get; set; }
        public int NumOfUnits { get; set; }
        public string ActivityStarIssue { get; set; }
        public bool CustomerHasSewage { get; set; }
        public string? MeterChassisNum { get; set; }
        public string MeterDiameter { get; set; }
        public DateTime MeterStartDate { get; set; }
        public int MeterStartReading { get; set; }
        public string MeterStartIssue { get; set; }
        public string ImagePath { get; set; }
        public long Block_Id { get; set; }
        public int CustomerStatus_Id { get; set; }
        public string? CustomerActivity_Id { get; set; }
        public string? Address { get; set; }
        public string InstKey { get; set; }
    }
 
}
