using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Response.Auth
{
    public class PermissionsByCompanyResponse
    {
        public int CompanyId { get; set; }
        public List<CheckBox> RoleCalims { get; set; }
    }
    public class RulesByCompanyResponse
    {
        public int CompanyId { get; set; }
        public List<CheckBox_WithIdString> RulesList { get; set; }
    }
 
    public class ClaimsAnalysis {
        public List<string> newClaims { get; set; }
        public List<string> DeletedClaims { get; set; }
    }
    public class RulesAnalysis
    {
        public List<string> newRules { get; set; }
        public List<string> DeletedRules { get; set; }
    }
    public class RuleCompleteAnalysis
    {
        public List<ApplicationRole> newRules { get; set; }
        public List<ApplicationRole> DeletedRules { get; set; }
    }
    public class CompanyRoleDTO
    {
        public int CompanyId { get; set; }
        public string RoleName { get; set; }
    }
    public class CompanyRoleDTO_2
    {
        public int CompanyId { get; set; }
        public string RoleId { get; set; }
    }
    public class CompanyRoleDTO_Edit
    {
        public string RoleId { get; set; }
        public string RoleNameNew { get; set; }
    }
}
