using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Models.Shared
{
    [Table("Shar_Areas_Temp")]
    public class SharArea_Temp
    {
        [Column("ID")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public string AreaCode { get; set; }

        [MaxLength(200)]
        public string AreaName { get; set; }
        public bool IsUpdated { get; set; }
        public long City_Id { get; set; }
    }
}
