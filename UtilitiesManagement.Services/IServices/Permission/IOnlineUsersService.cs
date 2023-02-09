namespace  UtilitiesManagement.Services.IServices.Permission
{
    public interface IOnlineUsersService
    {
        #region Connected Or Disconnected Users
        /// <summary>
        /// This is asynchronous function to get all users dependent on the argument for online, 
        /// offline or all users
        /// </summary>
        /// <param name="selectedValue">A paramater is nullable and otherwise will take a boolean 
        /// value for checking
        /// </param>
        /// <returns>Returns collections of specific users as IEnumerable containing all the elements 
        /// that match the any condition</returns>        
        Task<Response<List<AuthOnlineUserResponse>>> GetUsersAsync(bool? connectionStatus = null, int? companyId = null);
        /// <summary>
        /// This is asynchronous function to get all users dependent on the argument for specific 
        /// filteration to fetch certain user or all users logs
        /// </summary>
        /// <param name="selectedValue"> One of paramater is required and otherwise will are
        /// nullable
        /// </param>
        /// <returns>Returns collections of specific users as IEnumerable containing all the elements 
        /// that match the any condition</returns>        
        Task<Response<IEnumerable<AuthOnlineUserResponse>>> GetUserLogsAsync(AuthSearchForDisabledUsersRequest searchForDisabledUsersRequest);
        /// <summary>
        /// This is asynchronous function to get list of users 
        /// </summary>
        /// <param name="selectedValue"> One of paramater is nullable 
        /// </param>
        /// <returns>Returns collections of specific users as IEnumerable containing all the elements 
        /// that match the condition or not</returns>        
        Task<Response<IEnumerable<AuthUserSelectListResponse>>> ListOfUsersAsync(int companyId);
        /// <summary>
        /// This is asynchronous function to fetch numbers of online to a specific company or
        /// all companies 
        /// </summary>
        /// <param name="selectedValue"> A paramater is nullable 
        /// </param>
        /// <returns>Returns numbers of online</returns>
        Task<List<AuthCountOnlineUsersResponse>> GetNumOfOnlineUsersAsync(int? companyId);
        
        #endregion
    }
}
