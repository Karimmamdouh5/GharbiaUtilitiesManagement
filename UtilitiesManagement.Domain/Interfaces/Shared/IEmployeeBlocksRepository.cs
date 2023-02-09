using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManagement.Domain.ViewModels.HR;

namespace UtilitiesManagement.Domain.Interfaces.Shared
{
    public interface IEmployeeBlocksRepository : IBaseRepository<HrEmployeeBlocks>
    {
        public Task<IEnumerable<HrEmployeeBlocks_ViewModel>> Remote_GetRunnerBlocksData();
        public Task<bool> CommitAllEmployeeBlocksChanges();
    }
}
