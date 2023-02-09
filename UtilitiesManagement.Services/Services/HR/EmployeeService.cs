namespace UtilitiesManagement.Services.Services.HR
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _accessor;
        private readonly ILoggingRepository _customLog;
        public EmployeeService(IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharLocalizer,
                               ILoggingRepository loggingRepository, IMapper mapper, 
                               IHttpContextAccessor accessor)
        {
            _unitOfWork = unitOfWork;
            _sharLocalizer = sharLocalizer;
            _mapper = mapper;
            _accessor = accessor;
            _customLog = loggingRepository;
        }

        public async Task<Response<HrEmployeeProfileResponse>> GetEmployeeProfile(int employeeId)
        {
            try
            {
                var Employee = await _unitOfWork.Employees.GetSpecificSelectAsync(filter: x => x.Id == employeeId && !x.IsDeleted && x.IsActive, select: y => new HrEmployeeProfileResponse()
                {
                    Id = employeeId,
                    Blocks = y.EmployeeBlocks.Select(g => new CollectorBlocks { BlockName= g.Block.BlockName, BlockCode=g.Block.BlockCode,AreaName = g.Block.Area.AreaName,Id = g.Id,EndDate = g.EndDate,StartDate = g.StartDate } ).ToList(),
                    BranchName = y.Branch.BranchName,
                    EmployeeJob = y.Job,
                    EmployeeName = y.Name,
                    IsTechnician = y.IsTechnician,
                    Technician = _mapper.Map<TechnicianObj>(y.TechnicianLogs.OrderBy(q => q.Id).LastOrDefault()),
                    UserIsActive = y.IsActive
                });
                if (Employee == null)
                {
                    return new Response<HrEmployeeProfileResponse>()
                    {
                        Data = new HrEmployeeProfileResponse(),
                        Errors = new[] { string.Format(_sharLocalizer[SDLocalization.CannotBeFound], employeeId) },
                        Message = string.Format(_sharLocalizer[SDLocalization.CannotBeFound], employeeId),
                        IsSuccess = false
                    };
                }
                return new Response<HrEmployeeProfileResponse>()
                {
                    Data = Employee.FirstOrDefault(),
                    IsSuccess = true,
                    Message = _sharLocalizer[SDLocalization.Data]
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex,"");
                return new Response<HrEmployeeProfileResponse>()
                {
                    Errors = new[] { ex.Message },
                    Message = string.Format(_sharLocalizer[SDLocalization.Error]),
                    IsSuccess = false
                };
            }
        }

        public async Task<Response<List<HrEmployeeProfileResponse>>> GetEmployeesData(long? BranchId, long? StateId, long? CityId, long? AreaId, long? BlockId)
        {
            try
            {
                var EmployeesData = (await _unitOfWork.Employees.GetSpecificSelectAsync(filter: x => (x.Branch_Id == BranchId || BranchId == null) && (x.Branch.States.Any(u => u.Id == StateId) || StateId == null) && (CityId == null || x.Branch.States.FirstOrDefault(y => y.Id == StateId)!.Cities.Any(y => y.Id == CityId)) && (AreaId == null || x.Branch.States.FirstOrDefault(y => y.Id == StateId)!.Cities.FirstOrDefault(y => y.Id == CityId)!.Areas.Any(y => y.Id == AreaId)) && (BlockId == null || x.Branch.States.FirstOrDefault(y => y.Id == StateId)!.Cities.FirstOrDefault(y => y.Id == CityId)!.Areas.FirstOrDefault(y => y.Id == AreaId)!.Blocks.Any(y => y.Id == BlockId)), select: r => new HrEmployeeProfileResponse()
                {
                    Blocks = r.EmployeeBlocks.Select(g => new CollectorBlocks { BlockName = g.Block.BlockName, BlockCode = g.Block.BlockCode, AreaName = g.Block.Area.AreaName, Id = g.Id, EndDate = g.EndDate, StartDate = g.StartDate }).ToList(),
                    BranchName = r.Branch.BranchName,
                    EmployeeJob = r.Job,
                    EmployeeName = r.Name,
                    Id = r.Id,
                    IsTechnician = r.IsTechnician,
                    Technician = _mapper.Map<TechnicianObj>(r.TechnicianLogs.OrderBy(q => q.Id).LastOrDefault()),
                    //Technician = _mapper.Map<Technician>(r.TechnicianLogs.OrderBy(q => q.Id).LastOrDefault()),
                    UserIsActive = r.IsActive
                })).ToList();
                return new Response<List<HrEmployeeProfileResponse>>()
                {
                    Data = EmployeesData,
                    IsSuccess = true,
                    Message = _sharLocalizer[SDLocalization.Data]
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex,"");
                return new Response<List<HrEmployeeProfileResponse>>()
                {
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] {ex.Message}
                };
            }
        }

        public async Task<Response<List<SharSelectListGroupResponse>>> ListOfEmployee(long? BranchId, long? StateId , long? CityId , long? AreaId, long? BlockId)
        {
            try
            {
                int? companyId = _accessor!.HttpContext == null ? null : _accessor!.HttpContext!.User.GetCompanyId();

                //var EmpData = (await _unitOfWork.EmployeeBlocks.GetAllAsync(filter: x => (x.Employee.Branch.Company_Id== companyId) &&(x.Block_Id == BlockId || BlockId == null) && (x.Employee.Branch_Id == BranchId || BranchId == null) && (x.Employee.Branch.Areas.Any(y => y.Id == AreaId) || AreaId == null), includeProperties: "Employee,Employee.Branch,Employee.Branch.Areas")).Select(t => t.Employee);

                //var x = EmpData.GroupBy(new);
                var EmployeesData = (await _unitOfWork.Employees.GetSpecificSelectAsync(filter: x => (x.Branch_Id == BranchId || BranchId == null) && ( StateId == null || x.Branch.States.Any(x => x.Id == StateId)) && ( CityId == null || x.Branch.States.FirstOrDefault(y => y.Id == StateId)!.Cities.Any(y => y.Id == CityId)) && (AreaId == null || x.Branch.States.FirstOrDefault(y => y.Id == StateId)!.Cities.FirstOrDefault(y => y.Id == CityId)!.Areas.Any(y => y.Id == AreaId)) && (BlockId == null || x.Branch.States.FirstOrDefault(y => y.Id == StateId)!.Cities.FirstOrDefault(y => y.Id == CityId)!.Areas.FirstOrDefault(y => y.Id == AreaId)!.Blocks.Any(y => y.Id == BlockId)), select: r => new SharSelectListGroupResponse()
                {
                    //Title =String.Join(",",r.EmployeeBlocks.Select(g => g.Block.BlockName).ToArray()),
                    //Group = String.Join(",", r.EmployeeBlocks.Select(g => g.Block.Area.AreaName).ToArray()),
                    Title = "",
                    Group = "",
                    Name = r.Name,
                    Id = r.Id,
                  
                })).ToList();

                return new Response<List<SharSelectListGroupResponse>>()
                {

                    Data = EmployeesData,
                    IsSuccess = true,
                    Message = _sharLocalizer[SDLocalization.Data]
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex,"");
                return new Response<List<SharSelectListGroupResponse>>()
                {
                    IsSuccess = false,
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] { ex.Message }
                };
            }

        }

        public async Task<Response<List<SelectListResponse>>> ListOfUsersEmployee(long? BranchId)
        {
            try
            {
                var data = (await _unitOfWork.Users.GetSpecificSelectAsync(filter: x => x.IsActive && !x.IsDeleted && (x.Employee.Branch_Id == BranchId || BranchId == null), select: x => new SelectListResponse()
                {
                    Id = x.Employee_Id,
                    Name = x.Employee.Name
                })).ToList();
                return new Response<List<SelectListResponse>>() { Data = data, IsSuccess = true, Message = _sharLocalizer[SDLocalization.Data] };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, "");
                return new Response<List<SelectListResponse>>() { Data = new List<SelectListResponse>(), Message = _sharLocalizer[SDLocalization.Error], IsSuccess = false };
            }
        }

        public async Task<Response<string>> ManageRemoteEmployeesData()
        {

                try
                {
                    // Get Employees Data
                    var LastReaderObject = _unitOfWork.Employees.GetFirstOrDefault(filter: x => x.IsReader != null && x.IsReader == true,orderBy: x => x.OrderByDescending(x => x.Id));
                    var LastCollectorObject = _unitOfWork.Employees.GetFirstOrDefault(filter: x => x.IsReader != null && x.IsReader == false, orderBy: x => x.OrderByDescending(x => x.Id));

                    var NewEmployeeData = _mapper.Map<List<HrEmployee>>((await _unitOfWork.Employees.Remote_GetRunnerData(LastReaderObject != null ? long.Parse(LastReaderObject.Code!) : 0 , LastCollectorObject != null ? long.Parse(LastCollectorObject.Code!) : 0)));
                    await _unitOfWork.Employees.AddRangeAsync(NewEmployeeData);
                    await _unitOfWork.CompleteAsync();


                    //// Update Employees Data
                    //var AllEmployeeData = _mapper.Map<List<HrEmployee_Temp>>((await _unitOfWork.Employees.Remote_GetRunnerData(0))).DistinctBy(x => x.Id);
                    //_unitOfWork.Employee_Temp.AddRangeAsync(AllEmployeeData).Wait();
                    //await _unitOfWork.CompleteAsync();
                    //await _unitOfWork.Employees.CommitAllEmployeeChanges();

                    
                    //_unitOfWork.EmployeeBlocks.HardRemoveRange(_unitOfWork.EmployeeBlocks.GetAll().ToList());
                    //await _unitOfWork.CompleteAsync();

                    var RemoteBlocksDataList = (await _unitOfWork.EmployeeBlocks.Remote_GetRunnerBlocksData());
                    var AddingRemoteEmployeeBlocks = _mapper.Map<List<HrEmployeeBlocks>>(RemoteBlocksDataList);

                //foreach (var checkingItem in AddingRemoteEmployeeBlocks)
                //{
                //    if(!_unitOfWork.Employees.ExistAsync(filter: x=> x.Id == checkingItem.Collector_Id).Result)
                //    {
                //        checkingItem.Collector_Id = 1515157;
                //    }
                //}

                    await _unitOfWork.EmployeeBlocks.AddRangeAsync(AddingRemoteEmployeeBlocks);

                    await _unitOfWork.CompleteAsync();


                return new Response<string>()
                    {
                        Message = _sharLocalizer[SDLocalization.Done],
                        IsSuccess = true
                    };
                }
                catch (Exception ex)
                {
                    await _customLog.LogExceptionInDb(ex,"");
                    return new Response<string>()
                    {
                        Message = _sharLocalizer[SDLocalization.Error],
                        Errors = new[] {ex.Message}
                    };
                }
            }
           
        }
    }

