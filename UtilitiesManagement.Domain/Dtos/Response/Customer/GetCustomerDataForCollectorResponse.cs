namespace UtilitiesManagement.Domain.Dtos.Response.Customer
{
    public class GetCustomerDataForCollectorResponse : GetCustomer
    {
        public long BranchId { get; set; }
        public string? BranchName { get; set; }

        public double TotalIndebtedness { get; set; } = 0;
        public int CountBill { get; set; } = 0;

    }
}
