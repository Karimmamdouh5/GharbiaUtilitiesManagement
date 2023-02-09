namespace UtilitiesManagement.Domain.Dtos.Request.Operation
{
    public class AddUpdatedCustomerRequest 
    {
        public long Id { get; set; }
        public DateTime RequestDate { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public int? NumOfUnits { get; set; }

        [DefaultValue(false)]
        public bool IsRevised { get; set; }
        public int UpdatedCustomerType_Id { get; set; }
        public long CustomerData_Id { get; set; }
        public long Employee_Id { get; set; }
        public long Issue_Id { get; set; }
        public int? CustomerActivity_Id { get; set; }
        
    }
}
