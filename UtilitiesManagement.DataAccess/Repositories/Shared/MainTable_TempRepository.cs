using GharbiaUtilitiesManagement.DataAccess.Repositories.ExternalORMs;
using GharbiaUtilitiesManagement.Domain.Interfaces.Shared;
using GharbiaUtilitiesManagement.Domain.Models.Shared;
using GharbiaUtilitiesManagement.Domain.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GharbiaUtilitiesManagement.DataAccess.Repositories.Shared
{
    public class MainBillsTempRepository : BaseRepository<SharMainTable_Bills>, IMainBillsTempRepository
    {
        public MainBillsTempRepository(UtilitiesDbContext context, ILoggingRepository loggingRepository, ILogger logger, IMapper mapper, IConfiguration config, IHttpContextAccessor accessor) : base(context, loggingRepository, logger, mapper, config, accessor)
        {
        }

        public async Task<bool> DeleteAllData()
        {
            try
            {
                var sqlConnection = new SqlConnection(_config.GetConnectionString("UtilitiesConnection"));
                sqlConnection.Execute("TRUNCATE TABLE Shar_Bills_Temp");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<SharMainTable_Bills_ViewModel>> LoadBillTemp()
        {
            try
            {
                var oracleConnection = OracleConnectionManager.GetConnection();

                var Query = "select BRANCH_NAME  , ROUND_KEY Block_Id, ADDRESS , ACTIVITY_TYPE , CUSTOMER_NAME , BILL_KEY , BILL_PRINTED_DATE , LAST_READING , CURRENT_READING , ASSIGNED_TO , NUMBER_OF_UNITS ,BILL_AMOUNT ,CUST_KEY , CUST_ID   from GS_GET_HH_BILLS_V Where ROWNUM < 1000000 ";
                var Data = oracleConnection.Query<SharMainTable_Bills_ViewModel>(Query).ToList();
                OracleConnectionManager.CloseConnection(oracleConnection);
                return Data;
            }
            catch (Exception ex)
            {
                return new List<SharMainTable_Bills_ViewModel>();
            }
        }

        public async Task<bool> SetRestOfData()
        {
            try
            {
                var sqlConnection = new SqlConnection(_config.GetConnectionString("UtilitiesConnection"));
                sqlConnection.Execute("Update Shar_Bills_Temp  set ACTIVITY_TYPE_Id = a.ID from Shar_Bills_Temp b , Cust_CustomerActivities a where b.activity_type=a.[Name];Update Shar_Bills_Temp set Bill_ID = SUBSTRING(BILL_KEY,5,len(BILL_KEY) -5);Update Shar_Bills_Temp  set branch_id = a.ID from Shar_Bills_Temp b , Shar_Branches a where b.branch_name=a.BranchName;");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
