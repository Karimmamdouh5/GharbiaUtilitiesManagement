

namespace  UtilitiesManagement.Services.IServices.Shared
{
    public interface IBranchService
    {
        #region Branch
        //Task<IEnumerable<SharBranch_ViewModel>> Remote_GetBranchesDataAsync();
        /// <summary>
        /// Service Return Branches Data From Remote DataBase and Store Them In Our DataBase
        /// </summary>
        /// <param name="companyId">Id Of the Company</param>
        /// <param name="employeeId">Id Of The Employee</param>
        /// <returns></returns>
        Task<Response<IEnumerable<SelectListResponse>>> GetBranchesAsync(int? companyId, int? employeeId,bool? assignedUserOnly);
        /// <summary>
        /// Service To Add New Data And Update The Updated Data
        /// </summary>
        /// <returns></returns>
        Task<bool> ManageBranchsDataAsync();
        #endregion
    }
}