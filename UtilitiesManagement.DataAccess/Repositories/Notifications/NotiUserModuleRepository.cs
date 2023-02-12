﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManagement.Domain.Interfaces.Notifications;
using UtilitiesManagement.Domain.Models.Notification;

namespace UtilitiesManagement.DataAccess.Repositories.Notifications
{
    public class NotiUserModuleRepository : BaseRepository<NotiUserModule>, INotiUserModuleRepository
    {
        public NotiUserModuleRepository(UtilitiesDbContext context, ILoggingRepository loggingRepository, ILogger logger, IMapper mapper, IConfiguration config, IHttpContextAccessor accessor) : base(context, loggingRepository, logger, mapper, config, accessor)
        {
        }
    }
}
