using UtilitiesManagement.Domain.Interfaces.StaticDataRepository;
using UtilitiesManagement.Services.IServices.StaticData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  UtilitiesManagement.Services.Services.StaticData
{
    public class StaticDataServices : IStaticDataServices
    {
        private readonly IStaticDataRepository _staticDataRepository;

        public StaticDataServices(IStaticDataRepository staticDataRepository)
        {
            _staticDataRepository = staticDataRepository;
        }
      
        public List<SelectListResponse> GetAllUserTypes()
        {
            return _staticDataRepository.GetAllUserTypes();
        }

        public string GetUserTypeName(int UserTypeId)
        {
            return _staticDataRepository.GetUserTypeName(UserTypeId);
        }
    }
}
