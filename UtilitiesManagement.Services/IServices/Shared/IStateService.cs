using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Services.IServices.Shared
{
    public interface IStateService
    {
        Task<Response<IEnumerable<ListOfStatesResponse>>> GetStatesAsync(int? BranchId, int? employeeId);
    }
}
