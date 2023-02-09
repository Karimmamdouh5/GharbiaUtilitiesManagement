using GharbiaUtilitiesManagement.DataAccess.Repositories.ExternalORMs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.DataAccess.Repositories.Shared
{
    public class BlockRepository:BaseRepository<SharBlock>,IBlockRepository
    {
        public BlockRepository(UtilitiesDbContext context, IMapper mapper, ILoggingRepository _loggingRepository, ILogger logger, IConfiguration config, IHttpContextAccessor accessor) : base(context, _loggingRepository, logger, mapper, config, accessor)
        {

        }

        public async Task<bool> CommitAllBlocksChanges()
        {
            using var db = new SqlConnection(_config.GetConnectionString("WaterCompanyConnection"));
            var parms = new DynamicParameters();

            const string sql = "EXEC [dbo].[com_delta_commitAllBlocksUpdatres] ";
            var result = await db.ExecuteAsync(sql);

            return true;
        }

        public async Task<IEnumerable<SharBlock_ViewModel>> Remote_GetBlocksData(long maxlength, bool IsUpdated)
        {
            var conn = OracleConnectionManager.GetConnection();
            //await using var db = new SqlConnection(_config.GetConnectionString("WaterCompanyConnection"));


            var result = conn.Query<SharBlock_ViewModel>("select  ROUND_KEY BlockId , ROUND_KEY BlockCode , ROUND_DESC BlockName, SUBSTR(ROUND_KEY,1,9) AreaId from CIS_HH_ROUNDS_V Where ROUND_KEY NOT LIKE '%-%'  AND ROUND_ID > " + maxlength + "Group by ROUND_KEY , ROUND_DESC").ToList().DistinctBy(x => x.BlockId);
            OracleConnectionManager.CloseConnection(conn);

            var sqlConnection = new SqlConnection(_config.GetConnectionString("UtilitiesConnection"));
            sqlConnection.Execute("Update Shar_Bills_Temp  set branch_id = a.ID from Shar_Bills_Temp b , Shar_Branches a where b.branch_name=a.BranchName;");

            return result;
        }

        public async Task Remote_SummitUpdates()
        {
            await using var db = new SqlConnection(_config.GetConnectionString("UtilitiesConnection"));
            const string sql = "[dbo].[SubmitBlocksUpdates]";
            await db.ExecuteAsync(sql, commandType: CommandType.StoredProcedure);
        }
    }
}
