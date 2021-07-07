using Microsoft.EntityFrameworkCore;
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
            modelBuilder.Entity<VaccineOrder>().HasData(Antiqua());
            modelBuilder.Entity<VaccineOrder>().HasData(SolarBuddhica());
            modelBuilder.Entity<VaccineOrder>().HasData(Zerpfy());
            modelBuilder.Entity<Vaccine>().HasKey(v => new { v.VaccinationId });
            modelBuilder.Entity<Vaccine>().HasData(Vaccinations());
        }

        public List<VaccineOrder> Antiqua()
        {
            var data = new List<VaccineOrder>();

            using (StreamReader reader = new StreamReader(@"../THL.DAL/Data/Antiqua.json"))
            {
                string json = reader.ReadToEnd();
                data = JsonConvert.DeserializeObject<List<VaccineOrder>>(json);

                reader.Close();
            }

            return data;
        }

        public List<VaccineOrder> SolarBuddhica()
        {
            var data = new List<VaccineOrder>();

            using (StreamReader reader = new StreamReader(@"../THL.DAL/Data/SolarBuddhica.json"))
            {
                string json = reader.ReadToEnd();
                data = JsonConvert.DeserializeObject<List<VaccineOrder>>(json);

                reader.Close();
            }

            return data;
        }

        public List<VaccineOrder> Zerpfy()
        {
            var data = new List<VaccineOrder>();

            using (StreamReader reader = new StreamReader(@"../THL.DAL/Data/Zerpfy.json"))
            {
                string json = reader.ReadToEnd();
                data = JsonConvert.DeserializeObject<List<VaccineOrder>>(json);

                reader.Close();
            }

            return data;
        }

        public List<Vaccine> Vaccinations()
        {
            var data = new List<Vaccine>();

            using (StreamReader reader = new StreamReader(@"../THL.DAL/Data/Vaccinations.json"))
            {
                string json = reader.ReadToEnd();
                data = JsonConvert.DeserializeObject<List<Vaccine>>(json);

                reader.Close();
            }

            return data;
        }
    }
}
