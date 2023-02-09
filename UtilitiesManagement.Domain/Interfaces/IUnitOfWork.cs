using GharbiaUtilitiesManagement.Domain.Interfaces.Bill;
using GharbiaUtilitiesManagement.Domain.Interfaces.Shared;
using UtilitiesManagement.Domain.Interfaces.Bill;
using UtilitiesManagement.Domain.Interfaces.Notifications;

namespace  UtilitiesManagement.Domain.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        //IBaseRepository<Author> Authors { get; }
        IDatabaseTransaction BeginTransaction();
        ICompanyRepository Companies { get; }
        IBranchRepository Branches { get; }
        IEmployeeRepository Employees { get; }
        IUsersRepository Users { get; }
        IStatusRepository Status { get;} 
        IOnlineUserRepository OnlineUsers { get; }
        IRolesRepository Permissions { get; }
        IUserRolesRepository UserRoles { get; }
        IRoleClaimsRepository RoleClaims { get; }
        ITechnicianRepository Technicians { get; }
        IComplaintTypeRepository ComplaintTypes { get; }
        IMeterReadingRepository MeterReadings { get; }
        IComplaintRepository Complaints { get; }
        IUpdatedCustomerRepository UpdatedCustomers { get; }
        IComplaintImageRepository ComplaintImages { get; }
        ITechnicianLocationRepository TechnicianLocations { get; }
        IEmployeeBlocksRepository EmployeeBlocks { get; }
        IAreaRepository Areas { get; }
        IBlockRepository Blocks { get; }
        ICustomerDataRepository CustomerData { get; }
        IIssueRepository Issue { get; }
        IIssueDetailsRepository IssueDetails { get; }
        IBillRepository Bills { get; }
        IBillPaymentRepository BillPayment { get; }
        IBillTransactionsRepository BillTransactions { get; }
        ICustomerActivityRepository CustomerActivities { get; }
        ICustomerStatusRepository CustomerStatus { get; }
        IMeterReadingStatusRepository MeterReadingStatus { get; }
        IUpdatedCustomerTypeRepository UpdatedCustomerTypes { get; }
        IDailyStatisticsReportRepository DailyStatistics { get; }
        IBillPrintLogRepository PrintLog { get; }
        IPermMenuRepository PermMenu { get; }
        IMeterReadingLogRepository MeterReadingLogs { get; }
        INotiFcmConfigRepository NotiFcmConfig { get; }
        INoti_NotiModulesRepository NotiModules { get; }
        INotiUserModuleRepository NotiUserModules { get; }
        INotiMessageRepository NotiMessage { get; }
        INotiMessageUserRepository MessageUser { get; }
        IUserBranchesRepository UserBranches { get; }
        IPayDataLogRepository PayDataLog { get; }
        IStateRepository State { get; }
        ICityRepository Cities { get; }
        IAreaTempRepository Areas_Temp { get; }
        IBlockTempRepository Blocks_Temp { get; }
        IBranchTempRepository Branchs_Temp { get; }
        ICityTempRepository Cities_Temp { get; }
        IStateTempRepository States_Temp { get; }
        IEmployeeTempRepository Employee_Temp { get; }
        ICustomerDataTempRepository CustomerData_Temp { get; }
        IMainBillsTempRepository Bills_Temp { get; }

        IBillSafesRepository BillSafes { get; }
        IBillPaymentSafeRepository BillPaymentSafe { get; }
        Task<int> CompleteAsync();
        int Complete();
    }
}
