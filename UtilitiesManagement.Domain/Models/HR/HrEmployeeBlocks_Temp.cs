using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Models.HR
{
    [Table("Hr_EmployeeBlocks_Temp")]
    public class HrEmployeeBlocks_Temp
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID")]
        public long Id { get; set; }
        public long Collector_Id { get; set; }
        [MaxLength(300)]
        public string CollectorName { get; set; }
        [MaxLength(10)]
        public string BlockCode { get; set; }
        [MaxLength(200)]
        public string BlockName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public long Block_Id { get; set; }
    }
}
