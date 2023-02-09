using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Response.Shared
{
    public class ListOfBlocksResponse: SelectListResponse
    {
        public long AreaId { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
    }
}
