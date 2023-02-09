using Microsoft.AspNetCore.Http;

namespace UtilitiesManagement.DataAccess.Repositories.Shared
{
    public class DailyStatisticsReportRepository : BaseRepository<BillIssue>, IDailyStatisticsReportRepository
    {
        public DailyStatisticsReportRepository(UtilitiesDbContext context, IMapper mapper, ILoggingRepository
                                               _loggingRepository, ILogger logger, IConfiguration config, IHttpContextAccessor accessor)
            : base(context, _loggingRepository, logger, mapper, config, accessor)

        {

        }

        public async Task<IEnumerable<SharTotalDailyStatisticsReportResponse>> GetTotalDailyStatisticsAsync(SharDailyStatisticsSearchParametersRequest dailyStatisticsSearchParametersRequest)
        {
            await using var db = new SqlConnection(_config.GetConnectionString("UtilitiesConnection"));
            var parms = new DynamicParameters();

            parms.Add("@CompanyId", dailyStatisticsSearchParametersRequest.CompanyId);
            parms.Add("@StartDate", dailyStatisticsSearchParametersRequest.StartDate);
            parms.Add("@EndDate", dailyStatisticsSearchParametersRequest.EndDate);

            const string sql = "[dbo].[Dash_TotalDailyStatistics]";
            var result = await db.QueryAsync<SharTotalDailyStatisticsReportResponse>(sql, parms, commandType: CommandType.StoredProcedure);

            return result;
        }


        public async Task<(IEnumerable<SharTotalDailyStatisticsPerEmployeeReport>, int totalRecords)>
            GetTotalDailyStatisticsPerEmployeeAsync(SharDailyStatisticsSearchParametersForDBRequest model)
        {
            await using var db = new SqlConnection(_config.GetConnectionString("UtilitiesConnection"));
            var parms = new DynamicParameters();

            parms.Add("@CompanyId", model.CompanyId);
            parms.Add("@StartDate", model.StartDate);
            parms.Add("@EndDate", model.EndDate);
            parms.Add("@TookNum", model.Take);
            parms.Add("@SkippedNum", model.Skip);
            parms.Add("@TotalRecords", DbType.Int32, direction: ParameterDirection.Output);


            const string sql = "[dbo].[Dash_TotalDailyStatisticsPerEmployee]";
            var result =  await db.QueryAsync<SharTotalDailyStatisticsPerEmployeeReport>(sql, parms, commandType: CommandType.StoredProcedure);

            return (result, parms.Get<int>("TotalRecords"));
        }

        public async Task<IEnumerable<SharTotalDailyStatisticsForEmployeeReportResponse>> GetTotalDailyStatisticsForEmployeeAsync(SharDailyStatisticsSearchParametersForEmployee model)
        {
            await using var db = new SqlConnection(_config.GetConnectionString("UtilitiesConnection"));
            var parms = new DynamicParameters();

            parms.Add("@EmployeeId", model.EmployeeId);
            parms.Add("@StartDate", model.StartDate.ToString("yyyy/MM/dd"));
            parms.Add("@EndDate", model.EndDate.ToString("yyyy/MM/dd"));

            const string sql = "[dbo].[Dash_TotalDailyStatisticsForEmployeeByCollectionDate]";
            var result = await db.QueryAsync<SharTotalDailyStatisticsForEmployeeReportResponse>(sql, parms, commandType: CommandType.StoredProcedure);

            return result;
        }
    }
}
