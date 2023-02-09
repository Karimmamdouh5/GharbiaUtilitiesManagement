using System.ComponentModel.DataAnnotations;
using UtilitiesManagement.Domain.Dtos.Request.Bill;
using UtilitiesManagement.Domain.Dtos.Response;
using UtilitiesManagement.Services.IServices.Bill;

namespace UtilitiesManagement.Api.Areas.Bills
{
    [Area(Modules.Bill)]
    [ApiController]
    [ApiExplorerSettings(GroupName = Modules.Bill)]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class BillController : ControllerBase
    {
        private readonly IBillService _billService;
        private readonly IBillSafeService _billSafeService;
        public BillController(IBillService BillService, IBillSafeService billSafeService)
        {
            _billService = BillService;
            _billSafeService = billSafeService;
        }
        [HttpGet(ApiRoutes.Bills.GetBillSafes)]
        [Authorize(Permissions.Bills.View)]
        public async Task<IActionResult> GetBillSafes()
        {
            var Data = await _billSafeService.GetAllBillSafesAsync();
            if (!Data.IsSuccess)
            {
                return StatusCode(500, Data);
            }
            return Ok(Data);
        }

        [HttpGet(ApiRoutes.Bills.ReceiveBillsData)]
        [Authorize(Permissions.Bills.Manage)]
        public async Task<IActionResult> ReceiveBillsDataByEmployee(long employeeId,[Required][FromQuery]long[] BlockIds)
        {
            var Data = await _billService.GetBillDataByEmployee(employeeId, BlockIds);
            if (!Data.IsSuccess)
            {
                return StatusCode(500, Data);
            }
            return Ok(Data);
        }
        [HttpPost(ApiRoutes.Bills.PayBill)]
        [Authorize(Permissions.Bills.Create)]
        public async Task<IActionResult> PayBill(List<BillPaymentRequest> model)
        {
            var Data = await _billService.PayBill(model);
            if (!Data.IsSuccess)
            {
                return StatusCode(500, Data);
            }
            return Ok(Data);
        }

    

        [HttpPost(ApiRoutes.Bills.AddBillSafe)]
        [Authorize(Permissions.Bills.Create)]
        public async Task<IActionResult> AddBillSafe(AddListRequest BillSafeAddListRequest)
        {
            var Data = await _billSafeService.AddBillSafeAync(BillSafeAddListRequest);
            if (!Data.IsSuccess)
            {
                return StatusCode(500, Data);
            }
            return Ok(Data);
        }
        [HttpPut(ApiRoutes.Bills.UpdateBillSafe)]
        [Authorize(Permissions.Bills.Manage)]
        public async Task<IActionResult> UpdateBillSafe(int billSafeId, AddListRequest UpdateBillSafeRequest)
        {
            var Data = await _billSafeService.UpdateBillSafeAsync(billSafeId, UpdateBillSafeRequest);
            if (!Data.IsSuccess)
            {
                return StatusCode(500, Data);
            }
            return Ok(Data);
        }
        [HttpDelete(ApiRoutes.Bills.DeleteBillSafe)]
        [Authorize(Permissions.Bills.Manage)]
        public async Task<IActionResult> DeleteBillSafe(int billSafeId)
        {
            var Data = await _billSafeService.DeleteBillSafeAsync(billSafeId);
            if (!Data.IsSuccess)
            {
                return StatusCode(500, Data);
            }
            return Ok(Data);
        }
        [HttpGet(ApiRoutes.Bills.GetPaymentData)]
        [Authorize(Permissions.Bills.View)]
        public async Task<IActionResult> GetPaymentData([FromQuery]SearchParametersForBillsDataRequest model)
        {
            var Data = await _billService.GetPaymentData(model);
            if (!Data.IsSuccess)
            {
                return StatusCode(500, Data);
            }
            return Ok(Data);
        }
        [HttpGet(ApiRoutes.Bills.GetPaymentExcelSheet)]
        [Authorize(Permissions.Bills.View)]
        public async Task<IActionResult> GetPaymentExcelSheet([FromQuery] SearchParametersForBillsDataRequest model)
        {
            var Data = await _billService.GetPaymentExcelFile(model);
            if (!Data.IsSuccess)
            {
                return StatusCode(500, Data);
            }
            return File(Data.Data, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "users.xlsx");

        }
        [HttpGet(ApiRoutes.Bills.GetParentPaymentExcelSheet)]
        [Authorize(Permissions.Bills.View)]
        public async Task<IActionResult> GetParentPaymentExcelSheet([FromQuery] SearchParametersForBillsDataRequest model)
        {
            var Data = await _billService.GetParentPaymentExcelFile(model);
            if (!Data.IsSuccess)
            {
                return StatusCode(500, Data);
            }
            return File(Data.Data, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "users.xlsx");

        }
        [HttpGet(ApiRoutes.Bills.GetEmployeeBills)]
        [Authorize(Permissions.Bills.View)]
        public async Task<IActionResult> GetEmployeeBills(int EmployeeId)
        {
            var Result = await _billService.GetEmployeeBills(EmployeeId);
            if (!Result.IsSuccess)
                return StatusCode(500, Result);
            return Ok(Result);
        }
        [HttpPut(ApiRoutes.Bills.ChangeReprint)]
        [Authorize(Permissions.Bills.Manage)]
        public async Task<IActionResult> ChangeReprint([FromBody]BillChangeReprintRequest model)
        {
            var Result = await _billService.ChangeIsReprint(model.billPaymentId,model.userId);
            if (!Result.IsSuccess)
                return StatusCode(500, Result);
            return Ok(Result);
        }
        [HttpGet(ApiRoutes.Bills.GetPaymentLogs)]
        [Authorize(Permissions.Bills.View)]
        public async Task<IActionResult> GetPaymentData([Required]long EmployeeId)
        {
            var Data = await _billService.GetBillPaymentLogs(EmployeeId);
            if (!Data.IsSuccess)
            {
                return StatusCode(500, Data);
            }
            return Ok(Data);
        }
        [HttpPost(ApiRoutes.Bills.AddPaymentLogs)]
        [Authorize(Permissions.Bills.Create)]
        public async Task<IActionResult> AddPaymentLogs(BillPaymentLogRequest[] model)
        {
            var Data = await _billService.AddPaymentLog(model);
            if (!Data.IsSuccess)
            {
                return StatusCode(500, Data);
            }
            return Ok(Data);
        }
        [HttpPost(ApiRoutes.Bills.AddPaymentsSafe)]
        [Authorize(Permissions.Bills.Create)]
        public async Task<IActionResult> AddPaymentsSafe(BillPaymentSafeRequest model)
        {
            var Data = await _billService.AddPaymentsSafe(model);
            if (!Data.IsSuccess)
            {
                return StatusCode(500, Data);
            }
            return Ok(Data);
        }
        [HttpGet(ApiRoutes.Bills.GetPaymentSafes)]
        [Authorize(Permissions.Bills.View)]
        public async Task<IActionResult> GetPaymentSafes([FromQuery] SearchParametersForBillPaymentSafesDataRequest model)
        {
            var Data = await _billService.GetPaymentSafes(model);
            if (!Data.IsSuccess)
            {
                return StatusCode(500, Data);
            }
            return Ok(Data);
        }
        [HttpPut(ApiRoutes.Bills.ChangeIsPosted)]
        [Authorize(Permissions.Bills.Manage)]
        public async Task<IActionResult> ChangeIsPosted(BillChangeIsPostedRequest model)
        {
            var Data = await _billService.ChangeIsPosted(model);
            if (!Data.IsSuccess)
            {
                return StatusCode(500, Data);
            }
            return Ok(Data);
        }
    }
}
