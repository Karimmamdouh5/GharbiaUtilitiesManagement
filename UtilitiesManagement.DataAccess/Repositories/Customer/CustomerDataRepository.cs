using GharbiaUtilitiesManagement.DataAccess.Repositories.ExternalORMs;
using UtilitiesManagement.Domain.Dtos.Request.DashBoard;

namespace UtilitiesManagement.DataAccess.Repositories.Customer
{
    public class CustomerDataRepository : BaseRepository<CustCustomerData>, ICustomerDataRepository
    {
        public CustomerDataRepository(UtilitiesDbContext context, IMapper mapper,
                                      ILoggingRepository loggingRepository, ILogger logger,
                                      IConfiguration config, IHttpContextAccessor accessor)
            : base(context, loggingRepository, logger, mapper, config, accessor)
        {
        }

        public async Task<bool> CommitAllRemoteCustomerDataChanges()
        {
            using var db = new SqlConnection(_config.GetConnectionString("UtilitiesConnection"));

            const string sql = "EXEC [dbo].[SubmitCustomerUpdates]";
            var result = await db.ExecuteAsync(sql);

            return true;
        }

        public async Task<IEnumerable<CustCustomerData_ViewModel>> GetRemoteCustomerDataAsync(long LastId)
        {
            try
            {
                var conn = OracleConnectionManager.GetConnection();
                //await using var db = new SqlConnection(_config.GetConnectionString("UtilitiesConnection"));
                //var parms = new DynamicParameters();
                //parms.Add("@LastId", LastId);
                //var result =  await db.ExecuteAsync("[dbo].[SubmitCustomersFromTblBills]", parms, commandType: CommandType.StoredProcedure);

                var Query = "select INST_ID Id ,Cust_key Code,concat(concat( CUSTOMER_NAME , N'رقم الوحدة :') ,INST_ID )Name,CUSTOMER_NAME ActualName,'' CustomerStartIssue,ROUND_KEY Block_Id,NUMBER_OF_UNITS NumOfUnits,ACTIVITY_TYPE  ActualActivity,1 CustomerStatus_Id,N'سارى' CustStatus,1 CustomerHasSewage,'' ActivityStarIssue,'' MeterChassisNum,'' MeterDiameter, '2023-01-01 16:28:36.7058860' MeterStartDate, 0 MeterStartReading, '' MeterStartIssue, '' ImagePath, '' Address from ( select  INST_ID  , BILL_PRINTED_DATE , Cust_key ,CUSTOMER_NAME,ROUND_KEY , ACTIVITY_TYPE , rank () over (partition by  INST_ID  order by BILL_PRINTED_DATE desc) as rnk from GS_GET_HH_BILLS_V where INST_ID > " + LastId + ")  BillsTable where BillsTable.rnk = 1 and ROUND_KEY in (select ROUND_KEY from CIS_HH_ROUNDS_V)";
                var result = conn.Query<CustCustomerData_ViewModel>(Query);
                OracleConnectionManager.CloseConnection(conn);
                //var workingQueryData = result.Take(300);
                /*       foreach (var item in result)
                       {
                           var QueryInsert = $"insert into Testing_Data values (N'{item.Id}' , N'{item.Code}' , N'{item.Name}' , N'{item.ActualName}' , N'{item.ActualActivity}' , N'{item.CustomerStartIssue}' , N'{item.NumOfUnits}' , N'{item.ActivityStarIssue}' , N'{item.CustomerHasSewage}' ,N'{item.MeterChassisNum}' , N'{item.MeterDiameter}' , N'{item.MeterStartDate}' , N'{item.MeterStartReading}' , N'{item.MeterStartIssue}' , N'{item.ImagePath}' , N'{item.Block_Id}' , N'{item.CustomerStatus_Id}' , N'{item.CustomerActivity_Id}' , N'{item.Address}')";
                           db.Execute(QueryInsert);
                       }
                */

                return result;
            }
            catch (Exception ex)
            {
                return new List<CustCustomerData_ViewModel>();
            }
        }
        public async Task<IEnumerable<GetCustomersTotalBills_ViewModel>> GetCustomersTotalBillsAsync(long Collector_Id, string BlockIds)
        {
           
            var conn = OracleConnectionManager.GetConnection();
            var CollectorCode = _context.HrEmployees.FindAsync(Collector_Id).Result.Code;
            //await using var db = new SqlConnection(_config.GetConnectionString("UtilitiesConnection"));
            //// error step3

            var result = conn.Query<GetCustomersTotalBills_ViewModel>("select INST_ID CustomerID , Count(*) BillsCounts , Sum(BILL_AMOUNT) BillsTotalAmount from APPS.GS_GET_HH_BILLS_V where ASSIGNED_TO =" + CollectorCode + " and  (ROUND_KEY in (" + BlockIds + ") )  Group by INST_ID"); OracleConnectionManager.CloseConnection(conn);
            //var result =  db.Query<GetCustomersTotalBills_ViewModel>("select Cust_Id CustomerID , Count(*) BillsCounts , Sum(cast(BILL_AMOUNT as decimal)) BillsTotalAmount from Shar_Bills_Temp where ASSIGNED_TO = "+CollectorCode+" and Block_Id in ("+BlockIds+ ") Group by Cust_Id");
            return result;
        }

        public async Task<IEnumerable<totalBillsOfCollector>> GetRemoteCustomerBillsCount(DashBoardCustomerBillsStatRequest model)
        {
            await using var db = new SqlConnection(_config.GetConnectionString("WaterCompanyConnection"));
            var parms = new DynamicParameters();

            parms.Add("@CollectorId", model.Collector_Id != null ? model.Collector_Id : null);
            parms.Add("@IssueDate", model.IssueDate != null ? model.IssueDate : null);
            parms.Add("@BranchId", model.Collector_Id == null && model.IssueDate == null ? model.Branch_Id : null);
            const string sql = "[dbo].[com_delta_totalBillsOfCustomers]";
            var result = await db.QueryAsync<totalBillsOfCollector>(sql, parms, commandType: CommandType.StoredProcedure);
            return result;
        }
        public async Task<bool> UpdateCustomer(long Customer_Id, string CustomerName, string CustomerActivity)
        {
            await using var db = new SqlConnection(_config.GetConnectionString("UtilitiesConnection"));

            var parms = new DynamicParameters();
            parms.Add("@CustomerId", Customer_Id);
            parms.Add("@CustomerName", CustomerName);
            parms.Add("@CustomerActivity", CustomerActivity);

            const string sql = "[dbo].[UpdateCustomerData]";
            var result = await db.ExecuteAsync(sql, parms,commandType:CommandType.StoredProcedure);

            return true;
        }
    }
}
