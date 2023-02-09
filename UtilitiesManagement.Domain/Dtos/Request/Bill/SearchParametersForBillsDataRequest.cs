using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace UtilitiesManagement.Domain.Dtos.Request.Bill
{
    public class SearchParametersForBillsDataRequest
    {
        public long? CustomerId { get; set; }
        public long? BranchId { get; set; }
        public int? IssueId { get; set; }
        public string? CustomerCode { get; set; }
        public long? AreaId { get; set; }
        public long? StateId { get; set; }
        public long? CityId { get; set; }
        public long? BlockId { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int PageSize { get; set; } = 5;
        public int PageNumber { get; set; } = 1;

    }
}
