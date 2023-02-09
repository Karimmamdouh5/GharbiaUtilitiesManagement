using UtilitiesManagement.Domain.Dtos.Request.Technician;
using UtilitiesManagement.Domain.Dtos.Response.Technician;
using UtilitiesManagement.Domain.Models.Technician;

namespace FacilityManagement.Api.Profiles
{
    public class TechProfile : Profile
    {
        public TechProfile()
        {
            #region Technician Locations

            CreateMap<TechTechnicianLocation, TechTechnicianLocationRequest>()
                .ReverseMap();
            CreateMap<TechniciansDTOResponse, TechTechnician>()
                .ReverseMap();
            //CreateMap<CreateTechnicianLogEmployee, TechTechnician>()
            //    .ReverseMap();
            CreateMap<AddTechnicianLogRequest, TechTechnician>()
                .ForMember(x => x.Employee_Id, o => o.MapFrom(s => s.EmployeeId))
                .ReverseMap();
            CreateMap<TechTechnician, TechGetLastTechnician>()
               
             .ForMember(d => d.EmployeeId, o
                => o.MapFrom(s => s.Employee_Id));

            #endregion
        }
    }
}
