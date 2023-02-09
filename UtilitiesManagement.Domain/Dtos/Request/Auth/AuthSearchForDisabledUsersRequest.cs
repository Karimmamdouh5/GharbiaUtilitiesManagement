namespace UtilitiesManagement.Domain.Dtos.Request.Auth
{
    public class AuthSearchForDisabledUsersRequest
    {
        public int EmpId{ get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
