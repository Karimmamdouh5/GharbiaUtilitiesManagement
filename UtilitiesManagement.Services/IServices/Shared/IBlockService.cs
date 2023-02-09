using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Services.IServices.Shared
{
    public interface IBlockService
    {
        Task<Response<IEnumerable<ListOfBlocksResponse>>> GetBlocksAsync(int? AreaId, int? employeeId);
        Task<bool> ManageBlocksDataAsync();
        Task<Response<IEnumerable<ListOfBlocksResponse>>> GetBlocksByEmployeeAsync(long employeeId);
    }
}
