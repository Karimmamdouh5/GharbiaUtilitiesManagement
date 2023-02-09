using BenchmarkDotNet.Configs;
using Dapper;
using GharbiaUtilitiesManagement.Domain.Models.Shared;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace UtilitiesManagement.Services.Services.Shared
{
    public class GeneralService : IGeneralService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;
        private readonly ILoggingRepository _customLog;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _accessor;
        private readonly IConfiguration _config;

        public GeneralService(IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharLocalizer,
                                ILoggingRepository loggingRepository, IMapper mapper, IHttpContextAccessor accessor, IConfiguration config)
        {
            _unitOfWork = unitOfWork;
            _sharLocalizer = sharLocalizer;
            _customLog = loggingRepository;
            _mapper = mapper;
            _accessor = accessor;
            _config = config;
        }

        public async Task<Response<string>> LoadMainBillsTableData()
        {

            try
            {
                if (await _unitOfWork.Bills_Temp.DeleteAllData())
                {
                    var RemoteData = _mapper.Map<List<SharMainTable_Bills>>(await _unitOfWork.Bills_Temp.LoadBillTemp());
                    //var sqlConnection = new SqlConnection(_config.GetConnectionString("UtilitiesConnection"));
                    //string processQuery = "INSERT INTO Shar_Bills_Temp  ([BRANCH_NAME],[Block_Id],[ADDRESS],[ACTIVITY_TYPE],[CUSTOMER_NAME],[BILL_KEY],[BILL_PRINTED_DATE],[LAST_READING],[CURRENT_READING],[ASSIGNED_TO],[NUMBER_OF_UNITS],[BILL_AMOUNT],[CUST_KEY],[CUST_ID],[IsDeleted],[InsertDate],[UpdateDate]) " +
                    //    " VALUES (@BRANCH_NAME, @Block_Id , @ADDRESS,@ACTIVITY_TYPE,@CUSTOMER_NAME,@BILL_KEY,@BILL_PRINTED_DATE,@LAST_READING,@CURRENT_READING,@ASSIGNED_TO,@NUMBER_OF_UNITS,@BILL_AMOUNT,@CUST_KEY,@CUST_ID,0,'2022-11-01 00:00:00.000' , '2022-11-01 00:00:00.000')";
                    //sqlConnection.Execute(processQuery, RemoteData);

                    await _unitOfWork.Bills_Temp.AddRangeAsync(RemoteData);
                    await _unitOfWork.CompleteAsync();
                    await _unitOfWork.Bills_Temp.SetRestOfData();
                    return new Response<string>()
                    {
                        Data = "Done",
                        IsSuccess = true
                    };
                }
                return new Response<string>() { Data = "Failed" };
            }
            catch (Exception ex)
            {
                return new Response<string>() { Data = ex.Message };
            }
        }

        public async Task<Response<String>> ManageData()
        {


            try
            {
                var HourNow =DateTime.UtcNow.AddHours(2).Hour;
                var testing = true ;
                if(HourNow >= 1 && HourNow <= 5 || testing)
                {
                    //get the companyid from the sent token
                    var companyId = _accessor!.HttpContext == null ? null : _accessor!.HttpContext!.User.GetCompanyId();

                    //get all the new Branch data by calling the remote stored procedure and get the records after our last recordid
                    var LastBranchObject = _unitOfWork.Branches.GetFirstOrDefault(orderBy: x => x.OrderByDescending(x => x.Id));
                    var BranchData = _mapper.Map<List<SharBranch>>(await _unitOfWork.Branches.Remote_GetBranchesData(LastBranchObject != null ? LastBranchObject.Id : 0, false));
                    BranchData.ForEach(x => { x.Company_Id = (long)companyId; });
                    await _unitOfWork.Branches.AddRangeAsync(BranchData);
                    _unitOfWork.Complete();

                    //Checking Updates In Branch Data
                    var AllRemoteBranchData = _mapper.Map<List<SharBranch_Temp>>(await _unitOfWork.Branches.Remote_GetBranchesData(0, false));
                    _unitOfWork.Branchs_Temp.AddRangeAsync(AllRemoteBranchData).Wait();
                    _unitOfWork.Complete();
                    await _unitOfWork.Branches.Remote_SummitUpdates();


                    //get all the new States data by calling the remote stored procedure and get the records after our last recordid
                    var LastStateObject = _unitOfWork.State.GetFirstOrDefault(orderBy: x => x.OrderByDescending(x => x.Id));
                    var StateData = _mapper.Map<List<SharState>>(await _unitOfWork.State.Remote_GetStateData(LastStateObject != null ? LastStateObject.Id : 0, false));
                    await _unitOfWork.State.AddRangeAsync(StateData);
                    _unitOfWork.Complete();

                    //Checking Updates In State Data
                    var AllRemoteStateData = _mapper.Map<List<SharState_Temp>>(await _unitOfWork.State.Remote_GetStateData(0, false));
                    _unitOfWork.States_Temp.AddRangeAsync(AllRemoteStateData).Wait();
                    _unitOfWork.Complete();
                    await _unitOfWork.State.Remote_SummitUpdates();

                    //get all the new Cities data by calling the remote stored procedure and get the records after our last recordid
                    var LastCityObject = _unitOfWork.Cities.GetFirstOrDefault(orderBy: x => x.OrderByDescending(x => x.Id));
                    var CityData = _mapper.Map<List<SharCity>>(await _unitOfWork.Cities.Remote_GetCityData(LastCityObject != null ? LastCityObject.Id : 0, false));
                    await _unitOfWork.Cities.AddRangeAsync(CityData);
                    _unitOfWork.Complete();


                    //Checking Updates In City Data
                    var AllRemoteCityData = _mapper.Map<List<SharCity_Temp>>(await _unitOfWork.Cities.Remote_GetCityData(0, false));
                    _unitOfWork.Cities_Temp.AddRangeAsync(AllRemoteCityData).Wait();
                    _unitOfWork.Complete();
                    await _unitOfWork.Cities.Remote_SummitUpdates();

                    //get all the new Areas data by calling the remote stored procedure and get the records after our last recordid
                    var LastAreaObject = _unitOfWork.Areas.GetFirstOrDefault(orderBy: x => x.OrderByDescending(x => x.Id));
                    var AreaData = _mapper.Map<List<SharArea>>(await _unitOfWork.Areas.Remote_GetAreasData(LastAreaObject != null ? LastAreaObject.Id : 0, false));
                    await _unitOfWork.Areas.AddRangeAsync(AreaData);
                    _unitOfWork.Complete();

                    //Checking Updates In Area Data
                    var AllRemoteAreaData = _mapper.Map<List<SharArea_Temp>>(await _unitOfWork.Areas.Remote_GetAreasData(0, false));
                    _unitOfWork.Areas_Temp.AddRangeAsync(AllRemoteAreaData).Wait();
                    _unitOfWork.Complete();
                    await _unitOfWork.Areas.Remote_SummitUpdates();


                    //get all the new Blocks data by calling the remote stored procedure and get the records after our last recordid
                    var LastBlockObject = _unitOfWork.Blocks.GetFirstOrDefault(orderBy: x => x.OrderByDescending(x => x.Id));
                    var BlockData = _mapper.Map<List<SharBlock>>( _unitOfWork.Blocks.Remote_GetBlocksData(LastBlockObject != null ? LastBlockObject.Id : 0, false).Result).ToList();
                    
                    //// error
                    if(!await _unitOfWork.Areas.ExistAsync(filter: x => x.AreaName == "غير محدد"))
                    {
                        await _unitOfWork.Areas.AddAsync(new SharArea() { Id = 0, AreaName = "غير محدد", AreaCode = "غير محدد", City_Id = 101101 });
                        await _unitOfWork.CompleteAsync();
                    }
                    //// error
                    // Temp Code To Set Defaut Area Forign Keys
                    foreach (var BlockDataItem in BlockData)
                    {
                        if(BlockDataItem.Area_Id == 0 || !_unitOfWork.Areas.ExistAsync(filter: x => x.Id == BlockDataItem.Area_Id).Result)
                        {
                            BlockDataItem.Area_Id = 0;
                        }
                    }


                    _unitOfWork.Blocks.AddRangeAsync(BlockData).Wait();
                    _unitOfWork.Complete();

                    ////Checking Updates In Blocks Data
                    //var AllRemoteBlockData = _mapper.Map<List<SharBlock_Temp>>(await _unitOfWork.Blocks.Remote_GetBlocksData(0, false));
                    //_unitOfWork.Blocks_Temp.AddRangeAsync(AllRemoteBlockData).Wait();
                    //_unitOfWork.Complete();
                    //await _unitOfWork.Blocks.Remote_SummitUpdates();

                }

                return new Response<string>()
                {
                    Message = _sharLocalizer[SDLocalization.Done],
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                return new Response<string>()
                {
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] { ex.Message }
                };
            }
            

        }
    }
}
