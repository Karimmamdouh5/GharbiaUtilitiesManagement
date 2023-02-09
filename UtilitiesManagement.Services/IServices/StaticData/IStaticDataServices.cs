using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  UtilitiesManagement.Services.IServices.StaticData
{
    public interface IStaticDataServices
    {
       
        List<SelectListResponse> GetAllUserTypes();
        string GetUserTypeName(int UserTypeId);
    }
}
