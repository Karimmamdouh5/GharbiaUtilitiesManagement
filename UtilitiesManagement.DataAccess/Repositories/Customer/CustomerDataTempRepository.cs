using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.DataAccess.Repositories.Customer
{
    public class CustomerDataTempRepository : BaseRepository<CustCustomerDataTemp>, ICustomerDataTempRepository
    {
        public CustomerDataTempRepository(UtilitiesDbContext context, ILoggingRepository loggingRepository, ILogger logger, IMapper mapper, IConfiguration config, IHttpContextAccessor accessor) : base(context, loggingRepository, logger, mapper, config, accessor)
        {
        }
    }
}
