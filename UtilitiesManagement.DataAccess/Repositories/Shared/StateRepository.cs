using GharbiaUtilitiesManagement.DataAccess.Repositories.ExternalORMs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.DataAccess.Repositories.Shared
{
    public class StateRepository : BaseRepository<SharState>, IStateRepository
    {
        public StateRepository(UtilitiesDbContext context, ILoggingRepository loggingRepository, ILogger logger, IMapper mapper, IConfiguration config, IHttpContextAccessor accessor) : base(context, loggingRepository, logger, mapper, config, accessor)
        {
        }
        public async Task<IEnumerable<SharState_ViewModel>> Remote_GetStateData(long maxlength, bool IsUpdated)
        {
            var conn = OracleConnectionManager.GetConnection();
            //await using var db = new SqlConnection(_config.GetConnectionString("WaterCompanyConnection"));

            var result = conn.Query<SharState_ViewModel>("select DEFAULT_CODE StateId,DEFAULT_CODE StateCode,DEFAULT_DESC StateName,BRANCH_CODE Branch_Id from GS_HH_ADDR_DEFAULT_V state where state.DEFAULT_CODE > " + maxlength);
            OracleConnectionManager.CloseConnection(conn);

            return result;
        }

        public async Task Remote_SummitUpdates()
        {
            await using var db = new SqlConnection(_config.GetConnectionString("UtilitiesConnection"));
            const string sql = "[dbo].[SubmitStateUpdates]";
            await db.ExecuteAsync(sql, commandType: CommandType.StoredProcedure);
        }
    }
}
