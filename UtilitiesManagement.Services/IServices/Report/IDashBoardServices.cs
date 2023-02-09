using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManagement.Domain.Dtos.Request.DashBoard;
using UtilitiesManagement.Domain.ViewModels.DashBoard;

namespace UtilitiesManagement.Services.IServices.Report
{
    public interface IDashBoardServices
    {
        Task<Response<string[]>> GetURLs();
        Task<Response<List<CustomerBillStatistics>>> GetCustomerBillsStatistics(DashBoardCustomerBillsStatRequest model);
        Task<Response<List<TotalMonthlyStatisticsForEmployee>>> TotalMonthlyStatisticsForEmployee(StatisticsRequest? model);
        Task<Response<List<TotalMonthlyStatisticsForEmployee>>> TotalDailyStatisticsForEmployee(StatisticsRequest? model);
    }
}
