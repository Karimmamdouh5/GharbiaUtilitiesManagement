using Microsoft.AspNetCore.Http;

namespace UtilitiesManagement.DataAccess.Repositories.Technician
{
    public class TechnicianWalkingLineRepository : BaseRepository<TechTechnicianWalkingLine>, ITechnicianWalkingLineRepository
    {
        
        public TechnicianWalkingLineRepository(UtilitiesDbContext context, IMapper mapper,ILoggingRepository loggingRepository, ILogger logger, IConfiguration config, IHttpContextAccessor accessor) : base(context,loggingRepository,logger,mapper,config, accessor)
        {
            
        }
    }
}
