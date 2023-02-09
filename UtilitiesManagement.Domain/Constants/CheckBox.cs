using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  UtilitiesManagement.Domain.Constants
{
    public class CheckBox
    {
        public int Id { get; set; }
        public string DisplayValue { get; set; }
        public bool IsSelected { get; set; }
    }
    public class CheckBox_WithIdString
    {
        public string Id { get; set; }
        public string DisplayValue { get; set; }
        public bool IsSelected { get; set; }
    }
    public class CheckBox_WithoutIsSelected
    {
        public string Id { get; set; }
        public string DisplayValue { get; set; }
    }
}
