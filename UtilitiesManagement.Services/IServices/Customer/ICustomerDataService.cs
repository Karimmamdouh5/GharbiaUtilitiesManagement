using UtilitiesManagement.Domain.ViewModels.Customer;

namespace  UtilitiesManagement.Services.IServices.Customer
{
    public interface ICustomerDataService
    {
        #region Customer data and manage remotely
        Task<Response<GetCustomerResponse>> GetAllCustomerDataAsync(SearchParametersForCustomerDataRequest searchParametersForCustomerDataRequest);
        Task<Response<IEnumerable<GetCustomerDataForCollectorResponse>>> GetAllCustomerDataByCollectorAsync(long Collector_Id, long[] BlockIds);
        Task<Response<CustCustomerProfileResponse>> GetCustomerDataProfileAsync(FilterForCustomerProfileRequest filterForCustomerProfileRequest);
        Task<Response<IEnumerable<SharSelectListGroupResponse>>> ListOfCustomer(FilterWithTwoFlagsCustomerRequest filterWithTwoFlagsCustomerRequest);
        Task<Response<GetCustomerDataResponse>> ActiveOrDeActiveForCompletedDataAsync(int customerDataId);
        Task<Response<IEnumerable<SelectListResponseIdInt>>> ListOfCustomerActivitesAsync();
        Task<Response<String>> ManageRemoteCustomersAsync();

        #endregion
    }
}