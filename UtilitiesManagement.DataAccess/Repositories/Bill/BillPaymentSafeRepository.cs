using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManagement.Domain.Interfaces.Bill;

namespace UtilitiesManagement.DataAccess.Repositories.Bill
{
    public class BillPaymentSafeRepository : BaseRepository<BillPaymentSafe>, IBillPaymentSafeRepository
    {
        public BillPaymentSafeRepository(UtilitiesDbContext context, IMapper mapper, ILoggingRepository _loggingRepository, ILogger logger, IConfiguration config, IHttpContextAccessor accessor) : base(context, _loggingRepository, logger, mapper, config, accessor)
        {

        }
    }
}
