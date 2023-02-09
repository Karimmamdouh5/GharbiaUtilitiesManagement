



using Microsoft.AspNetCore.Http;

namespace UtilitiesManagement.DataAccess.Repositories.Technician
{
    public class TechnicianRepository : BaseRepository<TechTechnician>, ITechnicianRepository
    {
       
        public TechnicianRepository(UtilitiesDbContext context, IMapper mapper,ILoggingRepository loggingRepository, ILogger logger, IConfiguration config, IHttpContextAccessor accessor) : base(context,loggingRepository,logger,mapper,config, accessor)
        {
          
        }

    }
}
