using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManagement.Domain.Dtos.Request.DashBoard;
using UtilitiesManagement.Domain.ViewModels.DashBoard;
using UtilitiesManagement.Services.Hubs.DashBoard;

namespace UtilitiesManagement.Services.Services.Report
{
    public class DashBoardServices: IDashBoardServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;
        private readonly ILoggingRepository _customLog;
        private readonly IMapper _mapper;
        private readonly IHubContext<OperationsHub, GeneralInterfaces> _operationsHub;
        private readonly IServer server;
        public DashBoardServices(IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharLocalizer, ILoggingRepository loggingRepository, IMapper mapper, IHubContext<OperationsHub, GeneralInterfaces> operationsHub, IServer server)
        {
            _unitOfWork = unitOfWork;
            _sharLocalizer = sharLocalizer;
            _customLog = loggingRepository;
            _mapper = mapper;
            _operationsHub = operationsHub;
            this.server = server;
        }

        public async Task<Response<List<CustomerBillStatistics>>> GetCustomerBillsStatistics(DashBoardCustomerBillsStatRequest model)
        {
            try
            {
                var remoteData = (await _unitOfWork.CustomerData.GetRemoteCustomerBillsCount(model)).ToList();
                var result = _mapper.Map<List<CustomerBillStatistics>>(remoteData);
                var customerData = (await _unitOfWork.Bills.GetAllAsync(filter: x => !x.IsDeleted,includeProperties: "BillIssue")).ToList();
                if(model.Collector_Id != null)
                {
                    foreach (var item in result)
                    {
                        item.collectionAmount = customerData.Count(x => x.BillIssue_Id == item.issueId && item.isu_IsDate == x.BillIssue.IssueName);
                    }
                }
                else if(model.IssueDate != null)
                    foreach (var item in result)
                    {
                        item.collectionAmount = customerData.Count(x => x.BillIssue_Id == item.issueId && x.Customer_Id == item.collectorId);
                    }
                else
                    foreach (var item in result)
                    {
                        item.collectionAmount = customerData.Count(x => x.BillIssue_Id == item.issueId && item.isu_IsDate == x.BillIssue.IssueName);
                    }
                return new Response<List<CustomerBillStatistics>>()
                {
                    Data = result,
                    IsSuccess = true,
                    Message = _sharLocalizer[SDLocalization.Data]
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, "");
                return new Response<List<CustomerBillStatistics>>()
                {
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] { ex.Message }
                };
            }

        }

        public async Task<Response<string[]>> GetURLs()
        {
            var addresses = server.Features.Get<IServerAddressesFeature>().Addresses.ToArray();
            return new Response<string[]>()
            {
                Data = addresses,
                IsSuccess = true,
            };
        }

        public async Task<Response<List<TotalMonthlyStatisticsForEmployee>>> TotalDailyStatisticsForEmployee(StatisticsRequest? model)
        {
            if (model.EndDate != null)
                model.EndDate = model.EndDate.Value.AddHours(23).AddMinutes(59).AddSeconds(59);
            var remoteData = (await _unitOfWork.Employees.TotalDailyStatisticsForEmployee(model)).ToList();
            return new Response<List<TotalMonthlyStatisticsForEmployee>>()
            {
                Data = remoteData,
                Message = _sharLocalizer[SDLocalization.Data],
                IsSuccess = true
            };
        }

        public async Task<Response<List<TotalMonthlyStatisticsForEmployee>>> TotalMonthlyStatisticsForEmployee(StatisticsRequest? model)
        {
            if (model.EndDate != null)
                model.EndDate = model.EndDate.Value.AddHours(23).AddMinutes(59).AddSeconds(59);
            var remoteData = (await _unitOfWork.Employees.TotalMonthlyStatisticsForEmployee(model)).ToList();
            return new Response<List<TotalMonthlyStatisticsForEmployee>>()
            {
                Data = remoteData,
                Message = _sharLocalizer[SDLocalization.Data],
                IsSuccess = true
            };
        }
    }
}
