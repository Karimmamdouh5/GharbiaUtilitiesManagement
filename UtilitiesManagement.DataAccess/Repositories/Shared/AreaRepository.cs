using GharbiaUtilitiesManagement.DataAccess.Repositories.ExternalORMs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.DataAccess.Repositories.Shared
{
    public class AreaRepository:BaseRepository<SharArea>, IAreaRepository
    {
        public AreaRepository(UtilitiesDbContext context, IMapper mapper, ILoggingRepository _loggingRepository, ILogger logger, IConfiguration config, IHttpContextAccessor accessor) : base(context, _loggingRepository, logger, mapper, config, accessor)
        {

        }

        public async Task<bool> CommitAllAreaChanges()
        {
            using var db = new SqlConnection(_config.GetConnectionString("WaterCompanyConnection"));
            var parms = new DynamicParameters();

            const string sql = "EXEC [dbo].[com_delta_commitAllAreaUpdates] ";
            var result = await db.ExecuteAsync(sql);

            return true;
        }

        public async Task<IEnumerable<SharArea_ViewModel>> Remote_GetAreasData(long maxlength, bool IsUpdated)
        {
            var conn = OracleConnectionManager.GetConnection();
            //await using var db = new SqlConnection(_config.GetConnectionString("WaterCompanyConnection"));

            var result = conn.Query<SharArea_ViewModel>("Select AREA_CODE AreaID , AREA_CODE AreaCode , AREA_DESC AreaName , HAYWEHDA_CODE CityId from GS_HH_ADDR_AREA_V c where c.AREA_CODE > " + maxlength);
            OracleConnectionManager.CloseConnection(conn);
            return result;
        }

        public async Task Remote_SummitUpdates()
        {
            await using var db = new SqlConnection(_config.GetConnectionString("UtilitiesConnection"));
            const string sql = "[dbo].[SubmitAreaUpdates]";
            await db.ExecuteAsync(sql, commandType: CommandType.StoredProcedure);
        }
    }
}
