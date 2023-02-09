namespace UtilitiesManagement.Services.Services.Technician
{
    public class TechnicianLocationService : ITechnicianLocationsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILoggingRepository _customLog;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;
        public TechnicianLocationService(IUnitOfWork unitOfWork, IMapper mapper,
                                    ILoggingRepository loggingRepository,
                                    IStringLocalizer<SharedResource> sharLocalizer)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _customLog = loggingRepository;
            _sharLocalizer = sharLocalizer;
        }

        public async Task<Response<AddTechnicianLogRequest>> AddNewTechnicianLog(AddTechnicianLogRequest model)
        {
            try
            {
                var CheckEmployeeObject = await _unitOfWork.Employees.GetFirstOrDefaultAsync(filter: x => x.Id == model.EmployeeId && !x.IsDeleted);
                if (CheckEmployeeObject == null)
                {
                    return new Response<AddTechnicianLogRequest>()
                    {
                        IsSuccess = false,
                        Message = String.Format(_sharLocalizer[SDLocalization.NotFoundData, model.EmployeeId]),
                        Errors = new[] { string.Format(_sharLocalizer[SDLocalization.NotFoundData, model.EmployeeId]) }
                    };
                }

                if (!CheckEmployeeObject.IsActive)
                {
                    return new Response<AddTechnicianLogRequest>()
                    {
                        IsSuccess = false,
                        Message = String.Format(_sharLocalizer[SDLocalization.TheEmployeeNotActive]),
                        Errors = new[] { String.Format(_sharLocalizer[SDLocalization.NotActive]) }
                    };
                }
                if (!CheckEmployeeObject.IsTechnician)
                {
                    CheckEmployeeObject.IsTechnician = true;
                    _unitOfWork.Employees.Update(CheckEmployeeObject);
                }
                var GetActiveEmployeeTechnicians = await _unitOfWork.Technicians.GetFirstOrDefaultAsync(filter: x => x.Employee_Id == model.EmployeeId && x.IsActive == true && !x.IsDeleted, ignoreQueryFilters: true);

                if (GetActiveEmployeeTechnicians != null)
                {
                    GetActiveEmployeeTechnicians.IsActive = false;
                    _unitOfWork.Technicians.Update(GetActiveEmployeeTechnicians);
                }
                var newTechnician = new TechTechnician()
                {
                    Employee_Id = model.EmployeeId,
                    AttachImageEditCustomer = model.AttachImageEditCustomer,
                    AttachImageRead = model.AttachImageRead,
                    CanCollect = model.CanCollect,
                    CanComplain = model.CanComplain,
                    CanRead = model.CanRead,
                    CanEditCustomer = model.CanEditCustomer,
                    MaxOfflineWorkingBills = model.MaxOfflineWorkingBills,
                    MaxOfflineWorkingHours = model.MaxOfflineWorkingHours,
                    IsActive = true,
                    IsDeleted = false
                };
                await _unitOfWork.Technicians.AddAsync(newTechnician);
                await _unitOfWork.CompleteAsync();
                return new Response<AddTechnicianLogRequest>()
                {
                    IsSuccess = true,
                    Data = _mapper.Map<AddTechnicianLogRequest>(newTechnician),
                    Message = String.Format(_sharLocalizer[SDLocalization.Done])
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(model), LogType.Bug);
                return new Response<AddTechnicianLogRequest>()
                {
                    IsSuccess = false,
                    Message = String.Format(_sharLocalizer[SDLocalization.Error]),
                    Errors = new[] { String.Format(_sharLocalizer[SDLocalization.Error]) }
                };
            }
        }

        public async Task<Response<IEnumerable<TechTechnicianLocationRequest>>> AddTechniciansLocations(List<TechTechnicianLocationRequest> technicianLocationRequest)
        {
            string err = _sharLocalizer[SDLocalization.Error];
            try
            {
                var locations = _mapper.Map<IEnumerable<TechTechnicianLocation>>(technicianLocationRequest
                    .GroupBy(x => new { x.Technician_Id, x.X, x.Y })
                    .Select(x => x.First()));

                await _unitOfWork.TechnicianLocations.AddRangeAsync(locations);
                bool result = await _unitOfWork.CompleteAsync() > 0;

                
                
                return new Response<IEnumerable<TechTechnicianLocationRequest>>()
                {
                    IsSuccess = result,
                    Data = _mapper.Map<IEnumerable<TechTechnicianLocationRequest>>(locations),
                    Errors = new string[] { },
                    Message = result ? _sharLocalizer[SDLocalization.Done] : err
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(technicianLocationRequest));
                return new Response<IEnumerable<TechTechnicianLocationRequest>>()
                {
                    Errors = new string[] { err },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }
        }

        public async Task<Response<IEnumerable<SharSearchForLocationResponse>>> GetAllLocationsByFilterationForTechnicianAsync(SharSearchForLocationRequest searchForLocationRequest)
        {
            try
            {
                searchForLocationRequest.EndDate = searchForLocationRequest.EndDate == null ?
                    searchForLocationRequest.EndDate : searchForLocationRequest.EndDate.Value.
                    AddHours(23).AddMinutes(59).AddSeconds(59);

                var result = (await _unitOfWork.TechnicianLocations.GetAllAsync(a =>
                (searchForLocationRequest.EmployeeId == null || a.Technician.Employee_Id == searchForLocationRequest.EmployeeId) && !a.IsDeleted && !a.Technician.IsDeleted
                //&&
                //a.Technician.Employee.Branch_Id == searchForLocationRequest.CompanyBranchId
                &&
                (searchForLocationRequest.StartDate == null || a.MobileDate!.Value.Date >= searchForLocationRequest.StartDate.Value.Date)
                &&
                (searchForLocationRequest.EndDate == null || a.MobileDate!.Value.Date <= searchForLocationRequest.EndDate.Value.Date)
                &&
                !a.IsDeleted, ignoreQueryFilters: true,
                includeProperties: "Technician,Technician.Employee"
             ))
             .OrderBy(a => a.Technician.Employee_Id)
             .ThenBy(a => a.Id);
                ;
                var lastResult = result.Select(a => new SharSearchForLocationResponse
                {
                    Id = a.Id,
                    X = a.X,
                    Y = a.Y,
                    Name = a.Technician.Employee.Name,
                    Date = a.MobileDate!.Value.ToShortDateString() + ' ' + a.MobileDate.Value.ToShortTimeString(),
                    Status = a.Id == result.FirstOrDefault(x => x.Technician.Employee.Id == a.Technician.Employee_Id)!.Id
                 ? false : (a.Id == result.LastOrDefault(x => x.Technician.Employee_Id == a.Technician.Employee_Id)!.Id ? true : null)
                })
              .ToList();

                if (lastResult.Equals(null) || lastResult.ToList().Count == 0)
                {
                    string resultMsg = _sharLocalizer[SDLocalization.NotFoundData];

                    return new Response<IEnumerable<SharSearchForLocationResponse>>()
                    {
                        Data = new List<SharSearchForLocationResponse>(),
                        IsNotFound = true,
                        Errors = new string[] { resultMsg },
                        Message = resultMsg
                    };
                }

                return new Response<IEnumerable<SharSearchForLocationResponse>>()
                {
                    IsSuccess = true,
                    Data = lastResult
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(searchForLocationRequest));
                return new Response<IEnumerable<SharSearchForLocationResponse>>()
                {
                    Errors = new string[] { _sharLocalizer[SDLocalization.Error] },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }
        }

        public async Task<Response<List<AuthLatestLocationForUserResponse>>> GetLastLocationToUserAsync(List<long> empsIds)
        {
            try
            {

                var result = (await _unitOfWork.TechnicianLocations.GetAllAsync(
                    filter: x => empsIds.Contains(x.Technician.Employee_Id) && !x.IsDeleted,
                    includeProperties: "Technician,Technician.Employee", ignoreQueryFilters: true))
                    .OrderByDescending(x => x.Id)
                    .DistinctBy(x => x.Technician.Employee_Id)
                    .Select(x => new AuthLatestLocationForUserResponse()
                    {
                        EmpName = x.Technician.Employee.Name,
                        X = x.X,
                        Y = x.Y,
                        Date = x.MobileDate!.Value.ToShortDateString() + ' ' + x.MobileDate.Value.
                        ToShortTimeString(),
                        Status = true
                    }).ToList();

                if (result == null || result.Count == 0)
                {
                    string resultMsg = _sharLocalizer[SDLocalization.NotFoundData];

                    return new Response<List<AuthLatestLocationForUserResponse>>()
                    {
                        Data = new List<AuthLatestLocationForUserResponse>(),
                        IsNotFound = true,
                        Errors = new string[] { resultMsg },
                        Message = resultMsg
                    };
                }
                return new Response<List<AuthLatestLocationForUserResponse>>()
                {
                    IsSuccess = true,
                    Data = result
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex,"");
                return new Response<List<AuthLatestLocationForUserResponse>>()
                {
                    Errors = new string[] { _sharLocalizer[SDLocalization.Error] },
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message)
                };
            }
        }

        public async Task<Response<TechGetLastTechnician>> GetLastRecordTechnician(int EmployeeId)
        {
            try
            {
                var Employee = _unitOfWork.Employees.GetFirstOrDefault(filter: x => x.Id == EmployeeId && !x.IsDeleted);
                if (Employee == null)
                {
                    return new Response<TechGetLastTechnician>()
                    {
                        Message = _sharLocalizer[SDLocalization.NotFoundData, EmployeeId],
                        Errors = new[] { string.Format(_sharLocalizer[SDLocalization.NotFoundData, EmployeeId]) },
                        IsSuccess = false,
                        IdOfAddedObject = EmployeeId,
                        Data = new TechGetLastTechnician()
                    };
                }
                if (!Employee.IsActive)
                {
                    return new Response<TechGetLastTechnician>()
                    {
                        Message = _sharLocalizer[SDLocalization.TheEmployeeNotActive],
                        Errors = new[] { string.Format(_sharLocalizer[SDLocalization.NotFoundData, EmployeeId]) },
                        IsSuccess = false,
                        IdOfAddedObject = EmployeeId
                    };
                }
                var EmployeeTechnician = (await _unitOfWork.Technicians.GetAllAsync(filter: x => x.Employee_Id == EmployeeId)).OrderBy(x => x.Id).LastOrDefault();
                if (EmployeeTechnician == null)
                {
                    return new Response<TechGetLastTechnician>()
                    {
                        Message = _sharLocalizer[SDLocalization.Data],
                        IsSuccess = true,
                        Data = new TechGetLastTechnician() { DeleteDate = DateTime.Now, EmployeeId = EmployeeId, InsertDate = DateTime.Now, UpdateDate = DateTime.Now },
                        IdOfAddedObject = Employee.Id
                    };
                }
                return new Response<TechGetLastTechnician>()
                {
                    Message = _sharLocalizer[SDLocalization.Data],
                    IsSuccess = true,
                    Data = _mapper.Map<TechGetLastTechnician>(EmployeeTechnician),
                    IdOfAddedObject = Employee.Id
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex,"");
                return new Response<TechGetLastTechnician>()
                {
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] {ex.Message}
                };
            }

        }

        public async Task<Response<IEnumerable<TechGetLastTechnician>>> getTechnicianLogs(int EmployeeId)
        {
            try
            {
                var result = await _unitOfWork.Technicians.GetSpecificSelectAsync(
                          x => x.Employee_Id == EmployeeId && !x.IsDeleted,
                          select: x => new TechGetLastTechnician
                          {
                              AttachImageEditCustomer = x.AttachImageEditCustomer,
                              AttachImageRead = x.AttachImageRead,
                              CanEditCustomer = x.CanEditCustomer,
                              CanComplain = x.CanComplain,
                              CanCollect = x.CanCollect,
                              CanRead = x.CanRead,
                              EmployeeId = x.Employee_Id,
                              IsActive = x.IsActive,
                              MaxOfflineWorkingBills = x.MaxOfflineWorkingBills,
                              MaxOfflineWorkingHours = x.MaxOfflineWorkingHours,
                              DeleteDate = x.DeleteDate,
                              InsertDate = x.InsertDate,
                              UpdateDate = x.IsActive ==true ? null: x.UpdateDate

                          }, orderBy: x =>
                  x.OrderByDescending(x => x.Id));

                var SearchedEmployee = _unitOfWork.Employees.GetFirstOrDefault(filter: x => x.Id == EmployeeId && x.IsActive && !x.IsDeleted);
                if (SearchedEmployee == null) return new Response<IEnumerable<TechGetLastTechnician>>();
                return new Response<IEnumerable<TechGetLastTechnician>>()
                {
                    Data = result,
                    IsSuccess = true,
                    Message = _sharLocalizer[SDLocalization.Data]
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex,"");
                return new Response<IEnumerable<TechGetLastTechnician>>()
                {
                    Errors = new[] { ex.Message },
                    Message = _sharLocalizer[SDLocalization.Error]
                };
            }

        }

        public async Task<Response<string>> StopTechnician(int employeeId)
        {
            var MSG = "";
            try
            {
                var SearchedEmployeeDetails = await _unitOfWork.Employees.GetFirstOrDefaultAsync(filter: x => x.Id == employeeId && !x.IsDeleted);
                if (SearchedEmployeeDetails == null)
                {
                    MSG = String.Format(_sharLocalizer[SDLocalization.CannotBeFound], employeeId);
                    return new Response<string>()
                    {
                        IsUpdated = false,
                        IsSuccess = false,
                        Message = MSG,
                        Errors = new[] { MSG },
                        Data = MSG
                    };
                }
                if (!SearchedEmployeeDetails.IsActive)
                {
                    MSG = String.Format(_sharLocalizer[SDLocalization.TheEmployeeNotActive]);
                    return new Response<string>()
                    {
                        IsUpdated = false,
                        IsSuccess = false,
                        Message = MSG,
                        Errors = new[] { MSG },
                        Data = MSG
                    };
                }
                if (!SearchedEmployeeDetails.IsTechnician)
                {
                    MSG = String.Format(_sharLocalizer[SDLocalization.ThisEmployeeIsNotTechnician]);
                    return new Response<string>()
                    {
                        IsUpdated = false,
                        IsSuccess = false,
                        Message = MSG,
                        Errors = new[] { MSG },
                        Data = MSG
                    };
                }
                SearchedEmployeeDetails.IsTechnician = false;
                _unitOfWork.Employees.Update(SearchedEmployeeDetails);
                var EmployeeActiveTechnician = await _unitOfWork.Technicians.GetFirstOrDefaultAsync(filter: x => x.Employee_Id == SearchedEmployeeDetails.Id && x.IsActive && !x.IsDeleted);
                if (EmployeeActiveTechnician != null)
                {
                    EmployeeActiveTechnician.IsActive = false;
                    _unitOfWork.Technicians.Update(EmployeeActiveTechnician);
                }
                await _unitOfWork.CompleteAsync();

                MSG = String.Format(_sharLocalizer[SDLocalization.Updated]);

                return new Response<string>()
                {
                    IsSuccess = true,
                    IsUpdated = true,
                    Message = MSG,
                    Data = MSG,
                    IdOfAddedObject = SearchedEmployeeDetails.Id
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex,"");
                MSG = String.Format(_sharLocalizer[SDLocalization.Error]);
                return new Response<string>()
                {
                    IsUpdated = false,
                    IsSuccess = false,
                    Message = MSG,
                    Errors = new[] { MSG },
                    Data = MSG
                };
            }
        }
    }
}
