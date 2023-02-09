using UtilitiesManagement.Domain.Models.Align;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  UtilitiesManagement.DataAccess.DataContext
{
    public class AlignDbContext : DbContext
    {

        public AlignDbContext(DbContextOptions<AlignDbContext> options) : base(options)
        {

        }
        public DbSet<AlignCompany> AlignCompanies { get; set; }
        public DbSet<Logging> Logging { get; set; }
    }
}
