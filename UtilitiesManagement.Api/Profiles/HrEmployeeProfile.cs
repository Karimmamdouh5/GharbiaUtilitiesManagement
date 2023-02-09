using UtilitiesManagement.Domain.Dtos.Response.HR;
using UtilitiesManagement.Domain.Models.HR;
using UtilitiesManagement.Domain.Models.Shared;
using UtilitiesManagement.Domain.Models.Technician;
using UtilitiesManagement.Domain.ViewModels.HR;

namespace UtilitiesManagement.Api.Profiles
{
    public class HrEmployeeProfile:Profile
    {
        public HrEmployeeProfile()
        {
            #region Employee
                CreateMap<HrEmployee , HrEmployeeProfileResponse>()
                // .ForMember(x => x.Blocks, o => o.MapFrom(s => s.Branch.States..Areas.Select(x => x.Blocks)))
                 .ForMember(x => x.Technician, o => o.MapFrom(s => s.TechnicianLogs.LastOrDefault()))
                 .ReverseMap();

            CreateMap<HrEmployee, SharSelectListGroupResponse>()
                .ForMember(x => x.Group, o => o.MapFrom(s => s.Branch.BranchName))
                 .ForMember(x => x.Title, o => o.MapFrom(s => s.Job))
                 .ReverseMap();

            CreateMap<HrEmployee_ViewModel, HrEmployee>()
              .ForMember(x => x.Name, o => o.MapFrom(s => s.CollectorName))
              .ForMember(x => x.Job, o => o.MapFrom(s => s.CollectorType))
              .ForMember(x => x.Id, o => o.MapFrom(s => s.CollectorID))
              .ForMember(x => x.Branch_Id, o => o.MapFrom(s => s.BranchID));

            CreateMap<HrEmployee_ViewModel, HrEmployee_Temp>()
                 .ForMember(x => x.EmployeeName, o => o.MapFrom(s => s.CollectorName))
                  .ForMember(x => x.EmployeeType, o => o.MapFrom(s => s.CollectorType))
                  .ForMember(x => x.Id, o => o.MapFrom(s => s.CollectorID));

            CreateMap<HrEmployeeBlocks_ViewModel, HrEmployeeBlocks>()
                .ForMember(x => x.Block_Id, o => o.MapFrom(s => s.BlockID))
                .ForMember(x => x.Collector_Id, o => o.MapFrom(s => s.CollectorID))
                .ForMember(x => x.StartDate, o => o.MapFrom(s => s.StartDate))
                .ForMember(x => x.EndDate, o => o.MapFrom(s => s.StartDate.AddMonths(1)));

            #endregion

            #region Blocks
            CreateMap<SharBlock, CollectorBlocks>()
                .ForMember(x => x.AreaName, o => o.MapFrom(s => s.Area.AreaName))
                .ForMember(x => x.BlockName, o => o.MapFrom(s => s.Area.Blocks.Select(x => x.BlockName)))
                .ForMember(x => x.BlockCode, o => o.MapFrom(s => s.Area.Blocks.Select(x => x.BlockCode)))
                .ForMember(x => x.StartDate, o => o.MapFrom(s => new DateTime()))
                .ForMember(x => x.EndDate, o => o.MapFrom(s => new DateTime()))
                .ReverseMap();
            #endregion

            #region Technician
                CreateMap<TechTechnician, TechnicianObj>()
                .ReverseMap();
            #endregion
        }
    }
}
