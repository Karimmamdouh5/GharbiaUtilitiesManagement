namespace  UtilitiesManagement.Services.IServices.Shared
{
    public interface ICompanyService
    {
        #region Companies
        Task<IEnumerable<GetCompanyResponse>> GetAllCompaniesAsync();
        Task<IEnumerable<SelectListResponse>> ListOfCompaniesAsync();
        Task<Response<GetCompanyResponse>> GetCompanyProfileAsync(int CompanyId);
        Task<Response<string>> AddCompanyAsync(AddCompanyRequest addCompanyRequest);
        Task<Response<string>> UpdateCompanyAsync(int companyId, UpdateCompanyRequest updateCompanyRequest);
        Task<Response<string>> DeleteCompanyAsync(int companyId);
        Task<Response<string>> ChangeLogoCompanyAsync(ChangeCompanyLogoRequest changeCompanyLogoRequest, bool logoWeb);
        Task<Response<string>> ActiveOrNotAsync(int companyId);
        #endregion
    }
}