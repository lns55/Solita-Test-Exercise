using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THL.DAL.Entities;

namespace THL.DAL.Context
{
    class VaccineContext : DbContext
    {
        public VaccineContext(DbContextOptions<VaccineContext> options)
            : base(options)
        {
            Database.EnsureCreatedAsync();
        }

        public DbSet<Vaccine> Vaccine { get; set; }

        public DbSet<VaccineOrder> VaccineOrder { get; set; }
    }
}
