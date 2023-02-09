namespace UtilitiesManagement.DataAccess.Repositories.Operation
{
    public class UpdetedCustomerRepository : BaseRepository<OprUpdatedCustomer>, IUpdatedCustomerRepository
    {
        public UpdetedCustomerRepository(UtilitiesDbContext context, IMapper mapper,
                                       ILoggingRepository _loggingRepository, ILogger logger, IConfiguration config, IHttpContextAccessor accessor)
            : base(context, _loggingRepository, logger,mapper,config, accessor)
        {
          
        }
    }
}
