namespace UtilitiesManagement.DataAccess.Repositories.Operation
{
    public class MeterReadingStatusRepository : BaseRepository<OprMeterStatus>, IMeterReadingStatusRepository
    {
       
        public MeterReadingStatusRepository(UtilitiesDbContext context, IMapper mapper,
                                       ILoggingRepository _loggingRepository, ILogger logger, IConfiguration config, IHttpContextAccessor accessor)
            : base(context, _loggingRepository, logger, mapper, config, accessor)
        {
           
        }
    }
}

