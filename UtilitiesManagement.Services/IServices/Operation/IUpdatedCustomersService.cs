namespace  UtilitiesManagement.Services.IServices.Operation
{
    public interface IUpdatedCustomersService
    {
        #region Updeted customers
        Task<Response<GetUpdatedCustomerResponse>> GetAllUpdatedCustomersAsync(SearchParametersRequest searchParametersRequest);
        Task<Response<IEnumerable<AddUpdatedCustomerResponse>>> AddUpdatedCustomerAsync(IEnumerable<AddUpdatedCustomerRequest> addUpdatedCustomerRequests);
        Task<Response<IEnumerable<UpdateUpdatedCustomerRequest>>> UpdateSpecificFieldForUpdatedCustomerAsync(IEnumerable<UpdateUpdatedCustomerRequest> updateUpdatedCustomerRequests);
        Task<Response<IEnumerable<string>>> UploadUpdatedCustomerImagesAsync(List<IFormFile> photos, ImagePathRequest imagePath);
        Task<Response<IEnumerable<SelectListSysNameResponse>>> ListOfUpdatedCustomerTypeAsync();
        #endregion
    }
}