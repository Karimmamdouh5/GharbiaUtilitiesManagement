using UtilitiesManagement.Domain.Constants;

namespace  UtilitiesManagement.Services.IServices.Permission
{
    public interface IPermissionsService 
    {
        Task<Response<List<AuthPermissionsTreeResponse>>> GetDefaultClaimsByCompanyIdAsync(int CompanyId);
        Task<Response<AuthRoleDetailsByCompanyResponse>> GetRolesDetailsForCompany(int CompanyId);
        Task<Response<PermissionsTreeByRoleResponse>> GetClaimsByRoleAsync(string roleId);
        Task<Response<string>> CreateRoleAsync(AddNewRollRequest model);
        Task<Response<RolesByUserIdResponse>> ManageUserRolesAsync(RolesByUserIdResponse model);
        Task<Response<string>> AddAllClaimsToRoleAsync();
        Task<Response<PermissionsByRoleResponse>> ManageClaimsByRoleAsync(PermissionsTreeByRoleResponse model);
        Task<Response<PermissionsTreeByCompanyResponse>> GetClaimsForCompanyAdminAsync(int CompanyId);
        Task<Response<PermissionsByCompanyResponse>> ManageClaimsForCompanyAdminAsync(PermissionsTreeByCompanyResponse model);
        Task<Response<List<string>>> ListAllCompanyRulesByCompanyId(int CompanyId);
        Task<Response<List<SelectListWithStringIdStringResponse>>> ListRulesForCompany(int CompanyId);
        Task<Response<SelectListWithStringIdStringResponse>> AddRulesToCompany(CompanyRoleDTO model);
        Task<Response<SelectListWithStringIdStringResponse>> EditRulesToCompany(CompanyRoleDTO_Edit model,string roleId);
        Task<Response<ApplicationRole>> DeleteRulesToCompany(string RoleId);
        Task<Response<RolesByUserIdResponse>> GetUserRolesAsync(string UserId);
    }
}
