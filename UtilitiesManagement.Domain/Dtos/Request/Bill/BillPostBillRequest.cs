using System.Text.Json.Serialization;

namespace UtilitiesManagement.Domain.Dtos.Request.Bill
{
    public class BillPaymentRequest
    {
        public long Id { get; set; }
        public long CustomerData_Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerActivity { get; set; } 
        public long Employee_Id { get; set; } 
        public string Notes { get; set; }
        public DateTime PayDate { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public List<BillTransaction> Transactions { get; set; }
        [JsonIgnore]
        public bool IsRePrint { get; set; } = false;
    }
    public class  BillTransaction
    {
        public long Id { get; set; }
        public double Amount { get; set; }
        public long Bill_Id { get; set; }
        public long BillPayment_Id { get; set; }
        public BillsDataRequest Bill { get; set; }

    }    
    public class BillsDataRequest
    {
        public long Id { get; set; }
        public long Customer_Id { get; set; }
        public string BillNum { get; set; }
        public long BillIssue_Id { get; set; }
        public string? IssueName { get; set; }
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
}
