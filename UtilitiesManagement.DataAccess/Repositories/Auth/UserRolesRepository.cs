﻿using UtilitiesManagement.Domain.Interfaces.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  UtilitiesManagement.DataAccess.Repositories.Auth
{
    public class UserRolesRepository : BaseRepository<ApplicationUserRole> , IUserRolesRepository
    {
       
        private readonly RoleManager<ApplicationRole> _roleManager;

        public UserRolesRepository(UtilitiesDbContext context, IMapper mapper, ILoggingRepository loggingRepository, ILogger logger, RoleManager<ApplicationRole> RoleManager,IConfiguration config, IHttpContextAccessor accessor) : base(context, loggingRepository, logger,mapper,config, accessor)
        {
            _roleManager = RoleManager;
        }

    }
}
