using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMyApp.Domain.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime NowEg(this DateTime dateToCheck)
        {
            return DateTime.UtcNow.AddHours(2);
        }
    }
}
