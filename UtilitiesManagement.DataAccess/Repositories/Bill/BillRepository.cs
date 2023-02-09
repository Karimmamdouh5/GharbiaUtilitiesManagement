using GharbiaUtilitiesManagement.DataAccess.Repositories.ExternalORMs;
using Microsoft.Extensions.Localization;
using Newtonsoft.Json;
using UtilitiesManagement.Domain;
using UtilitiesManagement.Domain.Interfaces.Bill;
using UtilitiesManagement.Domain.Untility;
using UtilitiesManagement.Domain.ViewModels.Bills;

namespace UtilitiesManagement.DataAccess.Repositories.Bill
{
    public class BillRepository:BaseRepository<BillBillsData>, IBillRepository
    {
        private readonly ILoggingRepository loggingRepository;
        private readonly ILogger _logger;

        public BillRepository(UtilitiesDbContext context, IMapper mapper, ILoggingRepository _loggingRepository, ILogger logger, IConfiguration config, IHttpContextAccessor accessor) : base(context, _loggingRepository, logger, mapper, config, accessor)
        {
            loggingRepository = _loggingRepository;
            _logger = logger;
        }

        public bool CommitAllBillChanges()
        {

            var conn = OracleConnectionManager.GetConnection();
            //using var db = new SqlConnection(_config.GetConnectionString("WaterCompanyConnection"));
            const string sql = "EXEC [dbo].[commitAllBillUpdates] ";
            //var result = db.ExecuteAsync(sql);
            conn.Execute(sql);
            OracleConnectionManager.CloseConnection(conn);
            return true;
        }
         
        public async Task<bool> PayBill(long CustomerId, string[] BillNumber, long[] BillIds, double[] BillAmount , long CollectorId, DateTime PayDate, long DeviceId)
        {
            try
            {
                var conn = OracleConnectionManager.GetConnection();
                //await using var db = new SqlConnection(_config.GetConnectionString("WaterCompanyConnection"));

                for (int i = 0; i < BillNumber.Length; i++)
                {
                    var BillKey = BillNumber[i];
                    var BillValue = BillAmount[i];
                    var BillId = BillIds[i];
                    var PaymentType = "نقدي";

                    conn.Execute("Insert into GS_HH_BILL_PAYMENT_TYPES_V ([BILL_KEY] , [PAYMENT_TYPE] , [PAID_AMOUNT] , [MASS_DEPOSIT_ID] , [MASS_COLLECTION_ID]) values (@BillKey ,@PaymentType,@BillValue,@BillId,@DeviceId)"
                        , new { BillKey , PaymentType , BillValue , BillId , DeviceId });
                }
                OracleConnectionManager.CloseConnection(conn);
                return true;
            }
            catch (Exception ex)
            {
                await loggingRepository.LogExceptionInDb(ex,"Bill Not Pay BillNumbers:"+ BillIds);
                return false;
            }
        }

        public async Task<IEnumerable<BillData_ViewModel>> Remote_GetBillData(long EmployeeId, string BlockIds)
        {
            // await using var db = new SqlConnection(_config.GetConnectionString("WaterCompanyConnection"));
            string EmployeeCode = _context.HrEmployees.FindAsync(EmployeeId).Result.Code;
            var conn = OracleConnectionManager.GetConnection();
            //// error step1 long time where ger bills from oracle

            var queryS = "Select '88'+SUBSTR(Bill_Key,5,LENGTH(Bill_Key)-5) Id , ACTIVITY_TYPE CustomerActivity ,branch_id BranchId , INST_ID CustomerID,Cust_Key CustomerCode,CUSTOMER_NAME CustomerName,BILL_PRINTED_DATE Isu_IsDate,0 IssueId,BILL_PRINTED_DATE IssueName,BILL_KEY BillNumber ,BILL_AMOUNT BillAmount,WATER_CONSUMPTION WaterValue,0 SewageValue ,0 Installment,0 Others,0 Maintenance,0 ContenutityService,0 RegularityService,0 WaterInstallment,0 WastewaterInstallment,0 Tax14Percent,LAST_READING PrevReading,ROUNDING_VAL CurrentReading from(select * from APPS.GS_GET_HH_BILLS_V where ASSIGNED_TO =" + EmployeeCode + " and  (ROUND_KEY in (" + BlockIds + ") ) ) Bill ";        
            //var queryS = "Select '88'+SUBSTR(Bill_Key,5,LENGTH(Bill_Key)-5) Id, ACTIVITY_TYPE CustomerActivity ,Branch.BRANCH_CODE BranchId , 0 CustomerID,Cust_Key CustomerCode,CUSTOMER_NAME CustomerName,BILL_PRINTED_DATE Isu_IsDate,0 IssueId,BILL_PRINTED_DATE IssueName,BILL_KEY BillNumber ,BILL_AMOUNT BillAmount,WATER_CONSUMPTION WaterValue,0 SewageValue ,0 Installment,0 Others,0 Maintenance,0 ContenutityService,0 RegularityService,0 WaterInstallment,0 WastewaterInstallment,0 Tax14Percent,LAST_READING PrevReading,ROUNDING_VAL CurrentReading from(select * from APPS.GS_GET_HH_BILLS_V where ASSIGNED_TO =" + EmployeeCode + " and  (ROUND_KEY in (" + BlockIds + ") ) ) Bill left join  APPS.GS_HH_ADDR_BRANCH_V Branch on Branch.BRANCH_DESC = Bill.BRANCH_NAME";
            var result =  conn.Query<BillData_ViewModel>(queryS);
            OracleConnectionManager.CloseConnection(conn);

            await using var ourDb = new SqlConnection(_config.GetConnectionString("UtilitiesConnection"));
            //string QueryS = "select Bill_ID Id ,ACTIVITY_TYPE CustomerActivity ,CUST_ID CustomerID,CUST_KEY CustomerCode ,CUSTOMER_NAME CustomerName, BILL_PRINTED_DATE Isu_IsDate,0 IssueId,BILL_PRINTED_DATE IssueName,BILL_KEY BillNumber,BILL_AMOUNT BillAmount,0 WaterValue,0 SewageValue , 0 Installment,0 Others,0 Maintenance,0 ContenutityService,0 RegularityService,0 WaterInstallment,0 WastewaterInstallment, 0 Tax14Percent,LAST_READING PrevReading,CURRENT_READING CurrentReading, issue.ID IssueId from Shar_Bills_Temp b left join Bill_Issues issue on issue.IssueName = b.BILL_PRINTED_DATE where ASSIGNED_TO =" + EmployeeCode + " and  (block_id in (" + BlockIds + ") )";
            //var result = await ourDb.QueryAsync<BillData_ViewModel>(QueryS);

            //// error step2 long time where ger bills from oracle
            var allExistingIssues = await ourDb.QueryAsync<SelectListResponseWithDate>("select Issue.ID Id, Issue.IssueDate [Date] from [dbo].[Bill_Issues] Issue ");
            foreach (var BillItem in result)
            {
                var issueVal = allExistingIssues.FirstOrDefault(obj => obj.Date == BillItem.Isu_IsDate /*&& obj.BranchId == BillItem.BranchId*/);
                BillItem.IssueId = issueVal != null ? issueVal.Id : 0;
            }

            return result;
        }


    }
}
