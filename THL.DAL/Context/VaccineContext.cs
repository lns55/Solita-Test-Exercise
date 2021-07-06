using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using THL.DAL.Entities;

namespace THL.DAL.Context
{
    public class VaccineContext : DbContext
    {
        public VaccineContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Vaccine> Vaccines { get; set; }

        public DbSet<VaccineOrder> VaccineOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=THLVaccinationAppDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VaccineOrder>().HasData(vaccineOrdersData());
        }

        public List<VaccineOrder> vaccineOrdersData()
        {
            var data = new List<VaccineOrder>();

            using (StreamReader r = new StreamReader(@"../THL.DAL/Data/Antiqua.json"))
            {
                string json = r.ReadToEnd();
                data = JsonConvert.DeserializeObject<List<VaccineOrder>>(json);

                r.Close();
            } 
            
            return data;
        }

      
    }
}
