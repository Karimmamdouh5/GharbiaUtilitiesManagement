using GharbiaUtilitiesManagement.DataAccess.Repositories.ExternalORMs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManagement.Domain.ViewModels.HR;

namespace UtilitiesManagement.DataAccess.Repositories.Shared
{
    public class EmployeeBlockRepository:BaseRepository<HrEmployeeBlocks>,IEmployeeBlocksRepository
    {
        public EmployeeBlockRepository(UtilitiesDbContext context, IMapper mapper, ILoggingRepository _loggingRepository, ILogger logger, IConfiguration config, IHttpContextAccessor accessor) : base(context, _loggingRepository, logger, mapper, config, accessor)
        {
            Context = context;
        }

        public UtilitiesDbContext Context { get; }

        public async Task<bool> CommitAllEmployeeBlocksChanges()
        {
            using var db = new SqlConnection(_config.GetConnectionString("WaterCompanyConnection"));
            var parms = new DynamicParameters();

            const string sql = "EXEC [dbo].[com_delta_commitAllRunnerBlocksUpdates] ";
            var result = await db.ExecuteAsync(sql);

            return true;
        }

        public async Task<IEnumerable<HrEmployeeBlocks_ViewModel>> Remote_GetRunnerBlocksData()
        {
            var totalResults = new List<HrEmployeeBlocks_ViewModel>();
            using var db = new SqlConnection(_config.GetConnectionString("UtilitiesConnection"));
            var conn = OracleConnectionManager.GetConnection();
            //await using var db = new SqlConnection(_config.GetConnectionString("WaterCompanyConnection"));

            var outCommand = db.Execute("TRUNCATE TABLE Hr_EmployeeBlocks;");

            var result1 = (conn.Query<HrEmployeeBlocks_ViewModel>("SELECT ROUTE_ID BlockID,ROUTE_ID  BlockCode ,READER_CODE CollectorID ,READER_CODE CollectorCode,CYCLE StartDate, 0 CollectorBlockIsUpdated , 1 IsReader FROM APPS.GS_HH_READING_PLAN_DETAILS_V Group by ROUTE_ID , READER_CODE , CYCLE")).ToList();
            totalResults.AddRange(result1);


            var result2 = (conn.Query<HrEmployeeBlocks_ViewModel>("SELECT ROUND_KEY BlockID,ROUND_KEY BlockCode,ASSIGNED_TO CollectorID,ASSIGNED_TO CollectorCode,BILL_PRINTED_DATE StartDate, 0 CollectorBlockIsUpdated FROM APPS.GS_GET_HH_BILLS_V group by ROUND_KEY , ASSIGNED_TO , BILL_PRINTED_DATE")).Except(result1).ToList();



            ///get employee blocks from bills temp
            //var result2 = db.Query<HrEmployeeBlocks_ViewModel>(" SELECT Block_ID,Block_ID BlockCode,[ASSIGNED_TO] CollectorID ,ASSIGNED_TO CollectorCode ,[BILL_PRINTED_DATE] StartDate, 0 CollectorBlockIsUpdated , 0 IsReader from Shar_Bills_Temp group by block_id , [ASSIGNED_TO] , [BILL_PRINTED_DATE]").ToList();
            totalResults.AddRange(result2);
            OracleConnectionManager.CloseConnection(conn);

            var GeEmployees = Context.HrEmployees.Where(x => totalResults.Select(a=>a.CollectorCode).Contains(x.Code)).ToList();
            var GetBlocks = Context.SharBlocks.ToList();

            //// Errors Forign Keys
            foreach (var item in totalResults)
            {
                var searchedEmployee = GeEmployees.FirstOrDefault(emp => emp.Code == item.CollectorCode && emp.IsReader == item.IsReader);
                var searchedBlock = GetBlocks.FirstOrDefault(x => x.BlockCode == item.BlockCode);
                item.CollectorID = searchedEmployee != null ? searchedEmployee.Id : 0;
                item.BlockID = searchedBlock != null ? searchedBlock.Id : 0;
            }

            //var RefusedEmployeeBlocks = totalResults.Where(x => x.CollectorID == 0).ToList();
            //var RefusedBlocks = totalResults.Where(x => x.BlockID == 0).ToList();

            return totalResults.Where(x => x.CollectorID != 0 && x.BlockID != 0).DistinctBy(obj => new { obj.CollectorID , obj.BlockID }).ToList();
        }
    }
}
