
using UtilitiesManagement.Domain.Models.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManagement.Domain.ViewModels.HR;
using UtilitiesManagement.Domain.ViewModels.DashBoard;
using UtilitiesManagement.Domain.Dtos.Request.DashBoard;

namespace  UtilitiesManagement.Domain.Interfaces.HR
{
    public interface IEmployeeRepository : IBaseRepository<HrEmployee>
    {
        public Task<IEnumerable<HrEmployee_ViewModel>> Remote_GetRunnerData(long maxReaderId, long MaxCollectorId);
        public Task<IEnumerable<TotalMonthlyStatisticsForEmployee>> TotalMonthlyStatisticsForEmployee(StatisticsRequest model);
        public Task<IEnumerable<TotalMonthlyStatisticsForEmployee>> TotalDailyStatisticsForEmployee(StatisticsRequest model);
        public Task<bool> CommitAllEmployeeChanges();
    }
}
