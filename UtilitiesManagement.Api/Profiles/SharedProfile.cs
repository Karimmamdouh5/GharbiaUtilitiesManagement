using UtilitiesManagement.Domain.Dtos.Response.Auth;
using UtilitiesManagement.Domain.Models.Permission;
using UtilitiesManagement.Domain.Models.Technician;

namespace  UtilitiesManagement.Api.Profiles
{
    public class SharedProfile : Profile
    {
        public SharedProfile()
        {
            #region Company

            CreateMap<SharCompany, AddCompanyRequest>()
               .ReverseMap();
            CreateMap<SharCompany, GetCompanyResponse>()
              .ForMember(d => d.State_Id, o => o.MapFrom(s => s.Region!.State_Id))
               .ReverseMap();
            CreateMap<SharCompany, GetCompaniesResponse>()
              .ForMember(d => d.Region, o => o.MapFrom(s => s.Region!.Name))
              .ForMember(d => d.State, o=> o.MapFrom(s => s.Region!.State!.Name))
              .ForMember(d => d.ManagerPosition, o => o.MapFrom(s => s.Employee!.JobSection!.Job!.Name))
              .ForMember(d => d.ManagerName, o => o.MapFrom(s => s.Employee!.Name))
             
               .ReverseMap();
            CreateMap<SharCompany, UpdateCompanyRequest>()
               .ReverseMap();
            CreateMap<SharCompany, SelectListResponse>()
               .ForMember(d => d.Name, o => o.MapFrom(s => s.CompanyName))
             .ReverseMap();
            #endregion

            #region State

            CreateMap<SharState, SharStateRequest>()
               .ReverseMap();

            CreateMap<SharState, GetListResponse>()
               .ReverseMap();
            CreateMap<SharState, SelectListResponse>()
              .ReverseMap();

            #endregion

            #region Region

            CreateMap<SharRegion, SharRegionRequest>()
               .ReverseMap();
            CreateMap<SharRegion, GetListResponse>()
               .ReverseMap();
            CreateMap<SharRegion, SelectListResponse>()
               .ReverseMap();

            #endregion

            #region Tax Office

            CreateMap<SharTaxOffice, GetListResponse>()
               .ReverseMap();
            CreateMap<SharTaxOffice, SharTaxOfficeRequest>()
               .ReverseMap();

            #endregion

            #region Company Branch 

            CreateMap<SharBranch, SharCompanyBranchRequest>()
               .ReverseMap();
            CreateMap<SharBranch, SharAddCompanyBranchRequest>()
               .ReverseMap();
            CreateMap<SharBranch, SharEditCompanyBranchRequest>()
               .ReverseMap();

            CreateMap<SharBranch, SharCompanyBranchResponse>()
                .ForMember(d => d.BranchManager, o
                => o.MapFrom(s => s.BranchManager.Name))
                .ForMember(d => d.Region, o
                => o.MapFrom(s => s.Region.Name))
                .ForMember(d => d.State, o
                => o.MapFrom(s => s.Region.State.Name))
                .ReverseMap();

            CreateMap<SharBranch, SharCompanyBranchProfileResponse>()
                .ForMember(d => d.StateId, o
                => o.MapFrom(s => s.Region.State_Id))
                .ReverseMap();

            #endregion

            #region User

            CreateMap<PermOnlineUser, AuthOnlineUserResponse>()
                .ForMember(d => d.Name, o
                => o.MapFrom(s => s.User.Employee.Name))
                .ForMember(d => d.Email, o
                => o.MapFrom(s => s.User.Email))
                .ForMember(d => d.RemainingTime, o
                => o.MapFrom(s => s.InsertDate.AddHours(8)))
                .ForMember(d => d.BranchName, o
                => o.MapFrom(s => s.User.Employee.Branch.BranchName))
                .ForMember(d => d.CompanyName, o
                => o.MapFrom(s => s.User.Employee.Branch.Company.CompanyName))
                .ForMember(d => d.Mobile, o
                => o.MapFrom(s => s.User.Employee.Mobile))
                .ReverseMap();

            #endregion

            #region Technician Location

            CreateMap<TechTechnicianLocation, SharUserLocationRequest>()
               .ReverseMap();

            CreateMap<TechTechnicianLocation, SharUserLocationRequest>()
               .ReverseMap();

            #endregion

            #region Finanncial Year

            CreateMap<SharFinancialYear, SharFinancialYearResponse>()
               .ReverseMap();

            CreateMap<SharFinancialYear, SharFinancialYearRequest>()
               .ReverseMap();

            #endregion
        }

    }
}
