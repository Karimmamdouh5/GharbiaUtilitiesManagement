using GharbiaUtilitiesManagement.DataAccess.Repositories.ExternalORMs;

namespace UtilitiesManagement.DataAccess.Repositories.Customer
{
    public class CustomerActivityRepository : BaseRepository<CustCustomerActivity>, ICustomerActivityRepository
    {
        public CustomerActivityRepository(UtilitiesDbContext context, IMapper mapper,
                                          ILoggingRepository loggingRepository, ILogger logger, 
                                          IConfiguration config, IHttpContextAccessor accessor)
            : base(context, loggingRepository, logger,mapper,config, accessor)
        {         
        }

        public async Task<bool> CommitAllRemoteCustomerActivityChangesAsync()
        {
            using var db = new SqlConnection(_config.GetConnectionString("WaterCompanyConnection"));
            var parms = new DynamicParameters();

            const string sql = "EXEC [dbo].[com_delta_commitAllRemoteCustomerActivityChanges]";
            var result = await db.ExecuteAsync(sql);

            return true;
        }

        public async Task<IEnumerable<CustCustomerActivity_ViewModel>> GetRemoteCustomerActivityAsync()
        {
            var conn = OracleConnectionManager.GetConnection();
            //await using var db = new SqlConnection(_config.GetConnectionString("WaterCompanyConnection"));
            
            var result =  conn.Query<CustCustomerActivity_ViewModel>("select ROWNUM Id ,  ACTIVITY_CODE Name from APPS.GS_HH_MAIN_ACTIVITY_V");

            OracleConnectionManager.CloseConnection(conn);
            return result;
        }
    }
}
