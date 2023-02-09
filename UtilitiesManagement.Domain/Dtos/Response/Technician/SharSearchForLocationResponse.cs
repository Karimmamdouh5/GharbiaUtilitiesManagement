using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Response.Technician
{
    public class SharSearchForLocationResponse
    {
        public long Id { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public bool? Status { get; set; }

    }
}
