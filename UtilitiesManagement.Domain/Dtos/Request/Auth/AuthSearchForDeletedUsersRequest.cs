namespace UtilitiesManagement.Domain.Dtos.Request.Auth
{
    public class AuthSearchForDeletedUsersRequest
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}

