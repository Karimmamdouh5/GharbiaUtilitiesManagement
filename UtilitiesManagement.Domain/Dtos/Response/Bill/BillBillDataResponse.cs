using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManagement.Domain.Dtos.Request.Bill;

namespace UtilitiesManagement.Domain.Dtos.Response.Bill
{
    public class BillDataResponse
    {
        public long Id { get; set; }
        public long CustomerData_Id { get; set; }
        public long Employee_Id { get; set; }
        public string Notes { get; set; }
        public DateTime PayDate { get; set; }
        public string  CustomerCode { get; set; }
        public string  Branch { get; set; }
        public string  Area { get; set; }
        public string  Block { get; set; }
        public string  CustomerName { get; set; }
        public string CollectorName { get; set; }
        public List<BillTransactionResponse> BillTransactions { get; set; }
        public double TotalAmount{ get; set; }
        public bool IsRePrint { get; set; }
        public bool IsPayment { get; set; }
    }
    public class BillTransactionResponse
    {
        public long Id { get; set; }
        public double Amount { get; set; }
        public long Bill_Id { get; set; }
        public long BillPayment_Id { get; set; }
        public long Customer_Id { get; set; }
        public string BillNum { get; set; }
        public long BillIssue_Id { get; set; }
        public string BillIssueName { get; set; }
        public DateTime PayDate { get; set; }
        public double BillValue { get; set; }
        public double WaterValue { get; set; }
        public double Installment { get; set; }
        public double Others { get; set; }
        public double Maintenance { get; set; }
        public double ContenutityService { get; set; }
        public double RegularityService { get; set; }
        public double WaterInstallment { get; set; }
        public double WastWaterInstallment { get; set; }
        public double Tax14Percent { get; set; }
        public DateTime? CustomerPayingDate { get; set; } = null;
        public double PrevReading { get; set; }
        public double CurrentReading { get; set; }

    }
    public class BillDataResponseWithPaggination
    {
        public List<BillDataResponse> data { get; set; }
        public int TotalCount { get; set; }
    } 
}
