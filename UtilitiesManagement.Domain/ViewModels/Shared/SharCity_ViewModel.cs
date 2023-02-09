using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.ViewModels.Shared
{
    public class SharCity_ViewModel
    {
        public long CityId { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }
        public long StateID { get; set; }
        public bool CityIsUpdated { get; set; }
    }
}
