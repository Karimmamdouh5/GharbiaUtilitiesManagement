

using GharbiaUtilitiesManagement.DataAccess.Repositories.ExternalORMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManagement.Domain.Dtos.Request.DashBoard;
using UtilitiesManagement.Domain.ViewModels.DashBoard;
using UtilitiesManagement.Domain.ViewModels.HR;

namespace UtilitiesManagement.DataAccess.Repositories.HR
{
    public class EmployeeRepository : BaseRepository<HrEmployee>, IEmployeeRepository
    {
     
        public EmployeeRepository(UtilitiesDbContext context, IMapper mapper,ILoggingRepository loggingRepository, ILogger logger, IConfiguration config, IHttpContextAccessor accessor) : base(context,loggingRepository,logger,mapper,config, accessor)
        {
          
        }

        public async Task<bool> CommitAllEmployeeChanges()
        {
            using var db = new SqlConnection(_config.GetConnectionString("UtilitiesConnection"));

            const string sql = "EXEC [dbo].[SubmitEmployeeUpdates] ";
            var result = await db.ExecuteAsync(sql);

            return true;
        }

        public async Task<IEnumerable<HrEmployee_ViewModel>> Remote_GetRunnerData(long maxReaderId,long MaxCollectorId)
        {
            var totalResults = new List<HrEmployee_ViewModel>();
            var conn = OracleConnectionManager.GetConnection();
          
            var Query = "select OPER_CODE Code ,OPER_NAME CollectorName , BRANCH_ID  BranchID , N'قارئ-محصل' CollectorType ,0 IsUpdated , 1 IsReader from APPS.GS_HH_READERS_V where OPER_CODE > " + maxReaderId;
            var readers = conn.Query<HrEmployee_ViewModel>(Query).ToList();
            totalResults.AddRange(readers);

            var collectors = conn.Query<HrEmployee_ViewModel>("select OPER_CODE Code , OPER_NAME CollectorName , BRANCH_ID  BranchID , N'قارئ-محصل' CollectorType ,0 IsUpdated , 0 IsReader from GS_HH_COLLECTORS_V where OPER_CODE > " + MaxCollectorId ).ToList();
            totalResults.AddRange(collectors);

            OracleConnectionManager.CloseConnection(conn);
            return totalResults;
        }

        public async Task<IEnumerable<TotalMonthlyStatisticsForEmployee>> TotalDailyStatisticsForEmployee(StatisticsRequest model)
        {
            await using var db = new SqlConnection(_config.GetConnectionString("UtilitiesConnection"));
            var parms = new DynamicParameters();

            parms.Add("@StartDate", model.StartDate);
            parms.Add("@EndDate", model.EndDate);
            parms.Add("@EmployeeId", model.EmployeeId);
            const string sql = "[dbo].[Dash_TotalDailyStatisticsForEmployeeByCollectionDate]";
            var result = await db.QueryAsync<TotalMonthlyStatisticsForEmployee>(sql, parms, commandType: CommandType.StoredProcedure);

            return result;
        }

        public async Task<IEnumerable<TotalMonthlyStatisticsForEmployee>> TotalMonthlyStatisticsForEmployee(StatisticsRequest model)
        {
            await using var db = new SqlConnection(_config.GetConnectionString("UtilitiesConnection"));
            var parms = new DynamicParameters();

            parms.Add("@StartDate", model.StartDate);
            parms.Add("@EndDate", model.EndDate);
            parms.Add("@EmployeeId", model.EmployeeId);
            const string sql = "[dbo].[Dash_TotalMonthlyStatisticsForEmployeeByCollectionDate]";
            var result = await db.QueryAsync<TotalMonthlyStatisticsForEmployee>(sql, parms, commandType: CommandType.StoredProcedure);

            return result;
        }
    }
}
