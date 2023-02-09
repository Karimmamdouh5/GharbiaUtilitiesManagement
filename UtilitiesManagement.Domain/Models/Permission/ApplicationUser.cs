using UtilitiesManagement.Domain.Models.Notification;

namespace  UtilitiesManagement.Domain.Models.Permission
{
    public class ApplicationUser : IdentityUser, IBaseEntity
    {
        public bool IsActive { get; set; } = true;
        public string? UserToken { get; set; }
        public long Employee_Id { get; set; }

        [ForeignKey(nameof(Employee_Id))]
        public HrEmployee Employee { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string? InsertBy { get; set; }
        public string? UpdateBy { get; set; }
        public string? DeleteBy { get; set; }
        public int? CompanyTenantId { get; set; }
        public bool IsAndroid { get; set; }
        public int? UserType_Id { get; set; }
        [ForeignKey(nameof(UserType_Id))]
        public UserTypes UserType { get; set; }
        public ICollection<PermOnlineUser> UserLogs { get; set; }
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
        public virtual ICollection<NotiUserModule>? UserModule { get; set; }
        public virtual ICollection<ApplicationUserBranches> AssignedBranches { get; set; }

    }
}
