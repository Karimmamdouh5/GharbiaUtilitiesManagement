using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManagement.Domain.ViewModels.Bills;

namespace UtilitiesManagement.Domain.Interfaces.Bill
{
    public interface IIssueDetailsRepository : IBaseRepository<BillIssueDetail>
    {
        public Task<IEnumerable<BillIssueDetails_ViewModel>> Remote_GetIssueDetailsData(long maxlength, bool IsUpdated);
        public Task<bool> CommitAllIssuesDetailChanges();
    }
}
