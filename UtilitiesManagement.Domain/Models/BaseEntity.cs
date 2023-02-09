namespace  UtilitiesManagement.Domain.Models
{
    public class BaseEntity:IBaseEntity
    {
        public bool IsDeleted { get; set; } = false;
        public DateTime InsertDate { get; set; } = new DateTime().NowEg();
        public DateTime UpdateDate { get; set; } = new DateTime().NowEg();
        public DateTime? DeleteDate { get; set; }
        [StringLength(100)]
        public string? InsertBy { get; set; }
        [StringLength(100)]
        public string? UpdateBy { get; set; }
        [StringLength(100)]
        public string? DeleteBy { get; set; }
        public int? CompanyTenantId { get; set; }
    }
}
