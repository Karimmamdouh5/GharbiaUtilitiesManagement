namespace UtilitiesManagement.DataAccess.Repositories.Customer
{
    public class CustomerStatusRepository : BaseRepository<CustCustomerStatus>, ICustomerStatusRepository
    {
        public CustomerStatusRepository(UtilitiesDbContext context, IMapper mapper,
                                        ILoggingRepository loggingRepository, ILogger logger, 
                                        IConfiguration config, IHttpContextAccessor accessor)
            : base(context, loggingRepository, logger,mapper,config, accessor)
        {
          
        }

        public async Task<bool> CommitAllRemoteCustomerStatusChangesAsync()
        {
            using var db = new SqlConnection(_config.GetConnectionString("WaterCompanyConnection"));
            var parms = new DynamicParameters();

            const string sql = "EXEC [dbo].[com_delta_commitAllRemoteCustomerStatusChanges]";
            var result = await db.ExecuteAsync(sql);

            return true;
        }

        public async Task<IEnumerable<CustCustomerStatus_ViewModel>> GetRemoteCustomerStatusAsync(long maxlength, bool isUpdated)
        {
            await using var db = new SqlConnection(_config.GetConnectionString("WaterCompanyConnection"));
            var parms = new DynamicParameters();

            parms.Add("@MaxId", maxlength);
            parms.Add("@IsUpdated", isUpdated == false ? null : true);
            const string sql = "[dbo].[com_delta_customerstatus]";
            var result = await db.QueryAsync<CustCustomerStatus_ViewModel>(sql, parms, commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
