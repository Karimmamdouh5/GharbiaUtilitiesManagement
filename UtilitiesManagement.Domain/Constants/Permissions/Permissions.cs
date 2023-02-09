using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  UtilitiesManagement.Domain.Constants.Permissions
{
    public static class Permissions
    {
        public static List<string> GeneratePermissionsList(string moduleParent, string module)
        {
            return new List<string>()
            {
                $"Screen.{moduleParent}.{module}.Full",
                $"Screen.{moduleParent}.{module}.View",
                $"Screen.{moduleParent}.{module}.Create",
                $"Screen.{moduleParent}.{module}.Manage",
            };
        }
        public static List<string> GenerateReportsList(string moduleParent, string module)
        {
            return new List<string>()
            {
                $"Report.{moduleParent}.{module}.View",
            };
        }

        public enum PermissionsModules
        {
            [Display(Name = "Employees", Description = "Employees")]
            HR_Employees,
            [Display(Name = "Technician", Description = "Technician")]
            Technician_Technician,
            [Display(Name = "Customers", Description = "Customers")]
            Customer_Customers,
            //Shared
            [Display(Name = "Company", Description = "Company")]
            Shared_Company,
            [Display(Name = "Geographic", Description = "Geographic")]
            Shared_Geographic,
            ////Operation
            [Display(Name = "Complaints", Description = "Complaints")]
            Operation_Complaints,
            [Display(Name = "MeterReading", Description = "MeterReading")]
            Operation_MeterReading,
            [Display(Name = "CustomersUpdates", Description = "CustomersUpdates")]
            Operation_CustomersUpdates,
            //bills
            [Display(Name = "PaymentBills", Description = "PaymentBills")]
            Bills_PaymentBills,
            [Display(Name = "Issues", Description = "Issues")]
            Bills_Issues,
            //Management
            [Display(Name = "Permission", Description = "Permission")]
            Management_Permission,
            [Display(Name = "AlignPermission", Description = "AlignPermission")]
            Management_AlignPermission,
            [Display(Name = "Users", Description = "Users")]
            Management_Users,
        }
        public enum ReportsModules
        {
            HR_Employees
        }
        public static List<string> GenerateAllPermissions()
        {
 
            var allPermissions = new List<string>();

            var modules = Enum.GetValues(typeof(PermissionsModules));
            foreach (var module in modules)
            {
                var moduleValue = module.ToString().Split('_');
                allPermissions.AddRange(GeneratePermissionsList(moduleParent: moduleValue[0], module: moduleValue[1]));
            }
            modules = Enum.GetValues(typeof(ReportsModules));
            foreach (var module in modules)
            {
                var moduleValue = module.ToString().Split('_');
                allPermissions.AddRange(GenerateReportsList(moduleParent: moduleValue[0], module: moduleValue[1]));
            }
            return allPermissions;
        }

       
        public static class Employees
        {
            public const string All = "Screen.HR.Employees.Full";
            public const string View = "Screen.HR.Employees.View";
            public const string Manage = "Screen.HR.Employees.Manage";
        }
        public static class Technician
        {
            public const string All = "Screen.Technician.Technician.Full";
            public const string View = "Screen.Technician.Technician.View";
            public const string Manage = "Screen.Technician.Technician.Manage";
            public const string Create = "Screen.Technician.Technician.Create";
        }
        public static class Geographic
        {
            public const string All = "Screen.Shared.Geographic.Full";
            public const string View = "Screen.Shared.Geographic.View";
            public const string Manage = "Screen.Shared.Geographic.Manage";
        }
        public static class Company
        {
            public const string All = "Screen.Shared.Company.Full";
            public const string View = "Screen.Shared.Company.View";
            public const string Create = "Screen.Shared.Company.Create";
            public const string Manage = "Screen.Shared.Company.Manage";
        }
        public static class Customer
        {
            public const string All = "Screen.Customer.Customers.Full";
            public const string View = "Screen.Customer.Customers.View";
            public const string Manage = "Screen.Customer.Customers.Manage";
            public const string Create = "Screen.Customer.Customers.Manage";
        }
        public static class Complaints
        {
            public const string All = "Screen.Operation.Complaints.Full";
            public const string View = "Screen.Operation.Complaints.View";
            public const string Create = "Screen.Operation.Complaints.Create";
            public const string Manage = "Screen.Operation.Complaints.Manage";
        }
        public static class MeterReading
        {
            public const string All = "Screen.Operation.MeterReading.Full";
            public const string View = "Screen.Operation.MeterReading.View";
            public const string Create = "Screen.Operation.MeterReading.Create";
            public const string Manage = "Screen.Operation.MeterReading.Manage";
        }
        public static class CustomersUpdates
        {
            public const string All = "Screen.Operation.CustomersUpdates.Full";
            public const string View = "Screen.Operation.CustomersUpdates.View";
            public const string Create = "Screen.Operation.CustomersUpdates.Create";
            public const string Manage = "Screen.Operation.CustomersUpdates.Manage";
        }

        public static class Bills
        {
            public const string All = "Screen.Bills.PaymentBills.Full";
            public const string View = "Screen.Bills.PaymentBills.View";
            public const string Create = "Screen.Bills.PaymentBills.Create";
            public const string Manage = "Screen.Bills.PaymentBills.Manage";
        }
        public static class Issues
        {
            public const string All = "Screen.Bills.Issues.Full";
            public const string View = "Screen.Bills.Issues.View";
            public const string Manage = "Screen.Bills.Issues.Manage";
        }

        public static class Permission
        {
            public const string All = "Screen.Management.Permission.Full";
            public const string View = "Screen.Management.Permission.View"; 
            public const string Create = "Screen.Management.Permission.Create";
            public const string Manage = "Screen.Management.Permission.Manage";
            
        }
        public static class AlignPermission
        {
            public const string All = "Screen.Management.AlignPermission.Full";
            public const string View = "Screen.Management.AlignPermission.View";
            public const string Create = "Screen.Management.AlignPermission.Create";
            public const string Manage = "Screen.Management.AlignPermission.Manage";

        }
        public static class Users
        {
            public const string All = "Screen.Management.Users.Full";
            public const string View = "Screen.Management.Users.View";
            public const string Create = "Screen.Management.Users.Create";
            public const string Manage = "Screen.Management.Users.Manage";

        }
        /***************************** Water ****************************************/
        public static class Employee
        {
            public const string View = "Screen.HR.Employees.View";
            public const string Manage = "Screen.HR.Employees.Manage";
        }
    }
}
