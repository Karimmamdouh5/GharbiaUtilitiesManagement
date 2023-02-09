using UtilitiesManagement.Domain.Interfaces.StaticDataRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  UtilitiesManagement.DataAccess.Repositories.StaticDataRepository
{
    public class StaticDataRepository: IStaticDataRepository
    {
        private readonly UtilitiesDbContext _context;

        public StaticDataRepository(UtilitiesDbContext dbContext)
        {
            _context = dbContext;
        }

      
      
        public async Task<List<SelectListResponse>> GetAllHrStatus()
        {
            var Data = _context.HrStatus.IgnoreQueryFilters().Where(x => x.IsDeleted == false).Select(x => new SelectListResponse()
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
            return Data;
        }

        public List<SelectListResponse> GetAllUserTypes()
        {
            var Data = _context.UserTypes.IgnoreQueryFilters().Select(x => new SelectListResponse()
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
            return Data;
        }

        public string GetUserTypeName(int UserTypeId)
        {
            var Data = _context.UserTypes.Where(x => x.Id == UserTypeId).FirstOrDefault();
            if (Data == null)
            {
                return "";
            }
            return Data.Name;
        }
    }
}
