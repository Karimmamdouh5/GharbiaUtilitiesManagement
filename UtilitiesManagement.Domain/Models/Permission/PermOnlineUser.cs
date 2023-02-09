namespace  UtilitiesManagement.Domain.Models.Permission
{
    [Table("Perm_OnlineUsers")]
    public class PermOnlineUser : BaseEntity
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        public string UserId { get; set; }
        public string? AndroidId { get; set; }

        public string JobId { get; set; }
        public long? BranchId { get; set; }

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }
        public DateTime ExpireOn { get; set; }
    }
}
