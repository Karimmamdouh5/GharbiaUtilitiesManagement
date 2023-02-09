using GharbiaUtilitiesManagement.Domain.Interfaces.Bill;
using UtilitiesManagement.Domain.Models.Bill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GharbiaUtilitiesManagement.DataAccess.Repositories.Bill
{
    public class BillSafesRepository : BaseRepository<BillSafe>, IBillSafesRepository
    {
        public BillSafesRepository(UtilitiesDbContext context, IMapper mapper, ILoggingRepository _loggingRepository, ILogger logger, IConfiguration config, IHttpContextAccessor accessor) : base(context, _loggingRepository, logger, mapper, config, accessor)
        {


        }
    }
}
