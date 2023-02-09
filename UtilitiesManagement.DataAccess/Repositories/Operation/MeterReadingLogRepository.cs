namespace UtilitiesManagement.DataAccess.Repositories.Operation
{
    public class MeterReadingLogRepository : BaseRepository<OprMeterReadingLog>, IMeterReadingLogRepository
    {
       
        public MeterReadingLogRepository(UtilitiesDbContext context, IMapper mapper,
                                       ILoggingRepository _loggingRepository, ILogger logger, IConfiguration config, IHttpContextAccessor accessor)
            : base(context, _loggingRepository, logger, mapper, config, accessor)
        {
           
        }
    }
}

