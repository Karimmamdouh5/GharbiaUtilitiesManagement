namespace  UtilitiesManagement.Api.Profiles
{
    public class CustProfile : Profile
    {
        public CustProfile()
        {
            #region CustClient

            CreateMap<CustClientData, CustAddClientDataAndBranchRequest>()
                .ReverseMap();

            CreateMap<CustClientData, CustRetrievedClientsDataResponse>()
                .ReverseMap();

            CreateMap<CustAddClientDataAndBranchRequest, CustClientDataBranch>()
                .ForPath(d => d.ClientData, o
                => o.MapFrom(s => s))
                .ForMember(d => d.ClientDays, option => option.Ignore())
                //.ForMember(d => d.ClientDays, o
                //=> o.MapFrom(s => s.ClientDays))
                .ReverseMap();

            CreateMap<CustAddClientBranchRequest, CustAddClientDataAndBranchRequest>()
                .ReverseMap();

            CreateMap<CustClientDataBranch, CustAddClientBranchRequest>()
                .ReverseMap();

            CreateMap<CustClientDataBranch, CustGetClientBranchLocationResponse>()
                .ReverseMap();

            CreateMap<CustClientData, CustEditClientDataRequest>()
                .ReverseMap();

            #endregion
        }

    }
}
