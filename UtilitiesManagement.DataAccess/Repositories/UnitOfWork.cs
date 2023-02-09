using GharbiaUtilitiesManagement.DataAccess.Repositories.Bill;
using GharbiaUtilitiesManagement.DataAccess.Repositories.Shared;
using GharbiaUtilitiesManagement.Domain.Interfaces.Bill;
using GharbiaUtilitiesManagement.Domain.Interfaces.Shared;
using UtilitiesManagement.DataAccess.Repositories.Notifications;
using UtilitiesManagement.Domain.Interfaces.Notifications;

namespace  UtilitiesManagement.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    { 
        private readonly UtilitiesDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILoggingRepository _customlogging;
        private readonly RoleManager<ApplicationRole> roleManager;
        private readonly ILogger _logger;
        private readonly IConfiguration _config;
        public ICompanyRepository Companies { get; private set; }
        public IBranchRepository Branches { get; private set; }
        public IEmployeeRepository Employees { get; private set; }
        public IUsersRepository Users { get; private set; }
        public IStateRepository State { get; private set; }
        public IStatusRepository Status { get; private set; }                   
        public IOnlineUserRepository OnlineUsers { get; private set; }
        public ITechnicianLocationRepository TechnicianLocations { get; }
        public ITechnicianRepository Technicians { get; private set; }
        public ITechnicianWalkingLineRepository TechnicianWalkingLines { get; private set; }
        public IRolesRepository Permissions { get; private set; }
        public IUserRolesRepository UserRoles { get; private set; }
        public IRoleClaimsRepository RoleClaims { get; }
        public IComplaintTypeRepository ComplaintTypes { get; }
        public IMeterReadingRepository MeterReadings { get; }
        public IComplaintRepository Complaints { get; }
        public IEmployeeTempRepository Employee_Temp { get; }
        public IUpdatedCustomerRepository UpdatedCustomers { get; }


        public IBillPaymentSafeRepository BillPaymentSafe { get; }
        public IBillSafesRepository BillSafes { get; }
        public IComplaintImageRepository ComplaintImages { get; }
        public ICustomerDataTempRepository CustomerData_Temp { get; }
        public IEmployeeBlocksRepository EmployeeBlocks { get; }
        public IAreaRepository Areas { get; }
        public IBlockRepository Blocks { get; }
        public ICustomerDataRepository CustomerData { get; }
        public IIssueRepository Issue { get; }
        public IIssueDetailsRepository IssueDetails { get; }
        public ICustomerActivityRepository CustomerActivities { get; }
        public ICustomerStatusRepository CustomerStatus { get; }
        public IMeterReadingStatusRepository MeterReadingStatus { get; }
        public IBillRepository Bills { get; }
        public IBillPaymentRepository BillPayment { get; }
        public IBillTransactionsRepository BillTransactions { get; }
        public IUpdatedCustomerTypeRepository UpdatedCustomerTypes { get; }
        public IDailyStatisticsReportRepository DailyStatistics { get; }
        public IPermMenuRepository PermMenu { get; }
        public IBillPrintLogRepository PrintLog { get; }
        public INotiFcmConfigRepository NotiFcmConfig { get; }
        public IMeterReadingLogRepository MeterReadingLogs { get; }
        public INoti_NotiModulesRepository NotiModules { get; }
        public INotiUserModuleRepository NotiUserModules { get; }

        public INotiMessageRepository NotiMessage { get; }
        public INotiMessageUserRepository MessageUser { get; }
        public IPayDataLogRepository PayDataLog { get; }
        public IUserBranchesRepository UserBranches { get; }
        public ICityRepository Cities { get; }
        public IMainBillsTempRepository Bills_Temp { get; }
        public IAreaTempRepository Areas_Temp { get; }
        public IBlockTempRepository Blocks_Temp { get; }
        public IBranchTempRepository Branchs_Temp { get; }
        public ICityTempRepository Cities_Temp { get; }
        public IStateTempRepository States_Temp { get; }
        public UnitOfWork(UtilitiesDbContext context, IMapper mapper, ILoggingRepository loggingRepository,
                          ILoggerFactory loggerFactory,RoleManager<ApplicationRole> _roleManager,IConfiguration config, IHttpContextAccessor accessor)
        {
            _context = context;
            _mapper = mapper;
            _logger = loggerFactory.CreateLogger("logs");
            _customlogging = loggingRepository;
            _config = config;
            roleManager = _roleManager;
            Areas_Temp = new AreaTempRepository(context, _customlogging, _logger, _mapper, _config, accessor);
            Blocks_Temp = new BlockTempRepository(context, _customlogging, _logger, _mapper, _config, accessor);
            Branchs_Temp = new BranchTempRepository(context, _customlogging, _logger, _mapper, _config, accessor);
            Cities_Temp = new CityTempRepository(context, _customlogging, _logger, _mapper, _config, accessor);
            States_Temp = new StateTempRepository(context, _customlogging, _logger, _mapper, _config, accessor);
            Companies = new CompanyRepository(_context, _mapper, _customlogging, _logger, _config, accessor);
            Branches = new BranchRepository(_context, _mapper, _customlogging, _logger, _config, accessor);
            BillPaymentSafe = new BillPaymentSafeRepository(context, _mapper, _customlogging, _logger, _config, accessor);
            BillSafes = new BillSafesRepository(context, _mapper, _customlogging, _logger, _config, accessor);
            Employees = new EmployeeRepository(_context, _mapper, _customlogging, _logger, _config, accessor);
            Users = new UsersRepository(_context, _mapper, _customlogging, _logger, _config, accessor);                         
            OnlineUsers = new OnlineUserRepository(_context, _mapper, _customlogging, _logger, _config, accessor);
            UserRoles = new UserRolesRepository(_context, _mapper, _customlogging, _logger, roleManager, _config, accessor);
            TechnicianLocations = new TechnicianLocationRepository(_context, _mapper, _customlogging, _logger, _config, accessor);
            Technicians = new TechnicianRepository(_context, _mapper, _customlogging, _logger, _config, accessor);
            TechnicianWalkingLines = new TechnicianWalkingLineRepository(_context, _mapper, _customlogging, _logger, _config, accessor);
            Permissions = new RolesRepository(_context, _mapper, _customlogging, _logger, roleManager, _config, accessor);
            RoleClaims = new RoleClaimsReository(_context, _mapper, _customlogging, _logger, roleManager, _config, accessor);
            ComplaintTypes = new ComplaintTypeRepository(_context, _mapper, _customlogging, _logger, _config, accessor);
            MeterReadings = new MeterReadingRepository(_context, _mapper, _customlogging, _logger, _config, accessor);
            Complaints = new ComplaintRepository(_context, _mapper, _customlogging, _logger, _config, accessor);
            UpdatedCustomers = new UpdetedCustomerRepository(_context, _mapper, _customlogging, _logger, _config, accessor);
            ComplaintImages = new ComplaintImageRepository(_context, _mapper, _customlogging, _logger, _config, accessor);
            EmployeeBlocks = new EmployeeBlockRepository(_context, _mapper, _customlogging, _logger, _config, accessor);
            Areas = new AreaRepository(_context, _mapper, _customlogging, _logger, _config, accessor);
            Blocks = new BlockRepository(context, _mapper, _customlogging, _logger, _config, accessor);
            CustomerData = new CustomerDataRepository(context, _mapper, _customlogging, _logger, _config, accessor);
            Issue = new IssueRepository(context, _mapper, _customlogging, _logger, _config, accessor);
            IssueDetails = new IssueDetailsRepository(context, _mapper, _customlogging, _logger, _config, accessor);
            Bills = new BillRepository(context, _mapper, _customlogging, _logger, _config, accessor);
            BillPayment = new BillPaymentRepository(context, _mapper, _customlogging, _logger, _config, accessor);
            BillTransactions = new BillTransactionRepository(context, _mapper, _customlogging, _logger, _config, accessor);
            Bills_Temp = new MainBillsTempRepository(context, _customlogging, _logger, _mapper, _config, accessor);
            MeterReadingStatus = new MeterReadingStatusRepository(context, _mapper, _customlogging, _logger, _config, accessor);
            UpdatedCustomerTypes = new UpdetedCustomerTypeRepository(context, _mapper, _customlogging, _logger, _config, accessor);
            CustomerActivities = new CustomerActivityRepository(context, _mapper, _customlogging, _logger, _config, accessor);
            CustomerStatus = new CustomerStatusRepository(context, _mapper, _customlogging, _logger, _config, accessor);
            DailyStatistics = new DailyStatisticsReportRepository(context, _mapper, _customlogging, _logger, _config, accessor);
            PermMenu = new PermMenuRepository(context, _mapper, _customlogging, _logger, _config, accessor);
            MeterReadingLogs = new MeterReadingLogRepository(context, _mapper, _customlogging, _logger, _config, accessor);
            PrintLog = new BillPrintLogRepository(context, _customlogging, _logger, _mapper, _config, accessor);
            NotiFcmConfig = new NotiFcmConfigRepository(context, _customlogging, _logger, _mapper, _config, accessor);
            NotiModules = new NotiModulesRepository(context, _customlogging, _logger, _mapper, _config, accessor);
            NotiUserModules = new NotiUserModuleRepository(context, _customlogging, _logger, _mapper, _config, accessor);
            NotiMessage = new NotiMessageRepository(context, _customlogging, _logger, _mapper, _config, accessor);
            MessageUser = new NotiMessageUserRepository(context, _customlogging, _logger, _mapper, _config, accessor);
            UserBranches = new UserBranchesRepository(context, _customlogging, _logger, _mapper, _config, accessor);
            PayDataLog = new PayDataLogRepository(context, _customlogging, _logger, _mapper, _config, accessor);
            State = new StateRepository(context, _customlogging, _logger, _mapper, _config, accessor);
            Cities = new CityRepository(context, _customlogging, _logger, _mapper, _config, accessor);
            Employee_Temp = new EmployeeTempRepository(context, _customlogging, _logger, _mapper, _config, accessor);
            CustomerData_Temp = new CustomerDataTempRepository(context, _customlogging, _logger, _mapper, _config, accessor);
        }
        public IDatabaseTransaction BeginTransaction() => new EntityDatabaseTransaction(_context);

        public async Task<int> CompleteAsync() => await _context.SaveChangesAsync();

        public void Dispose() => _context.Dispose();
  
        public int Complete() => _context.SaveChanges();
    }
}
