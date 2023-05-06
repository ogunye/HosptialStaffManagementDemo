using HSMD.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Infrastrucutre.Data.Common
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) :base(options)
        {
            
        }

        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<HospitalAddress> HospitalAddresses { get; set; }
        public DbSet<Staff> Staff { get; set; }
    }
}
