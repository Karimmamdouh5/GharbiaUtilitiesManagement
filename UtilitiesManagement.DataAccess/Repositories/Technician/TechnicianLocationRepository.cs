using Microsoft.AspNetCore.Http;

namespace UtilitiesManagement.DataAccess.Repositories.Technician
{
    public class TechnicianLocationRepository : BaseRepository<TechTechnicianLocation>, ITechnicianLocationRepository
    {
        public TechnicianLocationRepository(UtilitiesDbContext context, IMapper mapper,
                                            ILoggingRepository loggingRepository,
                                            ILogger logger, IConfiguration config, IHttpContextAccessor accessor) : base(context, loggingRepository, logger,mapper,config, accessor)
        {}
    }
}
