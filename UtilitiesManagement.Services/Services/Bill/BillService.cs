



using Microsoft.AspNetCore.SignalR;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Drawing;
using System.Text;
using UtilitiesManagement.Services.Hubs.DashBoard;

namespace UtilitiesManagement.Services.Services.Bill
{
    public class BillService : IBillService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharLocalizer;
        private readonly ILoggingRepository _customLog;
        private readonly IMapper _mapper;
        private readonly IHubContext<OperationsHub, GeneralInterfaces> _operationsHub;
        private readonly IHttpContextAccessor _accessor;
        public BillService(IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharLocalizer, ILoggingRepository loggingRepository, IMapper mapper, IHubContext<OperationsHub, GeneralInterfaces> operationsHub, IHttpContextAccessor accessor)
        {
            _unitOfWork = unitOfWork;
            _sharLocalizer = sharLocalizer;
            _customLog = loggingRepository;
            _mapper = mapper;
            _operationsHub = operationsHub;
            _accessor = accessor;
        }
        public async Task<Response<List<BillPaymentResponse>>> GetEmployeeBills(int EmployeeId)
        {
            try
            {
                var Data = _mapper.Map<List<BillPaymentResponse>>((await _unitOfWork.BillPayment.GetAllAsync(filter: x => x.Employee_Id == EmployeeId && x.PayDate >= DateTime.Now.AddMonths(-1), includeProperties: "Transactions,Transactions.Bill,Transactions.Bill.BillIssue,CustomerData,CustomerData.Block,CustomerData.Block.Area,CustomerData.Block.Area.City.State.Branch,Employee")).ToList());
                return new Response<List<BillPaymentResponse>>()
                {
                    Data = Data,
                    IsSuccess = true,
                    Message = _sharLocalizer[SDLocalization.Data]
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, "");
                return new Response<List<BillPaymentResponse>>()
                {
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] { ex.Message }
                };
            }
        }

        private async Task<BillDataResponseWithPaggination> BillPaymentFilter(SearchParametersForBillsDataRequest searchParametersRequest)
        {
            if (searchParametersRequest.EndDate != null)
            {
                searchParametersRequest.EndDate = searchParametersRequest.EndDate.Value.AddHours(23).AddMinutes(59).AddSeconds(59);
            }
            string UserId = _accessor!.HttpContext == null ? "" : _accessor!.HttpContext!.User.GetUserId();
            var BranchesUsersIds = await _unitOfWork.Users.GetAssignedBranches(UserId);

            Expression<Func<BillPayment, bool>> filter = x => ((BranchesUsersIds.Contains(x.Employee.Branch_Id))
            && searchParametersRequest.IssueId == null || x.Transactions.Any(a => a.Bill.BillIssue_Id == searchParametersRequest.IssueId)) && ((searchParametersRequest.CustomerId == null || x.CustomerData_Id == searchParametersRequest.CustomerId) && (searchParametersRequest.CustomerCode == null || x.CustomerData.Code == searchParametersRequest.CustomerCode) && (searchParametersRequest.EmployeeId == null || x.Employee_Id == searchParametersRequest.EmployeeId) && (searchParametersRequest.BlockId == null || x.Employee.EmployeeBlocks.Any(c => c.Id == searchParametersRequest.BlockId)) && (searchParametersRequest.StateId == null || x.Employee.Branch.States.Any(c => c.Id == searchParametersRequest.StateId)) &&
                 (searchParametersRequest.CityId == null || x.Employee.Branch.States.FirstOrDefault(y =>y.Id == searchParametersRequest.StateId)!.Cities.Any(y=>y.Id == searchParametersRequest.CityId)) && (searchParametersRequest.AreaId == null || x.Employee.Branch.States.FirstOrDefault(y => y.Id == searchParametersRequest.StateId)!.Cities.FirstOrDefault(y =>y.Id==searchParametersRequest.CityId)!.Areas.Any(Y =>Y.Id == searchParametersRequest.AreaId)) &&(searchParametersRequest.BranchId == null || x.Employee.Branch_Id == searchParametersRequest.BranchId) && (searchParametersRequest.StartDate == null || searchParametersRequest.EndDate == null || (x.PayDate > searchParametersRequest.StartDate && x.PayDate < searchParametersRequest.EndDate)));


            return new BillDataResponseWithPaggination()
            {
                data = (await _unitOfWork.BillPayment.GetSpecificSelectAsync(filter: filter, ignoreQueryFilters: true, skip: ((searchParametersRequest.PageNumber - 1) * searchParametersRequest.PageSize), take: searchParametersRequest.PageSize
                , select: q => new BillDataResponse()
                {
                    CustomerData_Id = q.CustomerData_Id,
                    CustomerCode = q.CustomerData.Code,
                    Employee_Id = q.Employee_Id,
                    Block = q.CustomerData.Block.BlockName,
                    Area = q.CustomerData.Block.Area.AreaName,
                    Branch = q.CustomerData.Block.Area.City.State.Branch.BranchName,
                    CustomerName = q.CustomerData.Name,
                    CollectorName = q.Employee.Name,
                    Id = q.Id,
                    Notes = q.Notes,
                    PayDate = q.PayDate,
                    TotalAmount = q.Transactions.Sum(a => a.Amount),
                    IsRePrint = q.IsRePrint,
                    IsPayment = q.BillPaymentSafe_Id != null,
                    BillTransactions = q.Transactions.Select(q => new BillTransactionResponse
                    {
                        Amount = q.Amount,
                        BillPayment_Id = q.BillPayment_Id,
                        Bill_Id = q.Bill_Id,
                        Id = q.Id,
                        BillNum = q.Bill.BillNum,
                        BillValue = q.Bill.BillValue,
                        ContenutityService = q.Bill.ContenutityService,
                        CustomerPayingDate = q.Bill.CustomerPayingDate,
                        Customer_Id = q.Bill.Customer_Id,
                        Installment = q.Bill.Installment,
                        Maintenance = q.Bill.Maintenance,
                        Others = q.Bill.Others,
                        PayDate = q.Bill.PayDate,
                        RegularityService = q.Bill.RegularityService,
                        Tax14Percent = q.Bill.Tax14Percent,
                        WastWaterInstallment = q.Bill.WastWaterInstallment,
                        WaterInstallment = q.Bill.WaterInstallment,
                        WaterValue = q.Bill.WaterValue,
                        BillIssueName = q.Bill.BillIssue!.IssueName,
                        BillIssue_Id = q.Bill.BillIssue_Id ?? 0,
                        CurrentReading = q.Bill.CurrentReading,
                        PrevReading = q.Bill.PrevReading

                    }).ToList(),
                }, orderBy: a => a.OrderByDescending(z => z.Id))).ToList(),
                TotalCount = await _unitOfWork.BillPayment.Count(filter: filter, ignoreQueryFilters: true)
            };
        }

        public async Task<Response<BillDataResponseWithPaggination>> GetPaymentData(SearchParametersForBillsDataRequest searchParametersRequest)
        {
            try
            {
                var data = await BillPaymentFilter(searchParametersRequest);

                return new Response<BillDataResponseWithPaggination>()
                {
                    Data = new BillDataResponseWithPaggination() { data = data.data, TotalCount = data.TotalCount },
                    Message = _sharLocalizer[SDLocalization.Data],
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex,JsonConvert.SerializeObject(searchParametersRequest), LogType.Bug);
                return new Response<BillDataResponseWithPaggination>()
                {
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] {ex.Message}
                };
            }
        }

        public async Task<Response<List<BillData_ViewModel>>> GetBillDataByEmployee(long EmployeeId, long[] BlockIds)
        {
            try
            {
                var BlocksCodes =await _unitOfWork.Blocks.GetSpecificSelectAsync(x => BlockIds.Contains(x.Id), y => new String(y.BlockCode));
                return new Response<List<BillData_ViewModel>>()
                {
                    // Move Join After Condition
                    Data = (await _unitOfWork.Bills.Remote_GetBillData(EmployeeId, (BlockIds != null && BlockIds.Length != 0)?string.Join(",", BlocksCodes) :"")).ToList(),
                    IsSuccess = true,
                    Message = _sharLocalizer[SDLocalization.Data]
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, "GetBillDataByEmployee");
                return new Response<List<BillData_ViewModel>>()
                {
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] { ex.Message }
                };
            }
        }

        public async Task<Response<string>> PayBill(List<BillPaymentRequest> model)
        {
            try
            {

                //model.ToList().ForEach(r => r.CustomerData_Id = r.Transactions.FirstOrDefault().Bill.Customer_Id);

                var bills = model.SelectMany(Z => Z.Transactions).Select(n => n.Bill).ToList();
                var dublicateBillIds = bills.Select(a => a.Id).GroupBy(a => a).Select(g => new { Count = g.Count(), Value = g.Key }).ToArray().Where(a => a.Count > 1).Select(a => a.Value).ToList();

                //var xx = string.Join(",",x);
                //var RefusedBills = (await _unitOfWork.BillTransactions.GetAllAsync(filter: x => bills.Any(y => y.Id == x.Bill_Id && x.Bill.PayDate == y.PayDate && x.BillPayment.Employee_Id == model.FirstOrDefault()!.Employee_Id),includeProperties: "Bill,BillPayment")).ToList().Select(x => x.Bill.Id);
                var RefusedBills = (await _unitOfWork.BillTransactions.GetAllAsync(filter: x => bills.Select(x => x.Id).Contains(x.Bill_Id) /*&& bills.Select(x => x.PayDate).Contains(x.Bill.PayDate)*/&& (x.BillPayment.Employee_Id == model.FirstOrDefault()!.Employee_Id), includeProperties: "Bill,BillPayment")).Select(x => x.Bill_Id).ToList();
                string RefusedBillsIdsMessage = string.Join(",", RefusedBills.ToArray());

                //if (await _unitOfWork.Bills.AnyAsync(x => Value.any))
                //{
                //    _customLog.LogExceptionInDb(new Exception() { }, objJson: JsonConvert.SerializeObject(model));
                //    return new Response<string>()
                //    {
                //        Data = _sharLocalizer[SDLocalization.BillExist],
                //        Message = _sharLocalizer[SDLocalization.BillExist],
                //        IsSuccess = true,
                //    };
                //}

                //var CheckData = model.Select(x => x.Transactions.Where(t => !RefusedBills.Contains(t.Bill.Id)).ToList());

                //**************************Update Customers Data****************************************

                var CustomerData = model.Select(x => new UpdateCustomerDataRequest() { Customer_Id = x.CustomerData_Id, CustomerName = x.CustomerName, CustomerActivity = x.CustomerActivity, CustomerActivity_fk = 0 }).ToList();

                var searchedCustomerActivities = (await _unitOfWork.CustomerActivities.GetSpecificSelectAsync(filter: x => model.Select(y => y.CustomerActivity).Contains(x.Name), select: x => new SelectIntListResponse() { Id = x.Id, Name = x.Name })).ToList();

                foreach (var CustomerDataItem in CustomerData)
                {

                    var searchedCustomerActivityObject = searchedCustomerActivities.FirstOrDefault(obj => obj.Name == CustomerDataItem.CustomerActivity);

                    CustomerDataItem.Customer_Id = searchedCustomerActivityObject != null ? searchedCustomerActivityObject.Id : 0;

                }

                var CustomerDataList = await _unitOfWork.CustomerData.GetAllAsync(filter: x => CustomerData.Select(y => y.Customer_Id).Contains(x.Id));
                foreach (var CustItem in CustomerDataList)
                {
                    var UpdatedCustomerData = CustomerData.FirstOrDefault(x => x.Customer_Id == CustItem.Id);
                    CustItem.Name = UpdatedCustomerData!.CustomerName;
                    CustItem.Code = UpdatedCustomerData!.CustomerName;
                    CustItem.ActualName = UpdatedCustomerData!.CustomerName;

                    if (UpdatedCustomerData.CustomerActivity_fk == 0)
                    {
                        CustItem.CustomerActivity = new CustCustomerActivity() { Name = CustomerData.FirstOrDefault(a => a.Customer_Id == CustItem.Id)!.CustomerActivity };
                    }
                    else
                    {
                        CustItem.CustomerActivity_Id = UpdatedCustomerData.CustomerActivity_fk;
                    }
                }

                _unitOfWork.CustomerData.UpdateRange(CustomerDataList);
                await _unitOfWork.CompleteAsync();

                foreach (var BillPaymentItem in model)
                {

                    long[]? billsNumbers = BillPaymentItem.Transactions.Select(a => a.Bill.Id).ToArray();
                    BillPaymentItem.Transactions = BillPaymentItem.Transactions.Where(x => !RefusedBills.Contains(x.Bill.Id) && !dublicateBillIds.Contains(x.Bill.Id)).ToList();
                    foreach (var item in billsNumbers)
                    {
                        dublicateBillIds.Remove(item);
                    }
                }
                model = model.Where(a => a.Transactions.Count() > 0).ToList();

                var Data = _mapper.Map<List<BillPayment>>(model);
                if (!Data.All(x => x.Transactions.Count() == 0))
                {

                    await _unitOfWork.BillPayment.AddRangeAsync(Data);
                    if (await _unitOfWork.CompleteAsync() > 1)
                    {
                        foreach (var item in Data)
                        {
                            await _unitOfWork.Bills.PayBill(item.CustomerData_Id, item.Transactions.Select(x => x.Bill.BillNum).ToArray(), item.Transactions.Select(x => x.Bill.Id).ToArray(), item.Transactions.Select(x => x.Bill.BillValue).ToArray(), item.Employee_Id, item.PayDate, item.Id);
                        }

                        if (RefusedBills.Count() > 0)
                        {
                            await _customLog.LogExceptionInDb(new Exception(), "Refused Bills  BillNumbers:" + RefusedBillsIdsMessage);
                        }

                        //Calling Hub To FetchData
                        await _operationsHub.Clients.All.LoadData("Load");
                        await _operationsHub.Clients.All.LoadBills("Load");
                        return new Response<string>()
                        {
                            Data = String.Format(_sharLocalizer[SDLocalization.IsExist], RefusedBillsIdsMessage),
                            IsSuccess = true,
                            Message = String.Format(_sharLocalizer[SDLocalization.Done]),
                        };
                    }
                }
                if (RefusedBills.Count() > 0)
                {
                    await _customLog.LogExceptionInDb(new Exception(), "Refused Bills  BillNumbers:" + RefusedBillsIdsMessage);
                }


                return new Response<string>()
                {
                    IsSuccess = true,
                    Data = "Refused Bills  BillNumbers:" + RefusedBillsIdsMessage,
                    Message = _sharLocalizer[SDLocalization.Error],
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(model), LogType.Bug);
                return new Response<string>()
                {
                    Data = _sharLocalizer[SDLocalization.Error],
                    Message = ex.Message + (ex.InnerException == null ? "" : ex.InnerException.Message),
                    Errors = new[] { ex.Message }
                };
            }
        }

        public async Task<Response<BillPaymentResponse>> ChangeIsReprint(int billPaymentId, string userId)
        {
            try
            {
                var searhcedBillPayment = await _unitOfWork.BillPayment.GetFirstOrDefaultAsync(filter: x => x.Id == billPaymentId, includeProperties: "Transactions,Transactions.Bill,Transactions.Bill.BillIssue,CustomerData,CustomerData.Block,CustomerData.Block.Area,CustomerData.Block.Area.Branch,Employee");
                if (searhcedBillPayment == null)
                {
                    return new Response<BillPaymentResponse>()
                    {
                        Message = _sharLocalizer[SDLocalization.CannotBeFound, billPaymentId],
                        IsSuccess = false
                    };
                }
                searhcedBillPayment.IsRePrint = !searhcedBillPayment.IsRePrint;
                _unitOfWork.BillPayment.Update(searhcedBillPayment);

                var PrintLog = new BillPrintLog() { BillPayment_Id = billPaymentId, LogDate = DateTime.UtcNow.AddHours(2), Disc = searhcedBillPayment.IsRePrint ? Messages.Open : Messages.Close, UserId = userId };
                await _unitOfWork.PrintLog.AddAsync(PrintLog);

                await _unitOfWork.CompleteAsync();

                return new Response<BillPaymentResponse>()
                {
                    Message = searhcedBillPayment.IsRePrint ? _sharLocalizer[SDLocalization.Activated] : _sharLocalizer[SDLocalization.DeActivated],
                    IsSuccess = true,
                    Data = _mapper.Map<BillPaymentResponse>(searhcedBillPayment)
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, "");
                return new Response<BillPaymentResponse>()
                {
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] { ex.Message },
                    IsSuccess = false,
                    Data = new BillPaymentResponse()
                };
            }
        }

        public async Task<Response<List<BillPaymentLogResponse>>> GetBillPaymentLogs(long EmployeeId)
        {
            try
            {
                var data = (await _unitOfWork.PayDataLog.GetSpecificSelectAsync(filter: x => x.Employee_Id == EmployeeId && !x.IsDeleted, ignoreQueryFilters: true, select: x => new BillPaymentLogResponse() { Customer_Id = x.Customer_Id, CustomerName = x.CustomerData.Name, EmployeeName = x.Employee.Name, Employee_Id = x.Employee_Id, Id = x.Id, PayDate = x.PayDate, PayDataLogDetails = x.PayDataLogDetails.Select(y => new PayDataLogDetailsRequest() { Amount = y.Amount, Bill_Id = y.Bill_Id }).ToList() })).ToList();
                return new Response<List<BillPaymentLogResponse>>() { Data = data, IsSuccess = true, Message = _sharLocalizer[SDLocalization.Data] };
            }
            catch (Exception ex)
            {
                return new Response<List<BillPaymentLogResponse>>() { Data = new List<BillPaymentLogResponse>(), IsSuccess = false, Message = _sharLocalizer[SDLocalization.Error], Errors = new[] { ex.Message } };
            }

        }

        public async Task<Response<List<BillPaymentLogRequest>>> AddPaymentLog(BillPaymentLogRequest[] model)
        {
            try
            {
                var Data = _mapper.Map<List<PayDataLog>>(model);
                var ResData = await _unitOfWork.PayDataLog.AddRangeAsync(Data);
                await _unitOfWork.CompleteAsync();
                return new Response<List<BillPaymentLogRequest>>() { Data = model.ToList(), Message = _sharLocalizer[SDLocalization.Data], IsSuccess = true };
            }
            catch (Exception ex)
            {
                return new Response<List<BillPaymentLogRequest>>() { Data = new List<BillPaymentLogRequest>(), Message = _sharLocalizer[SDLocalization.Error], Errors = new[] { ex.Message }, IsSuccess = false };
            }
        }

        public async Task<Response<MemoryStream>> GetPaymentExcelFile(SearchParametersForBillsDataRequest searchParametersRequest)
        {
            try
            {
                var Billobj = await BillPaymentFilter(searchParametersRequest);
                var stream = new MemoryStream();
                using (var xlPackage = new ExcelPackage(stream))
                {
                    var worksheet = xlPackage.Workbook.Worksheets.Add("Bills");
                    var namedStyle = xlPackage.Workbook.Styles.CreateNamedStyle("HyperLink");
                    namedStyle.Style.Font.UnderLine = true;
                    namedStyle.Style.Font.Color.SetColor(Color.Blue);
                    const int startRow = 5;
                    var row = startRow;

                    worksheet.Cells["A1"].Value = "الرفم التعريفى للعميل";
                    worksheet.Cells["B1"].Value = "كود العميل";
                    worksheet.Cells["C1"].Value = "اسم العميل";
                    worksheet.Cells["D1"].Value = "الرقم التعريفى اللمحصل";
                    worksheet.Cells["E1"].Value = "اسم المحصل";
                    worksheet.Cells["F1"].Value = "مربع";
                    worksheet.Cells["G1"].Value = "المنطقة";
                    worksheet.Cells["H1"].Value = "الفرع";
                    worksheet.Cells["I1"].Value = "الرقم التعريفى لعمليه الدفع";
                    worksheet.Cells["J1"].Value = "القرائة السابقة";
                    worksheet.Cells["K1"].Value = "القرائة الحالية";
                    worksheet.Cells["L1"].Value = "ملاحظات";
                    worksheet.Cells["M1"].Value = "اعادة الطباعة";
                    worksheet.Cells["N1"].Value = "الفاتورة";
                    worksheet.Cells["O1"].Value = "رقم الفاتورة";
                    worksheet.Cells["P1"].Value = "قيمة الفاتورة";
                    worksheet.Cells["Q1"].Value = "اسم إصدار الفاتورة";
                    worksheet.Cells["R1"].Value = "اصدار الفاتورة";
                    worksheet.Cells["S1"].Value = "الخدمة المحتوية";
                    worksheet.Cells["T1"].Value = "تاريخ الدفع";
                    worksheet.Cells["U1"].Value = "العميل";
                    worksheet.Cells["V1"].Value = "تقسيط";
                    worksheet.Cells["W1"].Value = "اعمال صيانة";
                    worksheet.Cells["X1"].Value = "أخر";
                    worksheet.Cells["Y1"].Value = "انتظام الخدمة";
                    worksheet.Cells["Z1"].Value = "الضريبة 14٪";
                    worksheet.Cells["AA1"].Value = "تقسيط مياه الصرف الصحي";
                    worksheet.Cells["AB1"].Value = "تقسيط المياه";
                    worksheet.Cells["AC1"].Value = "قيمة الماء";

                  
                    

                    worksheet.Cells["A1:AC1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    worksheet.Cells["A1:AC1"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(184, 204, 228));
                    worksheet.Cells["A1:AC1"].Style.Font.Bold = true;

                    row = 2;

                    foreach (var billPaymentItem in Billobj.data)
                    {
                        foreach (var BillItem in billPaymentItem.BillTransactions)
                        {
                            worksheet.Cells[row, 1].Value = billPaymentItem.CustomerData_Id;
                            worksheet.Cells[row, 2].Value = billPaymentItem.CustomerCode;
                            worksheet.Cells[row, 3].Value = billPaymentItem.CustomerName; 
                            worksheet.Cells[row, 4].Value = billPaymentItem.Employee_Id;
                            worksheet.Cells[row, 5].Value = billPaymentItem.CollectorName;
                            worksheet.Cells[row, 6].Value = billPaymentItem.Block;
                            worksheet.Cells[row, 7].Value = billPaymentItem.Area;
                            worksheet.Cells[row, 8].Value = billPaymentItem.Branch;
                            worksheet.Cells[row, 9].Value = billPaymentItem.Id;
                            worksheet.Cells[row, 10].Value = BillItem.PrevReading;
                            worksheet.Cells[row, 11].Value = BillItem.CurrentReading;
                            worksheet.Cells[row, 12].Value = billPaymentItem.Notes;
                            worksheet.Cells[row, 13].Value = billPaymentItem.IsRePrint;
                            worksheet.Cells[row, 14].Value = BillItem.Bill_Id;
                            worksheet.Cells[row, 15].Value = BillItem.BillNum;
                            worksheet.Cells[row, 16].Value = BillItem.BillValue;
                            worksheet.Cells[row, 17].Value = BillItem.BillIssueName;
                            worksheet.Cells[row, 18].Value = BillItem.BillIssue_Id;
                            worksheet.Cells[row, 19].Value = BillItem.RegularityService;
                            worksheet.Cells[row, 20].Value = billPaymentItem.PayDate.Day + "/" + billPaymentItem.PayDate.Month + "/" + billPaymentItem.PayDate.Year;
                            worksheet.Cells[row, 21].Value = BillItem.Customer_Id;
                            worksheet.Cells[row, 22].Value = BillItem.Installment;
                            worksheet.Cells[row, 23].Value = BillItem.Maintenance;
                            worksheet.Cells[row, 24].Value = BillItem.Others;
                            worksheet.Cells[row, 25].Value = BillItem.ContenutityService;
                            worksheet.Cells[row, 26].Value = BillItem.Tax14Percent;
                            worksheet.Cells[row, 27].Value = BillItem.WastWaterInstallment;
                            worksheet.Cells[row, 28].Value = BillItem.WaterInstallment;
                            worksheet.Cells[row, 29].Value = BillItem.WaterValue;

                            row++;
                        }
                        
                    }



                    // set some core property values
                    xlPackage.Workbook.Properties.Title = "Bills List";
                    xlPackage.Workbook.Properties.Author = "AlignTech Company Solutions";
                    xlPackage.Workbook.Properties.Subject = "Bills List";
                    // save the new spreadsheet
                    xlPackage.Save();
                    // Response.Clear();
                }

                stream.Position = 0;
                return new Response<MemoryStream>()
                {
                    Data = stream,
                    IsSuccess = true,
                    Message = _sharLocalizer[SDLocalization.Data]
                };
            }
            catch (Exception ex)
            {
                return new Response<MemoryStream>()
                {
                    Data = new MemoryStream(),
                    Errors = new[] {ex.Message},
                    IsSuccess = true,
                    Message = _sharLocalizer[SDLocalization.Data]
                };
            }
        }
        public async Task<Response<MemoryStream>> GetParentPaymentExcelFile(SearchParametersForBillsDataRequest searchParametersRequest)
        {
            try
            {
                var Billobj = await BillPaymentFilter(searchParametersRequest);
                var stream = new MemoryStream();
                using (var xlPackage = new ExcelPackage(stream))
                {
                    var worksheet = xlPackage.Workbook.Worksheets.Add("Bills");
                    var namedStyle = xlPackage.Workbook.Styles.CreateNamedStyle("HyperLink");
                    namedStyle.Style.Font.UnderLine = true;
                    namedStyle.Style.Font.Color.SetColor(Color.Blue);
                    const int startRow = 5;
                    var row = startRow;

                    worksheet.Cells["A1"].Value = "العميل";
                    worksheet.Cells["B1"].Value = "كود العميل";
                    worksheet.Cells["C1"].Value = "الموظف";
                    worksheet.Cells["D1"].Value = "مربع";
                    worksheet.Cells["E1"].Value = "منطقة";
                    worksheet.Cells["F1"].Value = "فرع";
                    worksheet.Cells["G1"].Value = "اسم العميل";
                    worksheet.Cells["H1"].Value = "اسم المحصل";
                    worksheet.Cells["I1"].Value = "Id";
                    worksheet.Cells["J1"].Value = "ملاحظة";
                    worksheet.Cells["K1"].Value = "تاريخ الدفع";
                    worksheet.Cells["L1"].Value = "الكمية الكلية";
                    worksheet.Cells["M1"].Value = "اعادة الطباعة";


                    worksheet.Cells["A1:AG1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    worksheet.Cells["A1:AG1"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(184, 204, 228));
                    worksheet.Cells["A1:AG1"].Style.Font.Bold = true;

                    row = 2;

                    foreach (var billPaymentItem in Billobj.data)
                    {
                        foreach (var BillItem in billPaymentItem.BillTransactions)
                        {
                            worksheet.Cells[row, 1].Value = billPaymentItem.CustomerData_Id;
                            worksheet.Cells[row, 2].Value = billPaymentItem.CustomerCode;
                            worksheet.Cells[row, 3].Value = billPaymentItem.Employee_Id;
                            worksheet.Cells[row, 4].Value = billPaymentItem.Block;
                            worksheet.Cells[row, 5].Value = billPaymentItem.Area;
                            worksheet.Cells[row, 6].Value = billPaymentItem.Branch;
                            worksheet.Cells[row, 7].Value = billPaymentItem.CustomerName;
                            worksheet.Cells[row, 8].Value = billPaymentItem.CollectorName;
                            worksheet.Cells[row, 9].Value = billPaymentItem.Id;
                            worksheet.Cells[row, 10].Value = billPaymentItem.Notes;
                            worksheet.Cells[row, 11].Value = billPaymentItem.PayDate.Day + "/" + billPaymentItem.PayDate.Month + "/" + billPaymentItem.PayDate.Year;
                            worksheet.Cells[row, 12].Value = billPaymentItem.TotalAmount;
                            worksheet.Cells[row, 13].Value = billPaymentItem.IsRePrint;


                            row++;
                        }

                    }



                    // set some core property values
                    xlPackage.Workbook.Properties.Title = "Bills List";
                    xlPackage.Workbook.Properties.Author = "AlignTech Company Solutions";
                    xlPackage.Workbook.Properties.Subject = "Bills List";
                    // save the new spreadsheet
                    xlPackage.Save();
                    // Response.Clear();
                }

                stream.Position = 0;
                return new Response<MemoryStream>()
                {
                    Data = stream,
                    IsSuccess = true,
                    Message = _sharLocalizer[SDLocalization.Data]
                };
            }
            catch (Exception ex)
            {
                return new Response<MemoryStream>()
                {
                    Data = new MemoryStream(),
                    Errors = new[] { ex.Message },
                    IsSuccess = true,
                    Message = _sharLocalizer[SDLocalization.Data]
                };
            }
        }
        public async Task<Response<string>> AddPaymentsSafe(BillPaymentSafeRequest model)
        {
            try
            {
                var billPaymentSafe = await _unitOfWork.BillPaymentSafe.AddAsync(new BillPaymentSafe
                {
                    BillSafe_Id = model.SafeId,
                    HrEmployee_Id = model.EmployeeId,
                    CreatedDate = DateTime.Now,
                    IsPosted = false,
                    TotalAmount = model.Total
                });

                if (await _unitOfWork.CompleteAsync() > 0)
                {
                    var billPayments = _unitOfWork.BillPayment.GetAllAsync(filter: f => model.paymentIds.Any(an => an == f.Id)).Result.ToList();
                    billPayments.ForEach(item => item.BillPaymentSafe_Id = billPaymentSafe.Id);
                    _unitOfWork.BillPayment.UpdateRange(billPayments);
                    await _unitOfWork.CompleteAsync();
                    return new Response<string>
                    {
                        Data = _sharLocalizer[SDLocalization.SavedSaccefully],
                        IsSuccess = true,
                        Message = _sharLocalizer[SDLocalization.SavedSaccefully]
                    };
                }
                else
                    throw new Exception("billPaymentSafe Not Safed");
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(model));
                return new Response<string>()
                {
                    Data = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] { ex.Message },
                    IsSuccess = true,
                    Message = _sharLocalizer[SDLocalization.Error]
                };
            }
        }

        public async Task<Response<GetBillPaymentSafesResponse>> GetPaymentSafes(SearchParametersForBillPaymentSafesDataRequest model)
        {
            try
            {
                var data = await _unitOfWork.BillPaymentSafe.GetSpecificSelectAsync(
                    filter: f => f.IsPosted == false
                             && (model.SafeId == null || model.SafeId == f.BillSafe_Id)
                             && (!model.PaymentSafeDate.HasValue || f.CreatedDate.Date == model.PaymentSafeDate.Value.Date),
                    skip: (model.PageNumber - 1) * model.PageSize,
                    take: model.PageSize,
                    includeProperties: "BillSafe,HrEmployee",
                    select: s => new BillPaymentSafesData
                    {
                        PaymentSafeId = s.Id,
                        SafeName = s.BillSafe.Name,
                        CreatedDate = s.CreatedDate,
                        EmployeeName = s.HrEmployee.Name,
                        TotalAmount = s.TotalAmount
                    });
                return new Response<GetBillPaymentSafesResponse>()
                {
                    Data = new GetBillPaymentSafesResponse
                    {
                        Data = data,
                        TotalRecords = data.Count()
                    },
                    IsSuccess = true,
                    Message = _sharLocalizer[SDLocalization.Data]
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(model));
                return new Response<GetBillPaymentSafesResponse>()
                {
                    Data = new GetBillPaymentSafesResponse(),
                    IsSuccess = false,
                    Message = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] { ex.Message }
                };
            }
        }

        public async Task<Response<string>> ChangeIsPosted(BillChangeIsPostedRequest model)
        {
            try
            {
                var billPayments = _unitOfWork.BillPaymentSafe.GetAllAsync(filter: f => model.paymentIds.Any(an => an == f.Id)).Result.ToList();
                billPayments.ForEach(item => item.IsPosted = true);
                _unitOfWork.BillPaymentSafe.UpdateRange(billPayments);
                await _unitOfWork.CompleteAsync();
                return new Response<string>
                {
                    Data = _sharLocalizer[SDLocalization.SavedSaccefully],
                    IsSuccess = true,
                    Message = _sharLocalizer[SDLocalization.SavedSaccefully]
                };
            }
            catch (Exception ex)
            {
                await _customLog.LogExceptionInDb(ex, JsonConvert.SerializeObject(model));
                return new Response<string>()
                {
                    Data = _sharLocalizer[SDLocalization.Error],
                    Errors = new[] { ex.Message },
                    IsSuccess = true,
                    Message = _sharLocalizer[SDLocalization.Error]
                };
            }
        }
    }
}
