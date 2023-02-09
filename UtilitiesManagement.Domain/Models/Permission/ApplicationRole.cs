

namespace UtilitiesManagement.Domain.Models.Permission
{
    public class ApplicationRole : IdentityRole,IBaseEntity
    {
        
        public bool IsDeleted { get; set; }
        public DateTime InsertDate { get ; set; }
        public DateTime UpdateDate { get ; set ; }
        public DateTime? DeleteDate { get ; set ; }
        public string? InsertBy { get ; set ; }
        public string? UpdateBy { get ; set ; }
        public string? DeleteBy { get ; set ; }
        public long Company_Id { get; set; }
        [ForeignKey(nameof(Company_Id))]
        public SharCompany? Company { get; set; }
        public int? CompanyTenantId { get ; set ; }
        public bool Is_Admin { get; set; }
        public bool Is_SuperAdmin { get; set; }
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
         public virtual ICollection<ApplicationRoleClaim> RoleClaims { get; set; }
    }
}
