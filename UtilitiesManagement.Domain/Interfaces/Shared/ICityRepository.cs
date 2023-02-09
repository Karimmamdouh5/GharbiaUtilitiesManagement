using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Interfaces.Shared
{
    public interface ICityRepository : IBaseRepository<SharCity>
    {
        Task<IEnumerable<SharCity_ViewModel>> Remote_GetCityData(long maxlength, bool IsUpdated);
        Task Remote_SummitUpdates();

    }
}
