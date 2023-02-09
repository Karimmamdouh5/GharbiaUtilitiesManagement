using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Interfaces.Shared
{
    public interface IAreaRepository: IBaseRepository<SharArea>
    {
        public Task<IEnumerable<SharArea_ViewModel>> Remote_GetAreasData(long maxlength, bool IsUpdated);
        public Task<bool> CommitAllAreaChanges();
        public Task Remote_SummitUpdates();
    }
}
