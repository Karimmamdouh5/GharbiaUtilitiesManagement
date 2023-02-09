using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Models.Shared
{
    [Table("Shar_Branches_Temp")]
    public class SharBranch_Temp:BaseEntity
    {
        [Column("ID")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        public string BranchCode { get; set; }
        [MaxLength(200)]
        public string BranchName { get; set; }
        public bool IsUpdated { get; set; }
        public long Company_Id { get; set; }
    }
}
