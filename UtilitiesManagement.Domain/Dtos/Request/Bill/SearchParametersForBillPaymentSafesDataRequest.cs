using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Request.Bill
{
    public class SearchParametersForBillPaymentSafesDataRequest
    {
        public long? SafeId { get; set; }
        public DateTime? PaymentSafeDate { get; set; }
        [Required]
        public int PageSize { get; set; } = 5;
        [Required]
        public int PageNumber { get; set; } = 1;

    }
}
