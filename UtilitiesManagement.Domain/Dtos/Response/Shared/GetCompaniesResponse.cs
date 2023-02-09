using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Response.Shared
{
    public class GetCompaniesResponse
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string CompanyName { get; set; }
        public string Activity { get; set; }
        public string? CommercialRecord { get; set; }
        public string? TaxCardNo { get; set; }
        public string? TaxFileNo { get; set; }
        public string? VatTaxNum { get; set; }
        public double VatTax { get; set; } = 0;
        public bool IsValTaxActive { get; set; }

        public bool HasDirectTransferForStocks { get; set; }

        public double WTax { get; set; } = 0;
        public bool IsWTaxActive { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string LogoWeb { get; set; }
        public string LogoPrint { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; } = true;
        public int MobileUsersCount { get; set; }
        public string State { get; set; }
        public string Region { get; set; }
        public int Region_Id { get; set; }
        public string ManagerName { get; set; }
        public string ManagerPosition { get; set; }
        public int Employee_Id { get; set; }
        [JsonIgnore]
        public string RoleName { get; set; }
        


    }
}
