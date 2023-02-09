using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Models.Shared
{
    [Table("Shar_States_Temp")]
    public class SharState_Temp
    {
        [Column("ID")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        public string StateCode { get; set; }
        [MaxLength(200)]
        public string StateName { get; set; }
        public bool IsUpdated { get; set; }
        public long Branch_Id { get; set; }
    }
}
