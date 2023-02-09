using GharbiaUtilitiesManagement.Domain.Dtos.Response.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Services.IServices.Shared
{
    public interface ICityService
    {
        Task<Response<IEnumerable<ListOfCitiesResponse>>> GetCityAsync(int? StateId, int? employeeId);
    }
}
