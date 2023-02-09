using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Models.Permission
{
    [Table("Perm_Menu")]
    public class PermMenu : BaseEntity
    {
        [Column("ID")]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public long? ParentId { get; set; } = null;
        public bool? IsLast { get; set; } = false;
        public string? Route { get; set; }
        public string? Permission { get; set; }
        public string? Icon { get; set; }
        public int OrderBy { get; set; }
    }
}
