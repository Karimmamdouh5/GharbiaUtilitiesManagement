namespace UtilitiesManagement.DataAccess.Repositories.Operation
{
    public class UpdetedCustomerTypeRepository : BaseRepository<OprUpdatedCustomerType>, IUpdatedCustomerTypeRepository
    {
        public UpdetedCustomerTypeRepository(UtilitiesDbContext context, IMapper mapper,
                                       ILoggingRepository _loggingRepository, ILogger logger, IConfiguration config, IHttpContextAccessor accessor)
            : base(context, _loggingRepository, logger,mapper,config, accessor)
        {
          
        }
    }
}
