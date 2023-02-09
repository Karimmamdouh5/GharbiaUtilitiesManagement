using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Interfaces.Shared
{
    public interface IBlockRepository : IBaseRepository<SharBlock>
    {
        public Task<IEnumerable<SharBlock_ViewModel>> Remote_GetBlocksData(long maxlength, bool IsUpdated);
        public Task<bool> CommitAllBlocksChanges();
        public Task Remote_SummitUpdates();
    }
}
