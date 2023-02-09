namespace UtilitiesManagement.Services.Services.Shared
{
    public class AreaService: IAreaService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;
        private readonly IMapper _mapper;
        private readonly ILoggingRepository _customLog;
        public AreaService(IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharLocalizer,
                           IMapper mapper,ILoggingRepository loggingRepository)
        {
            _unitOfWork = unitOfWork;
            _sharLocalizer = sharLocalizer;
            _mapper = mapper;
            _customLog = loggingRepository;
        }

        public async Task<Response<IEnumerable<ListOfAreasResponse>>> GetAreasAsync(int? cityId, int? employeeId)
        {
            try
            {
                if (employeeId == null)
                {
                    return new Response<IEnumerable<ListOfAreasResponse>>()
                    {
                        Data = _mapper.Map<List<ListOfAreasResponse>>((await _unitOfWork.Areas.GetSpecificSelectAsync(filter: x => x.City_Id == cityId, select: g => new ListOfAreasResponse { Id = g.Id, Name = g.AreaName, CityId = g.City_Id}))),
                        IsSuccess = true,
                        Message = _sharLocalizer[SDLocalization.Data]
                    };
            }
              
                
                return  new Response<IEnumerable<ListOfAreasResponse>>()
                {
                    Data = (await _unitOfWork.EmployeeBlocks.GetSpecificSelectAsync(filter: x => x.Collector_Id == employeeId , select: g => new ListOfAreasResponse { Id = g.Block.Area.Id, Name = g.Block.Area.AreaName, CityId = g.Block.Area.City_Id })).ToList().DistinctBy(a => a.Id ),
                    IsSuccess = true,
                    Message = _sharLocalizer[SDLocalization.Data]
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, "");
                return new Response<IEnumerable<ListOfAreasResponse>>()
                {
                    Errors = new[] {ex.Message},
                    Message = _sharLocalizer[SDLocalization.Error]
                };
            }
        }

        public async Task<bool> ManageAreasDataAsync()
        {
            try
            {
                var LastObject = _unitOfWork.Areas.GetFirstOrDefault(orderBy: x => x.OrderByDescending(x => x.Id));
                var Data = _mapper.Map<List<SharArea>>(await _unitOfWork.Areas.Remote_GetAreasData(LastObject != null ? LastObject.Id : 0, false));
                //Data.ForEach(x => { x.City.State.Branch = null; });
                await _unitOfWork.Areas.AddRangeAsync(Data);
                var UpdattingData = _mapper.Map<List<SharArea>>(await _unitOfWork.Areas.Remote_GetAreasData(0, true)).Where(x => Data.All(y => y.Id != x.Id)).ToList();
                //UpdattingData.ForEach(x => { x.Branch = null;x.IsUpdated = false; });
                _unitOfWork.Areas.UpdateRange(UpdattingData);
                _unitOfWork.Complete();
                _unitOfWork.Areas.CommitAllAreaChanges();
                return true;
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, "");
                return false;
            }
        }
    }
}
