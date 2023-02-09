using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesManagement.Domain.Dtos.Response.Auth
{
    public class CompanyConfigurationResponse
    {
        public string CompanyLink { get; set; }
        public int? MobileVersion { get; set; }
        public int? VersionCode { get; set; }
        public string? DownloadUrl { get; set; }
        public DateTime? VersionDate { get; set; }
    }
}
