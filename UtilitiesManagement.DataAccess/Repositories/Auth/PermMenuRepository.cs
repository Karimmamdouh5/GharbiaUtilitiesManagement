using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.DataAccess.Repositories.Auth
{
    public class PermMenuRepository : BaseRepository<PermMenu>, IPermMenuRepository
    {
        public PermMenuRepository(UtilitiesDbContext context, IMapper mapper, ILoggingRepository
                                               _loggingRepository, ILogger logger, IConfiguration config, IHttpContextAccessor accessor)
            : base(context, _loggingRepository, logger, mapper, config, accessor)
        {
        }
    }
}
