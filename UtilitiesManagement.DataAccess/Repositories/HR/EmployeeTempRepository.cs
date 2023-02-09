﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.DataAccess.Repositories.HR
{
    public class EmployeeTempRepository : BaseRepository<HrEmployee_Temp>, IEmployeeTempRepository
    {
        public EmployeeTempRepository(UtilitiesDbContext context, ILoggingRepository loggingRepository, ILogger logger, IMapper mapper, IConfiguration config, IHttpContextAccessor accessor) : base(context, loggingRepository, logger, mapper, config, accessor)
        {
        }
    }
}
