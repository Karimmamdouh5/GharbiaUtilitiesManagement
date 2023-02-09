using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Models.Shared
{
    [Table("Shar_Blocks_Temp")]
    public class SharBlock_Temp:BaseEntity
    {
        [Column("ID")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        public string BlockCode { get; set; }
        [MaxLength(200)]
        public string BlockName { get; set; }
        public bool IsUpdated { get; set; }
        public long Area_Id { get; set; }
    }
}
