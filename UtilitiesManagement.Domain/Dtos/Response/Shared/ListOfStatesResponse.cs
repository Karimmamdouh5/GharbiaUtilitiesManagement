using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Response.Shared
{
    public class ListOfStatesResponse : SelectListResponse
    {
        public int BranchId { get; set; }
    }
}
