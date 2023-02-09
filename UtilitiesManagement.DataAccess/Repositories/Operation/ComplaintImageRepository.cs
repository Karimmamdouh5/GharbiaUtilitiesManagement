
namespace UtilitiesManagement.DataAccess.Repositories.Operation
{
    public class ComplaintImageRepository : BaseRepository<OprComplaintImage>, IComplaintImageRepository
    {
        public ComplaintImageRepository(UtilitiesDbContext context, IMapper mapper,
                                       ILoggingRepository loggingRepository, ILogger logger, IConfiguration config, IHttpContextAccessor accessor)
            : base(context, loggingRepository, logger,mapper,config, accessor)
        {
           
        }
    }
}
