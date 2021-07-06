using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using THL.DAL.Entities;

namespace THL.DAL.Context
{
    public class VaccineContext : DbContext
    {
        public VaccineContext()
        {
            Database.EnsureCreatedAsync();
        }

        public DbSet<Vaccine> Vaccines { get; set; }

        public DbSet<VaccineOrder> VaccineOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=THLVaccinationAppDB;Trusted_Connection=True;");
        }

        public class VaccineOrderConfiguration : IEntityTypeConfiguration<VaccineOrder>
        {
            public void Configure(EntityTypeBuilder<VaccineOrder> builder)
            {
                builder.Property(v => v.JsonFile)
                    .HasJsonValueConversion();
            }
        }

      
    }
}
