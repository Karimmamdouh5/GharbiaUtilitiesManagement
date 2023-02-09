using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Interfaces.Shared
{
    public interface IStateRepository : IBaseRepository<SharState>
    {
        Task<IEnumerable<SharState_ViewModel>> Remote_GetStateData(long maxlength, bool IsUpdated);
        Task Remote_SummitUpdates();
    }
}
