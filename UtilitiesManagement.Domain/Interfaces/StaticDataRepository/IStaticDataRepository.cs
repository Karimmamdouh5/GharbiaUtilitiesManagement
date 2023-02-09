using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace  UtilitiesManagement.Domain.Interfaces.StaticDataRepository
{
    public interface IStaticDataRepository
    {
  
        Task<List<SelectListResponse>> GetAllHrStatus();
        List<SelectListResponse> GetAllUserTypes();
        string GetUserTypeName(int UserTypeId);

    }
}
