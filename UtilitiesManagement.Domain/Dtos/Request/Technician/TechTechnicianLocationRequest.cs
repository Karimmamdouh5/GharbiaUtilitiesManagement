using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Request.Technician
{
    public class TechTechnicianLocationRequest
    {
        [Required]
        [Display(Name = "TechnicianName")]
        public int Technician_Id { get; set; }
        public decimal X { get; set; }
        public decimal Y { get; set; }

        [Display(Name = "MobileDate")]
        public DateTime? MobileDate { get; set; }
    }
}
