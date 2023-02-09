

using Microsoft.AspNetCore.Http;

namespace UtilitiesManagement.DataAccess.Repositories.Shared
{
    public class CompanyRepository : BaseRepository<SharCompany>, ICompanyRepository
    {
      
        public CompanyRepository(UtilitiesDbContext context, IMapper mapper, ILoggingRepository loggingRepository, ILogger logger, IConfiguration config, IHttpContextAccessor accessor) : base(context,loggingRepository, logger,mapper,config, accessor)
        {
           
        }
        
    }
}
