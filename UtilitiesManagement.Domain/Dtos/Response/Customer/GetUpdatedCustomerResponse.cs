namespace UtilitiesManagement.Domain.Dtos.Response.Customer
{
    public class GetUpdatedCustomerResponse
    {
        public IEnumerable<GetUpdatedCustomer> Data { get; set; }
        public int TotalRecords { get; set; } = 0;
    }
    public class GetUpdatedCustomer : SharedPropsResponse
    {
        public long Id { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string CollectorName { get; set; }
        public DateTime RequestDate { get; set; }
        public string UpdatedTypeName { get; set; }
        public string UpdatedTypeSysName { get; set; }//location => 1, activity =>2, unitsnumber => 3, customerimage => 4
        public long UpdatedCustomerTypeId { get; set; }
        public string CustomerActivity { get; set; }
        public int NumOfUnits { get; set; }
        public string ImagePath { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public string SysName { get; set; }
        public string? NationalId { get; set; }
        public bool? IsRevised { get; set; }


        public string? Cust_NationalId { get; set; }
        public int Cust_NumOfUnits { get; set; }
        public string? Cust_ImagePath { get; set; }
        public double? Cust_X { get; set; }
        public double? Cust_Y { get; set; }
        public string Cust_Activity { get; set; }
      
        

    }
}
