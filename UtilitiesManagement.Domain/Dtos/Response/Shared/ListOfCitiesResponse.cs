using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GharbiaUtilitiesManagement.Domain.Dtos.Response.Shared
{
    public class ListOfCitiesResponse : SelectListResponse
    {
        public int StateId { get; set; }
    }
}
