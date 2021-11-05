using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationsWebApp.Models
{
    public class DonationsDbContext:DbContext
    {
        public DonationsDbContext(DbContextOptions<DonationsDbContext> options) : base(options)
        {

        }

        public DbSet<DCandidate> DCandidates { get; set; }
    }
}
