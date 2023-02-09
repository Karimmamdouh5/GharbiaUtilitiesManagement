namespace  UtilitiesManagement.Services.IServices.Permission
{
    public interface IAuthService 
    {
        Task<AuthResponse> RegisterAsync(RegisterRequest model);
        Task<AuthResponse> GetTokenAsync(LoginRequest model);
        Task<Response<GetUserResponse>> GetUserDataAsync(string userId);
        Task LogOutAsync(Guid UserId);
        Task<Response<string>> ChangePassWord(ChangePassWordRequest model);
        Task<Response<GetUserResponse>> UpdateUser(UpdateUserRequest model, string Id);
        Task<Response<CompanyConfigurationResponse>> CheckCompanyActivationAndVersionAsync(string companyCode);
        Task<Response<string>> LogoutAsync(string userId);
        Task<Response<AuthUserRegisterResponse>> UserRegister(AuthResigterRequest resigterRequest);
        Task<Response<List<AuthUserProfileResponse>>> GetCompanyUsers(int CompanyId, string? RoleId, string? UserName);
        Task<Response<string>> ResetUserPassWord(string UserId);
        Response<String> ActivateorDeactivateUser(string UserId);
        Task<Response<List<SelectListResponse>>> GetUserBranches(string UserId);
        Task<string> CheckConnection();
    }
}
