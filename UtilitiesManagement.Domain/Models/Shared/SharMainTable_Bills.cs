using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GharbiaUtilitiesManagement.Domain.Models.Shared
{
    [Table("Shar_Bills_Temp")]
    public class SharMainTable_Bills:BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string BRANCH_NAME { get; set; }
        public long? BRANCH_Id { get; set; }
        [StringLength(200)]
        public string Block_Id { get; set; }
        [StringLength(200)]
        public string ADDRESS { get; set; }
        [StringLength(200)]
        public string ACTIVITY_TYPE { get; set; }
        public long? ACTIVITY_TYPE_Id { get; set; }
        [StringLength(200)]
        public string CUSTOMER_NAME { get; set; }
        [StringLength(200)]
        public string BILL_KEY { get; set; }
        [StringLength(200)]
        public string BILL_PRINTED_DATE { get; set; }
        [StringLength(200)]
        public string LAST_READING { get; set; }
        [StringLength(200)]
        public string CURRENT_READING { get; set; }
        [StringLength(200)]
        public string ASSIGNED_TO { get; set; }
        [StringLength(200)]
        public string NUMBER_OF_UNITS { get; set; }
        [StringLength(200)]
        public string BILL_AMOUNT { get; set; }
        [StringLength(200)]
        public string CUST_KEY { get; set; }
        [StringLength(200)]
        public string CUST_ID { get; set; }
        public long? Bill_ID { get; set; }
    }
}
