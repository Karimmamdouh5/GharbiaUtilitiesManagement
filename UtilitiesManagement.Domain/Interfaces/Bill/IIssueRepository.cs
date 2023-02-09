namespace UtilitiesManagement.Domain.Interfaces.Bill
{
    public interface IIssueRepository:IBaseRepository<BillIssue>
    {
        public Task<IEnumerable<BillIssue_ViewModel>> Remote_GetIssueData(long maxlength, bool IsUpdated);
        public Task<bool> CommitAllIssuesChanges(DateTime LastIssueDate);
        Task<IEnumerable<RemoteBillData_ViewModel>> RemoteDataLoading();
        #region Reports

        public Task<IEnumerable<BillIssueReportResponse>> GetTopTwelveIssuesAsync(long companyId);

        #endregion
    }
}
