using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Models.Shared
{
    [Table("Shar_States")]
    public class SharState : BaseEntity
    {
        [Column("ID")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        public string StateCode { get; set; }
        [MaxLength(200)]
        public string StateName { get; set; }
        public bool IsUpdated { get; set; }
        public long Branch_Id { get; set; }
        [ForeignKey(nameof(Branch_Id))]
        public SharBranch Branch { get; set; }
        public ICollection<SharCity> Cities { get; set; }

    }
}
