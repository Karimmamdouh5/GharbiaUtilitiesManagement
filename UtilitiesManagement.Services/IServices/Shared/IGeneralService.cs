using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Services.IServices.Shared
{
    public interface IGeneralService
    {
        Task<Response<String>> ManageData();
        Task<Response<String>> LoadMainBillsTableData();
    }
}
