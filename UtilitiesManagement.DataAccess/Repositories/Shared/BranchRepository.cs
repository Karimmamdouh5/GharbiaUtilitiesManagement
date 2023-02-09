
using GharbiaUtilitiesManagement.DataAccess.Repositories.ExternalORMs;
using Microsoft.AspNetCore.Http;

namespace UtilitiesManagement.DataAccess.Repositories.Shared
{
    public class BranchRepository : BaseRepository<SharBranch>, IBranchRepository
    {
        
        public BranchRepository(UtilitiesDbContext context, IMapper mapper, ILoggingRepository _loggingRepository, ILogger logger, IConfiguration config, IHttpContextAccessor accessor) : base(context, _loggingRepository,logger,mapper, config, accessor)
        {
           
        }

        public async Task<bool> CommitAllBranchsChanges()
        {
            using var db = new SqlConnection(_config.GetConnectionString("WaterCompanyConnection"));
            var parms = new DynamicParameters();

            const string sql = "EXEC [dbo].[com_delta_commitAllBranchesUpdatres]";
            var result =await db.ExecuteAsync(sql);

            return true;
        }

        public async Task<IEnumerable<SharBranch_ViewModel>> Remote_GetBranchesData(long maxlength,bool IsUpdated)
        {
            var conn = OracleConnectionManager.GetConnection();
            //await using var db = new SqlConnection(_config.GetConnectionString("WaterCompanyConnection"));

            var result = conn.Query<SharBranch_ViewModel>("select BRANCH_CODE BranchID,BRANCH_DESC BranchName,BRANCH_CODE BranchCode,COMPANY_CODE CompanyId from GS_HH_ADDR_BRANCH_V WHERE BRANCH_CODE  > " + maxlength);
            OracleConnectionManager.CloseConnection(conn);
            return  result;
        }

        public async Task Remote_SummitUpdates()
        {
            await using var db = new SqlConnection(_config.GetConnectionString("UtilitiesConnection"));
            const string sql = "[dbo].[SubmitBranchUpdates]";
            await db.ExecuteAsync(sql, commandType: CommandType.StoredProcedure);
        }
    }
}
