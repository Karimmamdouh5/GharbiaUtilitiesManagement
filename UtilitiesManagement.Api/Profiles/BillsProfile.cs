using UtilitiesManagement.Domain.Dtos.Request.Bill;
using UtilitiesManagement.Domain.Dtos.Response.Bill;
using UtilitiesManagement.Domain.Dtos.Response.Shared;
using UtilitiesManagement.Domain.Extensions.Auth;
using UtilitiesManagement.Domain.Models.Bill;
using UtilitiesManagement.Domain.ViewModels.Bills;

namespace UtilitiesManagement.Api.Profiles
{
    public class BillsProfile:Profile
    {
        private readonly IHttpContextAccessor _accessor;
        public BillsProfile()
        {

        }
        public BillsProfile(IHttpContextAccessor accessor)
        {
            _accessor = accessor;

            CreateMap<BillPaymentRequest, BillPayment>();

            CreateMap<BillPayment, BillPaymentResponse>()
               .ForMember(x => x.AreaName, o => o.MapFrom(s => s.CustomerData.Block.Area.AreaName))
               .ForMember(x => x.BlockName, o => o.MapFrom(s => s.CustomerData.Block.BlockName))
               .ForMember(x => x.BranchName, o => o.MapFrom(s => s.CustomerData.Block.Area.City.State.Branch.BranchName))
               .ForMember(x => x.AreaId, o => o.MapFrom(s => s.CustomerData.Block.Area_Id))
               .ForMember(x => x.BlockId, o => o.MapFrom(s => s.CustomerData.Block_Id))
               .ForMember(x => x.BranchId, o => o.MapFrom(s => s.CustomerData.Block.Area.City.State.Branch_Id))
               .ForMember(x => x.CollectorName, o => o.MapFrom(s => s.Employee.Name))
               .ForMember(x => x.CustomerCode, o => o.MapFrom(s => s.CustomerData.Code))
               .ForMember(x => x.CustomerName, o => o.MapFrom(s => s.CustomerData.Name));
            CreateMap<BillTransaction, BillPaymentTransaction>()
                .ReverseMap();
            CreateMap<BillsDataRequest, BillBillsData>()
                 .ReverseMap()
                 .ForMember(x => x.IssueName, o => o.MapFrom(s => s.BillIssue.IssueName));

            CreateMap<BillData_ViewModel, BillBillsData>()
                .ForMember(x => x.WaterValue, o => o.MapFrom(s => s.WaterValue))
                .ForMember(x => x.WastWaterInstallment, o => o.MapFrom(s => s.WastewaterInstallment))
                .ForMember(x => x.WaterInstallment, o => o.MapFrom(s => s.WaterInstallment))
                .ForMember(x => x.Tax14Percent, o => o.MapFrom(s => s.Tax14Percent))
                .ForMember(x => x.BillNum, o => o.MapFrom(s => s.BillNumber))
                .ForMember(x => x.BillValue, o => o.MapFrom(s => s.BillAmount))
                .ForMember(x => x.CustomerData, o => o.Ignore())
                .ForMember(x => x.ContenutityService, o => o.MapFrom(s => s.ContenutityService))
                .ForMember(x => x.CustomerPayingDate, o => o.MapFrom(s => s.CustomerpayingDate))
                .ForMember(x => x.Customer_Id, o => o.MapFrom(s => s.CustomerID))
                .ForMember(x => x.Installment, o => o.MapFrom(s => s.Installment))
                .ForMember(x => x.Maintenance, o => o.MapFrom(s => s.Maintenance))
                .ForMember(x => x.Others, o => o.MapFrom(s => s.Others))
                .ForMember(x => x.PayDate, o => o.MapFrom(s => s.CustomerpayingDate))
                .ForMember(x => x.RegularityService, o => o.MapFrom(s => s.RegularityService))
                .ReverseMap();

            CreateMap<RemoteBillData_ViewModel, BillIssue>()
                 .ForMember(x => x.Company_Id, o => o.MapFrom(s => (long)(_accessor!.HttpContext == null ? null : _accessor!.HttpContext!.User.GetCompanyId())!))
                 .ForMember(x => x.IssueDate, o => o.MapFrom(s => s.IssueDate))
                 .ForMember(x => x.IssueName, o => o.MapFrom(s => s.IssueDate.ToString()))
                 .ForMember(x => x.Status, o => o.MapFrom(s => "مفتوح"))
                 .ForMember(x => x.IsActive, o => o.MapFrom(s => true))
                 .ForMember(x => x.IssueDetails, o => o.MapFrom(s => new List<BillIssueDetail>() { new BillIssueDetail() { BillEndNum = 0, BillStartNum = 0, BranchIssueStatus = "مفتوح", Branch_Id = s.Branch_Id, CanPostReading = true, IsActive = true } }))
                 ;

            CreateMap<BillPaymentLogRequest, PayDataLog>()
                .ReverseMap();
            CreateMap<PayDataLogDetailsRequest, PayDataLogDetails>()
                .ReverseMap();


            #region BillSaf
            CreateMap<AddListRequest, BillSafe>();

                CreateMap<BillSafe, SelectListResponse>()
                    .ReverseMap();
            #endregion

           
            CreateMap<BillSafe, SelectListResponse>();
           
        }
    }
}
