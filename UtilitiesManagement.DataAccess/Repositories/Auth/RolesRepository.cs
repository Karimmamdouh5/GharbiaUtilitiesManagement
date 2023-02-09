using UtilitiesManagement.Domain.Constants;
using UtilitiesManagement.Domain.Dtos.Request.Auth;
using UtilitiesManagement.Domain.Dtos.Response.Auth;
using UtilitiesManagement.Domain.Interfaces.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace  UtilitiesManagement.DataAccess.Repositories.Auth
{
    public class RolesRepository : BaseRepository<ApplicationRole>, IRolesRepository
    {
    
        private readonly RoleManager<ApplicationRole> _roleManager;

        public RolesRepository(UtilitiesDbContext context, IMapper mapper, ILoggingRepository _loggingRepository, ILogger logger , RoleManager<ApplicationRole> RoleManager,IConfiguration config, IHttpContextAccessor accessor) : base(context, _loggingRepository,logger,mapper,config, accessor)
        {
           
            _roleManager = RoleManager;
        }

    }
}

