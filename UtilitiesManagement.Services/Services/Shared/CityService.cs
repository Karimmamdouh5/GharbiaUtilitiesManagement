using GharbiaUtilitiesManagement.Domain.Dtos.Response.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Services.Services.Shared
{
    public class CityService : ICityService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;
        private readonly IMapper _mapper;
        private readonly ILoggingRepository _customLog;
        public CityService(IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharLocalizer,
                           IMapper mapper, ILoggingRepository loggingRepository)
        {
            _unitOfWork = unitOfWork;
            _sharLocalizer = sharLocalizer;
            _mapper = mapper;
            _customLog = loggingRepository;
        }
        public async Task<Response<IEnumerable<ListOfCitiesResponse>>> GetCityAsync(int? StateId, int? employeeId)
        {
            try
            {
                if(employeeId == null)
                {
                    return new Response<IEnumerable<ListOfCitiesResponse>>()
                    {
                        Data = await _unitOfWork.Cities.GetSpecificSelectAsync(filter: x => x.State_Id == StateId, ignoreQueryFilters: true, select: obj => new ListOfCitiesResponse()
                        {
                            Id = obj.Id,
                            Name = obj.CityName,
                            StateId = (int)obj.State_Id
                        }),
                        IsSuccess = true,
                        Message = _sharLocalizer[SDLocalization.Data]
                    };
                }
                else
                {
                    return new Response<IEnumerable<ListOfCitiesResponse>>()
                    {
                        Data =( await _unitOfWork.EmployeeBlocks.GetSpecificSelectAsync(filter:x => x.Collector_Id == employeeId , select:x => new ListOfCitiesResponse() { Id = x.Block.Area.City_Id,Name = x.Block.Area.City.CityName , StateId = (int)x.Block.Area.City.State_Id})).ToList().DistinctBy(a=>a.Id ) ,
                        IsSuccess = true,
                        Message = _sharLocalizer[SDLocalization.Data]
                    };
                }
            }
            catch (Exception ex)
            {
                return new Response<IEnumerable<ListOfCitiesResponse>>()
                {
                    IsSuccess = true,
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[]{ ex.Message}
                };
            }
        }
    }
}
