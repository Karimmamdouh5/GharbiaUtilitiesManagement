using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesManagement.Domain.Dtos.Response.Bill;
using UtilitiesManagement.Domain.Models.Bill;

namespace UtilitiesManagement.Services.IServices.Bill
{
    public interface IIssueService
    {
        Task<Response<List<BillsIssueResponse>>> ListOfIssues(bool All);
        Task<Response<string>> ManageIssueData();
        Task<Response<List<BillIssueDetailsResponse>>> ListOfIssuessDetails(bool All, long? BranchId, long? IssueId);
    }
}
