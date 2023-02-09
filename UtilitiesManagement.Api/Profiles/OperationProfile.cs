


namespace UtilitiesManagement.Api.Profiles
{
    public class OperationProfile : Profile
    {
        public OperationProfile() 
        {
            #region Complaints

            CreateMap<AddComplaintRequest, OprComplaint>()
                .ForMember(d => d.Notes, o
                => o.MapFrom(s => s.Details))
                .ForMember(d => d.Employee_Id, o
                => o.MapFrom(s => s.CollectorId))
                 .ReverseMap();

            CreateMap<UpdateComplaintRequest, OprComplaint>()
                 .ReverseMap();

            CreateMap<AddComplaintImage, OprComplaintImage>()
                 .ReverseMap();

            #endregion

            #region Complaint Types

            CreateMap<SelectListComplaintTypeResponse, OprComplaintType>()
                 .ReverseMap(); 

            CreateMap<AddComplaintTypeRequest, OprComplaintType>()
                 .ReverseMap();

            CreateMap<UpdateComplaintTypeRequest, OprComplaintType>()
                 .ReverseMap();

            CreateMap<AddComplaintTypeRequest, OprComplaintType>()
                 .ReverseMap();

            CreateMap<SelectListResponse, OprComplaintType>()
                .ReverseMap();

            #endregion

            #region Meter readings

            CreateMap<AddMeterReadingRequest, OprMeterReading>()
                .ForMember(d => d.Employee_Id, o
                => o.MapFrom(s => s.CollectorId))
                .ForMember(d => d.Issue_Details_Id, o
                => o.MapFrom(s => s.IssueDetails_Id))
                 .ReverseMap();

            CreateMap<UpdateMeterReadingValueRequest, OprMeterReading>()
                 .ReverseMap();

            CreateMap<UpdateMeterReadingRequest, OprMeterReading>()
                  .ReverseMap();

            CreateMap<SelectListResponse, OprMeterStatus>()
                 .ReverseMap();

            #endregion

            #region Updeted customers

            CreateMap<AddUpdatedCustomerRequest, OprUpdatedCustomer>()
                 .ReverseMap();

            CreateMap<OprUpdatedCustomer, AddUpdatedCustomerResponse>().ForMember(d => d.SysName, o
                      => o.MapFrom(s => s.UpdatedCustomerType!.Name!));
                 

            CreateMap<UpdateUpdatedCustomerRequest, OprUpdatedCustomer>()
                 .ReverseMap();

            CreateMap<SelectListResponse, OprUpdatedCustomerType>()
                 .ReverseMap();

            #endregion

        }
    }
}
