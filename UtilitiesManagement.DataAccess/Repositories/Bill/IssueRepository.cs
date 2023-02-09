
using GharbiaUtilitiesManagement.DataAccess.Repositories.ExternalORMs;

namespace UtilitiesManagement.DataAccess.Repositories.Bill
{
    public class IssueRepository:BaseRepository<BillIssue>,IIssueRepository
    {
        public IssueRepository(UtilitiesDbContext context, IMapper mapper, ILoggingRepository _loggingRepository, ILogger logger, IConfiguration config, IHttpContextAccessor accessor) : base(context, _loggingRepository, logger, mapper, config, accessor)
        {

        }

        public async Task<bool> CommitAllIssuesChanges(DateTime LastIssueDate)
        {
            using var db = new SqlConnection(_config.GetConnectionString("UtilitiesConnection"));
            var parms = new DynamicParameters();
            parms.Add("@BILL_PRINTED_DATE", LastIssueDate);
            const string sql = "[dbo].[SubmitIssueFromTblBills]";
            var result =await db.ExecuteAsync(sql, parms, commandType: CommandType.StoredProcedure);

            return true;
        }

        public async Task<IEnumerable<BillIssue_ViewModel>> Remote_GetIssueData(long maxlength, bool IsUpdated)
        {
            await using var db = new SqlConnection(_config.GetConnectionString("WaterCompanyConnection"));
            var parms = new DynamicParameters();

            parms.Add("@MaxId", maxlength);
            parms.Add("@IsUpdated", IsUpdated == false ? null : true);
            const string sql = "[dbo].[com_delta_MasterIssue]";
            var result = await db.QueryAsync<BillIssue_ViewModel>(sql, parms, commandType: CommandType.StoredProcedure);

            return result;
        }

        public async Task<IEnumerable<BillIssueReportResponse>> GetTopTwelveIssuesAsync(long companyId)
        {
            await using var db = new SqlConnection(_config.GetConnectionString("UtilitiesConnection"));
            var parms = new DynamicParameters();

            parms.Add("@CompanyId", companyId);
            const string sql = "[dbo].[Dash_TopTwelveIssuesAndTheirStatus]";
            var result = await db.QueryAsync<BillIssueReportResponse>(sql, parms, commandType: CommandType.StoredProcedure);

            return result;
        }
        public async Task<IEnumerable<RemoteBillData_ViewModel>> RemoteDataLoading()
        {
            var conn = OracleConnectionManager.GetConnection();

            //await using var db = new SqlConnection(_config.GetConnectionString("WaterCompanyConnection"));
            var result = conn.Query<RemoteBillData_ViewModel>("select BILL_PRINTED_DATE IssueDate, Branch_Id  from APPS.GS_GET_HH_BILLS_V Bill  Group by Bill.BILL_PRINTED_DATE , Bill.Branch_Id");

            OracleConnectionManager.CloseConnection(conn);
            return result;
        }
    }
}
