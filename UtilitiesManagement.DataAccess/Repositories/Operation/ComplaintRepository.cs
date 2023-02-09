namespace UtilitiesManagement.DataAccess.Repositories.Operation
{
    public class ComplaintRepository : BaseRepository<OprComplaint>, IComplaintRepository
    {
        public ComplaintRepository(UtilitiesDbContext context, IMapper mapper,
                                       ILoggingRepository loggingRepository, ILogger logger, IConfiguration config, IHttpContextAccessor accessor)
            : base(context, loggingRepository, logger,mapper,config, accessor)
        {
           
        }
    }
}
