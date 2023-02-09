using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.ViewModels.Bills
{
    public class BillData_ViewModel
    {
        public long Id { get; set; }
        public long CustomerID { get; set; }   
        public string CustomerCode { get; set; }    
        public string CustomerName { get; set; }   
        public string CustomerActivity { get; set; }   
        public DateTime? Isu_IsDate { get; set; }  
        public long? IssueId { get; set; }
        public string IssueName { get; set; }
        public string BillNumber { get; set; }
        public DateTime? CustomerpayingDate { get; set; }
        public DateTime? CollectingDate { get; set; }
        public double BillAmount { get; set; }
        public double WaterValue { get; set; }
        public double SewageValue { get; set; }
        public double Installment { get; set; }
        public double Others { get; set; }
        public double Maintenance { get; set; }
        public double ContenutityService { get; set; }
        public double RegularityService { get; set; }
        public double WaterInstallment { get; set; }
        public double WastewaterInstallment { get; set; }
        public double Tax14Percent { get; set; }
        public double? PrevReading { get; set; }
        public double? CurrentReading { get; set; }
        public int? BranchId { get; set; }

    }
}
