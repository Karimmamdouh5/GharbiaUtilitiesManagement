using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Models.Shared
{
    [Table("Shar_Cities")]
    public class SharCity : BaseEntity
    {
        [Column("ID")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        public string CityCode { get; set; }
        [MaxLength(200)]
        public string CityName { get; set; }
        public bool IsUpdated { get; set; }
        public long State_Id { get; set; }
        [ForeignKey(nameof(State_Id))]
        public SharState State { get; set; }
        public ICollection<SharArea> Areas { get; set; }
    }
}
