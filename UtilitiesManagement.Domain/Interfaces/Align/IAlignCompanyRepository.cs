
using UtilitiesManagement.Domain.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace  UtilitiesManagement.Domain.Interfaces.Align
{
    public interface IAlignCompanyRepository //: IBaseRepository<AlignCompany>
    {
        Task<bool> Add(AlignCompany model);

        Task<bool> ExistAsync(Expression<Func<AlignCompany, bool>> filter = null);
        Task<Response<string>> ActiveOrDeActiveCompanyAsync(int id);
        Task<Response<string>> ActiveOrDeActiveCompanyAsync(string code, bool status);
        Task<Response<CompanyConfigurationResponse>> GetCompanyLinkAndVersionAsync(string code);
        //Task<Response<List<AlignCompanyViewModel>>> GetCompaniesAsync();
        //Task<Response<string>> UpdateCompanyAsync(List<AlignCompanyViewModel> request);
    }
}
