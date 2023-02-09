
namespace UtilitiesManagement.Domain.Interfaces.Shared
{
    public interface IBranchRepository : IBaseRepository<SharBranch>
    {
        public Task<IEnumerable<SharBranch_ViewModel>> Remote_GetBranchesData(long maxlength, bool IsUpdated);
        public Task Remote_SummitUpdates();
        public Task<bool> CommitAllBranchsChanges();
    }
}
