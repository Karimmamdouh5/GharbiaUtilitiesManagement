using GharbiaUtilitiesManagement.DataAccess.Repositories.ExternalORMs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.DataAccess.Repositories.Shared
{
    public class CityRepository : BaseRepository<SharCity>, ICityRepository
    {
        public CityRepository(UtilitiesDbContext context, ILoggingRepository loggingRepository, ILogger logger, IMapper mapper, IConfiguration config, IHttpContextAccessor accessor) : base(context, loggingRepository, logger, mapper, config, accessor)
        {
        }

        public async Task<IEnumerable<SharCity_ViewModel>> Remote_GetCityData(long maxlength, bool IsUpdated)
        {
            var conn = OracleConnectionManager.GetConnection();
            //await using var db = new SqlConnection(_config.GetConnectionString("WaterCompanyConnection"));

            var result = conn.Query<SharCity_ViewModel>("select HAYWEHDA_CODE CityId,HAYWEHDA_CODE CityCode,HAYWEHDA_DESC CityName,DEFAULT_CODE StateID from GS_HH_ADDR_HAYWEHDA_V c where c.HAYWEHDA_CODE > " + maxlength);
            OracleConnectionManager.CloseConnection(conn);
            return result;
        }

        public async Task Remote_SummitUpdates()
        {
            await using var db = new SqlConnection(_config.GetConnectionString("UtilitiesConnection"));
            const string sql = "[dbo].[SubmitCitiesUpdates]";
            await db.ExecuteAsync(sql, commandType: CommandType.StoredProcedure);
        }
    }
}
