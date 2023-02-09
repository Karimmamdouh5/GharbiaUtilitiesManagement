namespace UtilitiesManagement.Services.Services.Shared
{
    public class BlockService : IBlockService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;
        private readonly ILoggingRepository _customLog;
        private readonly IMapper _mapper;
        public BlockService(IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharLocalizer,
                                ILoggingRepository loggingRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _sharLocalizer = sharLocalizer;
            _customLog = loggingRepository;
            _mapper = mapper;
        }
        public async Task<Response<IEnumerable<ListOfBlocksResponse>>> GetBlocksAsync(int? AreaId, int? employeeId)
        {
            try
            {
                if (employeeId == null)
                {
                    return new Response<IEnumerable<ListOfBlocksResponse>>()
                    {
                        Data = (await _unitOfWork.Blocks.GetSpecificSelectAsync(filter: x => x.Area_Id == AreaId, select: g => new ListOfBlocksResponse { Id = g.Id, Name = g.BlockName, AreaId = g.Area_Id })),
                        Message = _sharLocalizer[SDLocalization.Data],
                        IsSuccess = true
                    };
                }
                return new Response<IEnumerable<ListOfBlocksResponse>>()
                {
                    Data = (await _unitOfWork.EmployeeBlocks.GetSpecificSelectAsync(filter: x => x.Collector_Id == employeeId , select: g => new ListOfBlocksResponse { Id = g.Block.Id, Name = g.Block.BlockName, AreaId = g.Block.Area_Id })),
                    Message = _sharLocalizer[SDLocalization.Data],
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, "");
                return new Response<IEnumerable<ListOfBlocksResponse>>()
                {
                    Errors = new[] { ex.Message },
                    Message = _sharLocalizer[SDLocalization.Error]
                };
            }
        }
        public async Task<Response<IEnumerable<ListOfBlocksResponse>>> GetBlocksByEmployeeAsync(long employeeId)
        {
            try
            {
                return new Response<IEnumerable<ListOfBlocksResponse>>()
                {
                    Data = (await _unitOfWork.EmployeeBlocks.GetSpecificSelectAsync(filter: x => x.Collector_Id == employeeId && x.EndDate >= DateTime.UtcNow.AddHours(2), select: g => new ListOfBlocksResponse { Id = g.Id, Name = g.Block.BlockName, AreaId = g.Block.Area_Id, Startdate = g.StartDate, Enddate = g.EndDate }, includeProperties: "Block")),
                    Message = _sharLocalizer[SDLocalization.Data],
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, "");
                return new Response<IEnumerable<ListOfBlocksResponse>>()
                {
                    Errors = new[] { ex.Message },
                    Message = _sharLocalizer[SDLocalization.Error]
                };
            }
        }

        public async Task<bool> ManageBlocksDataAsync()
        {
            try
            {
                var LastObject = _unitOfWork.Blocks.GetFirstOrDefault(orderBy: x => x.OrderByDescending(x => x.Id));
                var Data = _mapper.Map<List<SharBlock>>(await _unitOfWork.Blocks.Remote_GetBlocksData(LastObject != null ? LastObject.Id : 0, false));
                Data.ForEach(x => { x.Area = null; });
                await _unitOfWork.Blocks.AddRangeAsync(Data);
                var UpdattingData = _mapper.Map<List<SharBlock>>(await _unitOfWork.Blocks.Remote_GetBlocksData(0, true)).Where(x => Data.All(y => y.Id != x.Id)).ToList();
                UpdattingData.ForEach(x => { x.Area = null; });
                _unitOfWork.Blocks.UpdateRange(UpdattingData);
                _unitOfWork.Complete();
                _unitOfWork.Blocks.CommitAllBlocksChanges();
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
