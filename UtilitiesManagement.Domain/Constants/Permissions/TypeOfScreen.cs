using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  UtilitiesManagement.Domain.Constants.Permissions
{
    public enum TypeOfScreen
    {
        [Display(Name = "Screen", Description = "Screen")]
        Screen,
        [Display(Name = "Report", Description = "Report")]
        Report
    }
}
