using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GharbiaUtilitiesManagement.Domain.ViewModels.Shared
{
    public class SharMainTable_Bills_ViewModel
    {
        public string BRANCH_NAME { get; set; } = "";
        public string Block_Id { get; set; } 
        public string ADDRESS { get; set; } = "";
        public string ACTIVITY_TYPE { get; set; } = "";
        public string CUSTOMER_NAME { get; set; } 
        public string BILL_KEY { get; set; }
        public string BILL_PRINTED_DATE { get; set; } = DateTime.Now.ToShortTimeString();
        public string LAST_READING { get; set; } = "0";
        public string CURRENT_READING { get; set; } = "0";
        public string ASSIGNED_TO { get; set; } 
        public string NUMBER_OF_UNITS { get; set; } = "0";
        public string BILL_AMOUNT { get; set; } = "0";
        public string CUST_KEY { get; set; }
        public string CUST_ID { get; set; } 
    }
}
