using GharbiaUtilitiesManagement.DataAccess.Repositories.ExternalORMs;

namespace UtilitiesManagement.DataAccess.Repositories.Operation
{
    public class MeterReadingRepository : BaseRepository<OprMeterReading>, IMeterReadingRepository
    {
       
        public MeterReadingRepository(UtilitiesDbContext context, IMapper mapper,
                                       ILoggingRepository _loggingRepository, ILogger logger, IConfiguration config, IHttpContextAccessor accessor)
            : base(context, _loggingRepository, logger, mapper, config, accessor)
        {
           
        }
        public async Task<bool> Remote_PostMeterReading(string cstomer_Name, string CustomerId, long issurDetails_Id, string meterStates, double readingValue, string notes, long collectorId, string userName, long deviceId, long BlockId)
        {
            var readingVal = (int) readingValue;
            var CustKey = "120/" + CustomerId + "/";
            var conn = OracleConnectionManager.GetConnection();
            //await using var db = new SqlConnection(_config.GetConnectionString("WaterCompanyConnection"));
            var DateNow = DateTime.UtcNow;
            if (meterStates == "صحيحة")
            {
                conn.Execute("insert into APPS.GS_HH_READINGS_UPLOAD_V (METER_READING,READING_DATIME,FAULT_CODE, READER_FAULT_COMMENT, EST_READING_IND , CUST_NAME ,  ROUND_ID, ROUND_KEY , CUST_KEY) values (" + readingVal + ", " + DateNow + ",''," + notes + ",0," + cstomer_Name + "," + BlockId + "," + BlockId + " , " + CustKey + ")");
            }
            else
            {
                conn.Execute("insert into APPS.GS_HH_READINGS_UPLOAD_V (METER_READING,READING_DATIME,FAULT_CODE, READER_FAULT_COMMENT, EST_READING_IND , CUST_NAME ,  ROUND_ID, ROUND_KEY, CUST_KEY) values (0, " + DateNow + "," + meterStates + "," + notes + "," + readingVal + "," + cstomer_Name + "," + BlockId + "," + BlockId + ", " + CustKey + ")");
            }
            OracleConnectionManager.CloseConnection(conn);
            return true;

        }
        public async Task<IEnumerable<PreviousReadingForCustomer_ViewModel>> GetRemotePreviousReadingForCustomersAsync(string CustomerIds, string issueDates)
        {
            var conn = OracleConnectionManager.GetConnection();
            //await using var db = new SqlConnection(_config.GetConnectionString("WaterCompanyConnection"));

            var result =  conn.Query<PreviousReadingForCustomer_ViewModel>("select CONVERT(bigint,SUBSTRING(CUST_KEY,5,LEN(CUST_KEY)-5)) CustomerId , LAST_READING PrevReading , @issueDates IssueName from APPS.GS_HH_READINGS_UPLOAD_V  where ( Convert(bigint,SUBSTRING(CUST_KEY,5,Len(CUST_KEY) - 5)) in (select CONVERT(bigint,value) from string_split(@CustomerIds,',')))", new { CustomerIds , issueDates });

            OracleConnectionManager.CloseConnection(conn);
            return result;
        }
    }
}

