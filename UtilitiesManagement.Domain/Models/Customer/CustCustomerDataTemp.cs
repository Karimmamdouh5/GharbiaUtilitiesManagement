using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Models.Customer
{
    [Table("Cust_CustomerDataTemp")]
    public class CustCustomerDataTemp : BaseEntity
    {
        [Column("ID")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [MaxLength(6)]
        public string? SubscriptionStartDate { get; set; }

        [MaxLength(50)]
        public string Code { get; set; }

        [MaxLength(250)]
        public string? Name { get; set; }

        [MaxLength(100)]
        public string? ActualName { get; set; }

        [MaxLength(200)]
        public string? ActualActivity { get; set; }
        [MaxLength(100)]
        public string CustomerStartIssue { get; set; }
        public int NumOfUnits { get; set; }
        [StringLength(50)]
        public string ActivityStarIssue { get; set; }
        public bool CustomerHasSewage { get; set; }

        [MaxLength(50)]
        public string? MeterChassisNum { get; set; }
        [MaxLength(50)]
        public string MeterDiameter { get; set; }
        public DateTime MeterStartDate { get; set; }
        public int MeterStartReading { get; set; }
        [MaxLength(50)]
        public string MeterStartIssue { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public string ImagePath { get; set; }
        public bool IsDataComplete { get; set; }
        public long Block_Id { get; set; }
        public int CustomerStatus_Id { get; set; }
        public int CustomerActivity_Id { get; set; }
        [MaxLength(50)]
        public string? PreviousReading { get; set; }
        [MaxLength(50)]
        public string? PreviousReadingIssueNumber { get; set; }
        public string? Address { get; set; }
    }
}
