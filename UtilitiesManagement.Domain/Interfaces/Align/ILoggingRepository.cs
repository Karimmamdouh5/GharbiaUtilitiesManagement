
using System;
using System.Threading.Tasks;

namespace  UtilitiesManagement.Domain.Interfaces.Align
{
    public interface ILoggingRepository
    {
        Task<bool> LogExceptionInDb(Exception exception, string objJson = null, LogType logType = LogType.Bug);

    }
}
