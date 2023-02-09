namespace FacilityManagement.Api.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            #region Customer data  

            CreateMap<SelectListResponse, CustCustomerData>()
                .ReverseMap();

            CreateMap<GetCustomerResponse, CustCustomerData>()
                .ReverseMap();

            CreateMap<GetCustomerDataResponse, CustCustomerData>()
                .ReverseMap();

            CreateMap<CustCustomerData, SharSelectListGroupResponse>()
                .ForMember(x => x.Group, o => o.MapFrom(s => s.Block.Area.AreaName))
                .ForMember(x => x.Title, o => o.MapFrom(s => s.Block.BlockName))
                .ReverseMap();

            CreateMap<SelectListResponseIdInt, CustCustomerActivity>()
                .ReverseMap();

            CreateMap<totalBillsOfCollector, CustomerBillStatistics>()
               .ForMember(x => x.collectionAmount, o => o.MapFrom(s => 0))
               .ReverseMap();

            #endregion

            #region Manage remote customers

            CreateMap<CustCustomerData_ViewModel, CustCustomerData>()
                .ForMember(x => x.PreviousReadingIssueNumber, o => o.MapFrom(s => 0))
                .ForMember(x => x.SubscriptionStartDate, o => o.MapFrom(s => ""))
                .ForMember(x => x.X, o => o.MapFrom(s => 0))
                .ForMember(x => x.Y, o => o.MapFrom(s => 0))
                .ForMember(x => x.CustomerActivity_Id, o => o.MapFrom(s => 0))
                .ForMember(x => x.IsDataComplete, o => o.MapFrom(s => true))
                .ForMember(x => x.PreviousReading, o => o.MapFrom(s => 0))
                .ForMember(x => x.Block, o => o.Ignore())
                .ForMember(x => x.CustomerStatus, o => o.Ignore())
                .ForMember(x => x.CustomerActivity, o => o.Ignore());

            CreateMap<CustCustomerData_ViewModel, CustCustomerDataTemp>()
               .ForMember(x => x.PreviousReadingIssueNumber, o => o.MapFrom(s => 0))
               .ForMember(x => x.SubscriptionStartDate, o => o.MapFrom(s => ""))
               .ForMember(x => x.X, o => o.MapFrom(s => 0))
               .ForMember(x => x.Y, o => o.MapFrom(s => 0))
               .ForMember(x => x.IsDataComplete, o => o.MapFrom(s => true))
               .ForMember(x => x.PreviousReading, o => o.MapFrom(s => 0));
            CreateMap<CustCustomerActivity_ViewModel, CustCustomerActivity>();

            CreateMap<CustCustomerStatus_ViewModel, CustCustomerStatus>();

            #endregion
        }

    }
}
