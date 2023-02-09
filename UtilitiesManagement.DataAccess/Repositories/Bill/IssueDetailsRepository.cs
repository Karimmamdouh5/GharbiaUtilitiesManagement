using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManagement.Domain.Interfaces.Bill;
using UtilitiesManagement.Domain.ViewModels.Bills;

namespace UtilitiesManagement.DataAccess.Repositories.Bill
{
    public class IssueDetailsRepository : BaseRepository<BillIssueDetail>, IIssueDetailsRepository
    {
        public IssueDetailsRepository(UtilitiesDbContext context, IMapper mapper, ILoggingRepository _loggingRepository, ILogger logger, IConfiguration config, IHttpContextAccessor accessor) : base(context, _loggingRepository, logger, mapper, config, accessor)
        {
        }

        public async Task<bool> CommitAllIssuesDetailChanges()
        {
            using var db = new SqlConnection(_config.GetConnectionString("WaterCompanyConnection"));
            var parms = new DynamicParameters();

            const string sql = "EXEC [dbo].[com_delta_commitAllIssueDetailsUpdates] ";
            var result = await db.ExecuteAsync(sql);

            return true;
        }

        public async Task<IEnumerable<BillIssueDetails_ViewModel>> Remote_GetIssueDetailsData(long maxlength, bool IsUpdated)
        {
            await using var db = new SqlConnection(_config.GetConnectionString("WaterCompanyConnection"));
            var parms = new DynamicParameters();

            parms.Add("@MaxId", maxlength);
            parms.Add("@IsUpdated", IsUpdated == false ? null : true);
            const string sql = "[dbo].[com_delta_IssueDetails]";
            var result = await db.QueryAsync<BillIssueDetails_ViewModel>(sql, parms, commandType: CommandType.StoredProcedure);

            return result;
        }
    }
}
