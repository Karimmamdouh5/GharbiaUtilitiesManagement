namespace UtilitiesManagement.Domain.Dtos.Response.Auth
{
    public class AuthLatestLocationForUserResponse
    {
        public double? X { get; set; }
        public double? Y { get; set; }
        public string EmpName { get; set; }
        public string Date { get; set; }
        public bool? Status { get; set; }
    }
}
