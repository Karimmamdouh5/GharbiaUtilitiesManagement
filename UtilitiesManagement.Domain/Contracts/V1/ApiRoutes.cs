namespace UtilitiesManagement.Domain.Contracts.V1
{
    public static class ApiRoutes
    {
        public const string Root = "api";

        public const string Version = "v1";

        public const string Base = Root + "/" + Version;


        //*************************Facility*****************************
        public static class Auth
        {
            public const string CheckServer = Base + "/auth/checkServer";
            public const string Login = Base + "/auth/token";
            public const string GetUserData = Base + "/auth/getUserData";
            public const string GetCompanyUsers = Base + "/auth/getCompanyUsers/{CompanyId}";
            public const string ResetUserPassWord = Base + "/auth/resetUserPassWord/{UserId}";
            public const string CompanyLink = Base + "/auth/CompanyLink";
            public const string GetAllUserTypes = Base + "/auth/getAllUserTypes";
            public const string CompanyConfiguration = Base + "/auth/CompanyConfiguration";
            public const string UserRegister = Base + "/auth/userregister";
            public const string Logout = Base + "/auth/logout/{userId}";
            public const string UpdateUserFcmToken = Base + "/auth/UpdateUserFcmToken";
            public const string Register = Base + "/auth/register";
            public const string Refresh = Base + "/auth/refresh";
            public const string ActivateUserOrNot = Base + "/auth/activateuserornot";

           

            public const string UserSetPassword = Base + "/auth/UserSetPassword";

            public const string ReSendEmailVerification = Base + "/auth/ReSendEmailVerification";

            public const string ForgetPassword = Base + "/auth/ForgetPassword";

            public const string ChangePassword = Base + "/auth/ChangePassword";
            public const string GetUserBranches = Base + "/auth/getuserbranches";
            public const string UpdateUser = Base + "/auth/updateuser/{Id}";

            public const string EmployeeLogin = Base + "/auth/EmployeeLogin";

            public const string EmployeeRegister = Base + "/auth/EmployeeRegister";

        }
        public static class Permissions
        {
            public const string addallpermissionToSuperAdmin = Base + "/permissions/addallpermissionToSuperAdmin";
            public const string GetPermissionByRoleAsync = Base + "/permissions/getpermissionbyrole/{roleId}";
            public const string CreateRoleAsync = Base + "/permissions/createrole";
   
            public const string ManageClaimsForRole = Base + "/permissions/managepermissionforrole";
            public const string GetRulesForCompany = Base + "/permissions/getrulesforcompany";
            public const string GetRolesDetailsForCompany = Base + "/permissions/getrolesdetailsforcompany";
            public const string AddRuleToCompany = Base + "/permissions/addruleforcompany";
            public const string EditRuleToCompany = Base + "/permissions/editroleforcompany/{roleId}";
            public const string DeleteRuleToCompany = Base + "/permissions/deleteruleforcompany/{roleId}";

            public const string GetClaimsForCompany = Base + "/permissions/getpermissionforcompanyadmin/{companyId}";
            public const string ManageClaimsForCompany = Base + "/permissions/managepermissionforcompanyadmin";

            public const string ListCompanyRules = Base + "/permissions/listcompanyrules";
            public const string GetUserRolesAsync = Base + "/permissions/getuserroles";
            public const string ManageUserRolesAsync = Base + "/permissions/manageuserroles";
            public const string GetDefaultPermissionsForCompany = Base + "/permissions/getdefaultpermissionsforcompany/{companyId}";
            public const string AddPermissionMenuItem = Base + "/permissions/addpermissionmenuitem";
            public const string RemovePermissionMenuItem = Base + "/permissions/removepermissionmenuitem/{Id}";
            public const string UpdatePermissionMenuItem = Base + "/permissions/updatepermissionmenuitem";
            public const string GetMenu = Base + "/permissions/getmenu";
            public const string GetAdminMenu = Base + "/permissions/getadminmenu";
            public const string GetMenuPermissions = Base + "/permissions/getmenupermissions";
            public const string ChangeNodeActivation = Base + "/permissions/changenodeactivation";

        }
        public static class Companies
        {
            public const string GetAllCompanies = Base + "/shared/getCompanies";
            public const string ListOfCompanies = Base + "/shared/listofcompanies";
            public const string CreateCompany = Base + "/shared/addCompany";
            public const string UpdateCompany = Base + "/shared/updateCompany/{companyId}";
            public const string DeleteCompany = Base + "/shared/deleteCompany/{companyId}";
            public const string GetCompanyProfile = Base + "/shared/getcompanyprofile/{companyId}";
            public const string ChangeLogoPrint = Base + "/shared/ChangeLogoPrint";
            public const string ChangeLogoWeb = Base + "/shared/ChangeLogoWeb";
            public const string ActiveOrNot = Base + "/shared/ActiveOrNot/{companyId}";
            public const string UploadImages = Base + "/images";

        }

        public static class Branches
        {
            public const string GetAllBranchesByCompanyId = Base + "/shared/getbranches/{companyId}";
            public const string GetBranches = Base + "/shared/getbranches";
            public const string ManageBranches = Base + "/shared/managebranches";
            public const string CreateBranch = Base + "/shared/addbranch";
            public const string UpdateBranch = Base + "/shared/updatebranch/{BranchId}";
            public const string GetBranchProfile = Base + "/shared/getbranchprofile/{BranchId}";
            public const string SetActivateOrDeactivateToUsersLoginForCompanyBranch = Base + "/shared/locktechnicianslogin/{BranchId}";
            public const string ChangeActiveOrNot = Base + "/shared/changebranchactiveornot/{BranchId}";
        }
        public static class Employees
        {
            public const string GetAllEmployees = Base + "/hr/getemployees/{companyId?}";
            public const string GetEmployeesData = Base + "/hr/getemployeesdata";
            public const string ListOfEmployees = Base + "/hr/listofemployees";
            public const string ListOfUsersEmployees = Base + "/hr/listofusersemployees";
            public const string ManageRemoteEmployeesData = Base + "/hr/manageremoteemployeesdata";
            public const string CreateEmployee = Base + "/hr/createemployee";
            public const string EditEmployee = Base + "/hr/editemployee/{employeeId}";
            public const string ChangeImage = Base + "/hr/changeimage";
            public const string ChangeActiveOrNot = Base + "/hr/changeactiveornot";
            public const string GetEmployeeProfileInfo = Base + "/hr/getemployeeprofileinfo";
            public const string GetEmployeeProfile = Base + "/hr/getemployeeprofile";
            public const string ListOfMartialStatus = Base + "/hr/listofmartialstatus";
            public const string ListOfMilitaryStatus = Base + "/hr/listofmilitarystatus";
            public const string ListofHrStatus = Base + "/hr/listofhrstatus";
            public const string ListStates = Base + "/hr/liststates";
            public const string ListAllEmployeesWithFilter = Base + "/hr/listofallemployeeswithfilter";
            public const string AddLocation = Base + "/locations";
            public const string GetLocationStatus = Base + "/locations/status";

        }
        public static class States
        {
            public const string GetAllStates = Base + "/shared/getstates";
            public const string ListOfStates = Base + "/shared/listofstates";
            public const string CreateState = Base + "/shared/addstate";
            public const string UpdateState = Base + "/shared/updatestate/{stateId}";
            public const string DeleteState = Base + "/shared/deletestate/{stateId}";
            public const string ChangeActiveOrNot = Base + "/shared/changstateactiveornot/{stateId}";
        }

        public static class Regions
        {
            
            public const string GetAllRegionsByStateId = Base + "/shared/getallregionsbystateId";
            public const string ListOfRegions = Base + "/shared/listofregions";
            public const string CreateRegions = Base + "/shared/addregion";
            public const string UpdateRegions = Base + "/shared/updateregion/{regionId}";
            public const string DeleteRegions = Base + "/shared/deleteregion/{regionId}";
            public const string ChangeActiveOrNot = Base + "/shared/changeregionactiveornot/{regionId}";
        }

        public static class TaxOffices
        {
            public const string GetAllTaxOffices = Base + "/shared/gettaxoffices";
            public const string CreateTaxOffice = Base + "/shared/addtaxoffice";
            public const string UpdateTaxOffice = Base + "/shared/updatetaxoffice/{taxofficeId}";
            public const string DeleteTaxOffice = Base + "/shared/deletetaxoffice/{taxofficeId}";
            public const string ChangeActiveOrNot = Base + "/shared/changetaxofficeactiveornot/{taxofficeId}";
        }

        public static class FinancialYears
        {
            public const string GetAllFinancialYears = Base + "/shared/getfinancialyears/{companyId}";
            public const string GetActiveFinancialYear = Base + "/shared/getactivefinancialyear/{companyId}";
            public const string CreateFinancialYear = Base + "/shared/addfinancialyear";
            public const string ChangeActiveOrNot = Base + "/shared/changefinancialyearactiveornot";
        }

        public static class BillsBooks
        {
            public const string ListOfBillsTypes = Base + "/bill/listofbillstypes";
            public const string GetAllBillsBooks = Base + "/bill/getbillsbooks/{companyId}";
            public const string GetAllBillsBooksBySpecificFilteration = Base + "/bill/getbillsbooksbyfilteration";
            public const string CreateBillsBook = Base + "/bill/createbillsbook";
            public const string DeleteBillsBook = Base + "/bill/deletebillsbook/{billsbookId}";
        }

        public static class Users
        {
            public const string GetUserLogs = Base + "/auth/getuserlogs";
            
            public const string GetUsers = Base + "/auth/getusers";
            public const string GetNumOfOnlineUsers = Base + "/auth/getnumofonlineusers";
            public const string GetListOfUsers = Base + "/auth/getlistofusers/{companyId}";
            public const string LogoutUser = Base + "/auth/logoutuser/{userId}/{jobId}";
        }

        public static class Departments
        {
            public const string GetAllDepartments = Base + "/hr/getdepartments/{companyId}";
            public const string CreateDepartment= Base + "/hr/adddepartment";
            public const string UpdateDepartment = Base + "/hr/updatedepartment/{departmentId}";
            public const string DeleteDepartment = Base + "/hr/deletedepartment/{departmentId}";
            public const string ChangeActiveOrNot = Base + "/hr/changedepartmentactiveornot/{departmentId}";
            public const string ListOfDepartments = Base + "/hr/listofdepartments";
        }

        public static class Sections
        {
            public const string GetAllSectionsBydDepartmentId = Base + "/hr/getSections/{departmentId}";
            public const string ListOfSections = Base + "/hr/listOfSections";
            public const string CreateSection = Base + "/hr/addSection";
            public const string UpdateSection = Base + "/hr/updateSection/{sectionId}";
            public const string DeleteSection = Base + "/hr/deleteSection/{sectionId}";
            public const string ChangeActiveOrNot = Base + "/hr/changesectionactiveornot/{sectionId}";
        }

        public static class Jobs //
        {
            public const string GetAllJobs = Base + "/hr/getjobs/{companyId}";
            public const string ManageJobSection = Base + "/hr/manageJobSection";
            public const string ListOfJobs = Base + "/hr/listofjobs";
            public const string ListOfJobsPerSection = Base + "/hr/listofjobspersection";
            public const string CreateJob = Base + "/hr/addjob";
            public const string UpdateJob = Base + "/hr/updatejob/{jobId}";
            public const string DeleteJob = Base + "/hr/deletejob/{jobId}";
            public const string ChangeActiveOrNot = Base + "/hr/changejobsactiveornot/{jobId}";
            public const string GetJobsPerSection = Base + "/hr/getjobspersection/{sectionId}";

        }

        public static class Technicians
        {
            public const string GetAllLocationsForTechnician = Base + "/tech/getlocations";
            public const string getTechnicianLogs = Base + "/tech/gettechnicianlogs";
            public const string GetLastLocationForUser = Base + "/tech/getlastlocationforuser";
            public const string AddLocationsForTechnician = Base + "/tech/addlocations";
            public const string AddNewTechnicianLog = Base + "/tech/addtechnicianlog";
            public const string GetLastRecordTechnician = Base + "/tech/getlastrecordtechnician";
            public const string StopTechnician = Base + "/tech/stoptechnician";

        }

        //*************************Customer*****************************

        public static class ClientCategory
        {
            public const string GetAllClientCategory = Base + "/cust/getclientcategory";
            public const string CreateClientCategory = Base + "/cust/addclientcategory";
            public const string UpdateClientCategory = Base + "/cust/updateclientcategory/{jobId}";
            public const string DeleteClientCategory = Base + "/cust/deletecientcategory/{jobId}";
        }

        public static class ClientData 
        {
            public const string GetAllClientsData = Base + "/cust/getclientsdata/{companyBranchId}";
            public const string GetAllClientsDataBySpecificFilteration = Base + "/cust/getclientsdatabyfilteration";
            public const string CreateClientDataAndBranch = Base + "/cust/addclientdataandbranch";
            public const string UpdateClientData = Base + "/cust/updateclientdata/{clientDataId}";
            public const string ChangeActiveOrNot = Base + "/cust/changeclientdataactiveornot/{clientDataId}";
        }

        public static class ClientBranches
        {
            public const string GetAllClientBranches = Base + "/cust/getclientbranches/{clientDataId}";
            public const string GetClientBranchLocation = Base + "/cust/clientbranchlocation/{clientBranchId}"; 
            public const string GetSelectedDaysForClientBranch = Base + "/cust/getselectedclientbranchdays/{clientBranchId}";
            public const string CreateClientBranch = Base + "/cust/addclientbranch";
            public const string CreateClientBranchDays = Base + "/cust/createclientbranchdays";
            public const string UpdateClientBranch = Base + "/cust/updateclientbranch/{clientBranchId}";
            public const string ChangeActiveOrNot = Base + "/cust/changeclientbranchactiveornot/{clientBranchId}";
            public const string ChangeClientBranchImage = Base + "/cust/changeclientbranchimage";
        }
        /**************************Water => meterReadings***********************************/
        public static class MeterReadings
        {
            public const string GetAllMeterReadings = Base + "/operation/getmeterreadings";
            public const string CreateMeterReading = Base + "/operation/addmeterreading";
            public const string UpdateMeterReading = Base + "/operation/updatemeterreading";
            public const string UploadMeterReadingImage = Base + "/operation/uploadmeterreadingimage";
            public const string ListOfMeterReadingStatus = Base + "/operation/listofmeterreadingtatus";
            public const string UpdateMeterReadingValue = Base + "/operation/updatemeterreadingvalue";

        }

        public static class Complaints
        {
            public const string GetAllComplaints = Base + "/operation/getcomplaints";
            public const string CreateComplaint = Base + "/operation/addcomplaint";
            public const string UpdateComplaint = Base + "/operation/updatecomplaint";
            public const string UploadComplaintImages = Base + "/operation/uploadcomplaintimages";
        }

        public static class ComplaintTypes
        {
            public const string GetAllComplaintTypes = Base + "/operation/getcomplainttypes";
            public const string CreateComplaintType = Base + "/operation/addcomplainttype";
            public const string UpdateComplaintType = Base + "/operation/updatecomplainttype/{complaintTypeId}";
            public const string DeleteComplaintType = Base + "/operation/deletecomplainttype/{complaintTypeId}";
            public const string ListOfComplaintType = Base + "/operation/listofcomplainttype";
        }

        public static class CustomerData
        {
            public const string GetAllCustomerData = Base + "/cust/getcustomerdata"; 
            public const string GetAllCustomerDataByCollector = Base + "/cust/getcustomerdatabycollector/{collectorId}";
            public const string GetCustomerDataProfile = Base + "/cust/getcustomerdataprofile";
            public const string ListOfCustomer = Base + "/cust/listofcustomer";
            public const string ListOfCustomerByCollector = Base + "/cust/listofcustomerbycollector/{collectorId}";
            public const string ManageRemoteCustomers = Base + "/cust/manageremotecustomers";
            public const string ChangeActiveOrNot = Base + "/cust/changecompleteddataactiveornot/{customerDataId}";
            public const string ListOfCustomerActivities = Base + "/cust/listofcustomeractivities";


        }

        public static class UpdatedCustomers
        {
            public const string GetAllUpdatedCustomers = Base + "/operation/getupdatedcustomers";
            public const string CreateUpdatedCustomer = Base + "/operation/addupdatedcustomer";
            public const string UpdateEditingCustomer = Base + "/operation/updateeditingcustomer";
            public const string UploadUpdatedCustomerImages = Base + "/operation/uploadupdatedcustomerimages";
            public const string ListOfUpdatedCustomerTypes = Base + "/operation/listofupdatedcustomertypes";
        }

        public static class Geographic
        {
            public const string LoadAllGeoData = Base + "/shared/loadallgeodata";
            public const string LoadAllBillTemp = Base + "/shared/loadallbilltemp";
            public const string ListOfBranches = Base + "/shared/listofbranches";
            public const string ManageData = Base + "/shared/Managedata";
            public const string ListOfAreas = Base + "/shared/listofareas";
            public const string ListOfStates = Base + "/shared/listofstates";
            public const string ListOfCities = Base + "/shared/listofcities";
            public const string ListOfBlocks = Base + "/shared/listofblocks";
            public const string GetBlocksByEmployeeAsync = Base + "/shared/getblocksbyemployeeasync/{EmployeeId}";
        }
        public static class Bills
        {
            public const string GetBillSafes = Base + "/bill/getbillsafes";
            public const string AddBillSafe = Base + "/bill/addbillsafe";
            public const string UpdateBillSafe = Base + "/bill/updatebillsafe/{billSafeId}";
            public const string DeleteBillSafe = Base + "/bill/deletebillsafe/{billSafeId}";
            public const string AddPaymentsSafe = Base + "/bill/AddPaymentsSafe";
            public const string GetPaymentSafes = Base + "/bill/GetPaymentSafes";
            public const string ChangeIsPosted = Base + "/bill/ChangeIsPosted";

            public const string GetIssues = Base + "/shared/getissues/{all}";
            public const string GetIssuesDetails = Base + "/shared/getissuesdetails/{all}";
            public const string ManageIssue = Base + "/shared/manageissue";
            public const string ReceiveBillsData = Base + "/shared/receivebillsdata/{employeeId}";
            public const string PayBill = Base + "/shared/paybill";
            public const string GetPaymentData = Base + "/shared/getpaymentdata";
            public const string GetPaymentExcelSheet = Base + "/shared/getpaymentexcelsheet";
            public const string GetParentPaymentExcelSheet = Base + "/shared/getparentpaymentexcelsheet";
            public const string GetTopTwelveIssues = Base + "/bill/gettoptwelveissues/{companyId}";
            public const string GetEmployeeBills = Base + "/bill/getemployeebills/{EmployeeId}";
            public const string ChangeReprint = Base + "/bill/changereprint";
            public const string GetPaymentLogs = Base + "/bill/getpaymentlogs";
            public const string AddPaymentLogs = Base + "/bill/addpaymentlogs";
        }
        public static class Shared
        {
            public const string GetTotalDailyStatistics = Base + "/shared/getdailystatistics";
            public const string GetTotalDailyStatisticsPerEmployee = Base + "/shared/getdailystatisticsperemployee";
            public const string GetTotalDailyStatisticsForEmployee = Base + "/shared/getdailystatisticsforspecificemployee";
        }
        public static class DashBoard
        {
            public const string GetURLs = Base + "/dashboard/geturls";
            public const string GetBillsStatistics = Base + "/dashboard/GetBillsStatistics";
            public const string TotalMonthlyStatisticsForEmployee = Base + "/dashboard/totalmonthlystatisticsforemployee";
            public const string TotalDailyStatisticsForEmployee = Base + "/dashboard/totaldailystatisticsforemployee";
        }

        public static class Notification
        {
            public const string GetAllFcmConf = Base + "/notification/getallfcmconf";
            public const string AddFcmConf = Base + "/notification/addfcmconf";
            public const string UpdateFcmConf = Base + "/notification/updatefcmconf";
            public const string DeleteFcmConf = Base + "/notification/deletefcmconf";

            public const string GetNotiModuleProfile = Base + "/notification/getnotimoduleProfile";
            public const string GetAllNotiMoudles = Base + "/notification/getallnotimoudles";
            public const string AddNotiMoudle = Base + "/notification/addnoticmoudles";
            public const string UpdateNotiMoudle = Base + "/notification/updatenotimoudles";
            public const string DeleteNotiMoudle = Base + "/notification/deletenotimoudles";

            public const string GetModuleMessages = Base + "/notification/getmodulemessages";
            public const string GetUsersMessages = Base + "/notification/getusermessages";
            public const string SendMessage = Base + "/notification/sendmessage";
        }
    }
}
