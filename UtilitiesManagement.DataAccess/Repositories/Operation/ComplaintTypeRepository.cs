namespace UtilitiesManagement.DataAccess.Repositories.Operation
{
    public class ComplaintTypeRepository : BaseRepository<OprComplaintType>, IComplaintTypeRepository
    {
      
        public ComplaintTypeRepository(UtilitiesDbContext context, IMapper mapper,
                                       ILoggingRepository loggingRepository, ILogger logger, IConfiguration config, IHttpContextAccessor accessor) : base(context, loggingRepository, logger,mapper,config, accessor)
        {
            
        }
    }
}
