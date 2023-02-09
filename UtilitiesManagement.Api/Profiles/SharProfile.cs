using GharbiaUtilitiesManagement.Domain.Models.Shared;
using GharbiaUtilitiesManagement.Domain.ViewModels.Shared;
using UtilitiesManagement.Domain.Dtos.Request.Shared;
using UtilitiesManagement.Domain.Models.HR;


namespace UtilitiesManagement.Api.Profiles
{
    public class SharProfile:Profile
    {
        public SharProfile()
        {
            #region Company
             CreateMap<SharCompany , AddCompanyRequest>()
                .ReverseMap();
            CreateMap<SharCompany, GetCompanyResponse>()
               .ForMember(d => d.Code, o => o.MapFrom(s => s.CompanyCode))
              .ReverseMap();

            CreateMap<SharCompany, GetCompaniesResponse>()
               .ReverseMap();
            CreateMap<SharCompany, UpdateCompanyRequest>()
               .ReverseMap();
            CreateMap<SharCompany, SelectListResponse>()
               .ForMember(d => d.Name, o => o.MapFrom(s => s.CompanyName));
           
            #endregion
            #region Branch

            CreateMap<SharBranch_ViewModel, SharBranch>()
               .ForMember(x => x.Id, o => o.MapFrom(s => s.BranchID))
               .ForMember(x => x.IsUpdated, o => o.MapFrom(s => s.BranchIsUpdated))
               .ForMember(x => x.Company_Id, o => o.MapFrom(s => s.CompanyId));
            CreateMap<SharBranch_ViewModel, SharBranch_Temp>()
               .ForMember(x => x.Id, o => o.MapFrom(s => s.BranchID))
               .ForMember(x => x.IsUpdated, o => o.MapFrom(s => s.BranchIsUpdated))
               .ForMember(x => x.Company_Id, o => o.MapFrom(s => s.CompanyId));

            CreateMap<SharBranch , SelectListResponse>()
                .ForMember(x => x.Id,o => o.MapFrom(s => s.Id))
                .ForMember(x => x.Name, o => o.MapFrom(s => s.BranchName))
                .ReverseMap();
            #endregion
            #region Area

            CreateMap<SharArea_ViewModel, SharArea>()
                .ForMember(x => x.Id, o => o.MapFrom(s => s.AreaID))
                .ForMember(x => x.IsUpdated, o => o.MapFrom(s => s.AreaIsUpdated));

            CreateMap<SharArea_ViewModel, SharArea_Temp>()
                .ForMember(x => x.Id, o => o.MapFrom(s => s.AreaID))
                .ForMember(x => x.IsUpdated, o => o.MapFrom(s => s.AreaIsUpdated));

            CreateMap<SharArea, SelectListResponse>()
                .ForMember(x => x.Id, o => o.MapFrom(s => s.Id))
                .ForMember(x => x.Name, o => o.MapFrom(s => s.AreaName))
                .ReverseMap();
            #endregion
            #region Block

            CreateMap<SharBlock_ViewModel, SharBlock>()
                .ForMember(x => x.Area_Id, o => o.MapFrom(s => s.AreaId))
                .ForMember(x => x.Id, o => o.MapFrom(s => s.BlockId))
                .ForMember(x => x.IsUpdated, o => o.MapFrom(s => s.BlockIsUpdated));

            CreateMap<SharBlock_ViewModel, SharBlock_Temp>()
               .ForMember(x => x.Area_Id, o => o.MapFrom(s => s.AreaId))
               .ForMember(x => x.Id, o => o.MapFrom(s => s.BlockId))
               .ForMember(x => x.IsUpdated, o => o.MapFrom(s => s.BlockIsUpdated));

            CreateMap<SharBlock, SelectListResponse>()
                .ForMember(x => x.Id, o => o.MapFrom(s => s.Id))
                .ForMember(x => x.Name, o => o.MapFrom(s => s.BlockName))
                .ReverseMap();
            #endregion
            #region State
            CreateMap<SharState_ViewModel, SharState>()
                .ForMember(x => x.Id, o => o.MapFrom(s => s.StateId))
                .ForMember(x => x.IsUpdated, o => o.MapFrom(s => s.IsUpdated));
            CreateMap<SharState_ViewModel, SharState_Temp>()
            .ForMember(x => x.Id, o => o.MapFrom(s => s.StateId))
            .ForMember(x => x.IsUpdated, o => o.MapFrom(s => s.IsUpdated));

            CreateMap<SharState, SelectListResponse>()
                .ForMember(x => x.Id, o => o.MapFrom(s => s.Id))
                .ForMember(x => x.Name, o => o.MapFrom(s => s.StateName))
                .ReverseMap();
            #endregion
            #region Cities
            CreateMap<SharCity_ViewModel, SharCity>()
             .ForMember(x => x.Id, o => o.MapFrom(s => s.CityId))
             .ForMember(x => x.IsUpdated, o => o.MapFrom(s => s.CityIsUpdated));
            CreateMap<SharCity_ViewModel, SharCity_Temp>()
             .ForMember(x => x.Id, o => o.MapFrom(s => s.CityId))
             .ForMember(x => x.IsUpdated, o => o.MapFrom(s => s.CityIsUpdated));

            CreateMap<SharCity, SelectListResponse>()
                .ForMember(x => x.Id, o => o.MapFrom(s => s.Id))
                .ForMember(x => x.Name, o => o.MapFrom(s => s.CityName))
                .ReverseMap();
            #endregion
            #region Bill_Temp
            CreateMap<SharMainTable_Bills, SharMainTable_Bills_ViewModel>().ReverseMap();
            //CreateMap<SharMainTable_Bills_ViewModel, SharMainTable_Bills>()
            //   .ForMember(x => x.Id, o => o.MapFrom(y => 0))
            //    .ForMember(x => x.ACTIVITY_TYPE_Id, o => o.MapFrom(y => 0))
            //    .ForMember(x => x.Bill_ID, o => o.MapFrom(y => 0))
            //    .ForMember(x => x.BRANCH_Id, o => o.MapFrom(y => 0));
               
            #endregion
        }
    }
}
