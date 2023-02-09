using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Services.Services.Shared
{
    public class StateService : IStateService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;
        private readonly ILoggingRepository _customLog;
        private readonly IMapper _mapper;
        public StateService(IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharLocalizer,
                                ILoggingRepository loggingRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _sharLocalizer = sharLocalizer;
            _customLog = loggingRepository;
            _mapper = mapper;
        }
        public async Task<Response<IEnumerable<ListOfStatesResponse>>> GetStatesAsync(int? BranchId , int? employeeId)
        {
            if(employeeId == null)
            {
                return new Response<IEnumerable<ListOfStatesResponse>>()
                {
                    Data = (await _unitOfWork.State.GetSpecificSelectAsync(filter: x => x.Branch_Id == BranchId, select: x => new ListOfStatesResponse()
                    {
                        BranchId = (int)x.Branch_Id,
                        Id = x.Id,
                        Name = x.StateName
                    })).ToList().DistinctBy(a => a.Id),
                    IsSuccess = true,
                    Message = _sharLocalizer[SDLocalization.Data]
                };
            }
            else
            {
                return new Response<IEnumerable<ListOfStatesResponse>>()
                {
                    Data =( await _unitOfWork.EmployeeBlocks.GetSpecificSelectAsync(filter: x => x.Collector_Id == employeeId , select:x => new ListOfStatesResponse() { Id = x.Block.Area.City.State_Id , Name = x.Block.Area.City.State.StateName , BranchId = (int)x.Block.Area.City.State.Branch_Id})).ToList().DistinctBy(a => a.Id),
                    IsSuccess = true,
                    Message = _sharLocalizer[SDLocalization.Data]
                };
            }

        }
    }
}
