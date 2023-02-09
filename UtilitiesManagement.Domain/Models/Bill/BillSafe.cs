using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Models.Bill
{
    [Table("Bill_Safes")]
    public class BillSafe:BaseEntity
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }
    }
}
