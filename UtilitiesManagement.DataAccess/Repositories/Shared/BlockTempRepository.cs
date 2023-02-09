using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.DataAccess.Repositories.Shared
{
    public class BlockTempRepository : BaseRepository<SharBlock_Temp>, IBlockTempRepository
    {
        public BlockTempRepository(UtilitiesDbContext context, ILoggingRepository loggingRepository, ILogger logger, IMapper mapper, IConfiguration config, IHttpContextAccessor accessor) : base(context, loggingRepository, logger, mapper, config, accessor)
        {
        }
    }
}
