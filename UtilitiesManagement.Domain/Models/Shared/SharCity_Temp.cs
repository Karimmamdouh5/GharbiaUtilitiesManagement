using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Models.Shared
{
    [Table("Shar_Cities_Temp")]
    public class SharCity_Temp : BaseEntity
    {
        [Column("ID")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        public string CityCode { get; set; }
        [MaxLength(200)]
        public string CityName { get; set; }
        public bool IsUpdated { get; set; }
        public long State_Id { get; set; }
    }
}
