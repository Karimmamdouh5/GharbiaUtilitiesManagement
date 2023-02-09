namespace UtilitiesManagement.Services.IServices.HR
{
    public interface IEmployeeService
    {
        Task<Response<HrEmployeeProfileResponse>> GetEmployeeProfile(int employeeId);
        Task<Response<List<HrEmployeeProfileResponse>>> GetEmployeesData(long? BranchId, long? StateId, long? CityId, long? AreaId, long? BlockId);
        Task<Response<List<SharSelectListGroupResponse>>> ListOfEmployee(long? BranchId, long? StateId, long? CityId, long? AreaId, long? BlockId);
        Task<Response<List<SelectListResponse>>> ListOfUsersEmployee(long? BranchId);
        Task<Response<string>> ManageRemoteEmployeesData();
        
    }
}
