using System.Collections.Generic;
using THL.DAL.Entities;

namespace Solita_Test_Exercise.ViewModels
{
    public class HomeViewModel
    {
        public int TotalOrders { get; set; }

        public int TotalVaccinesCame { get; set; }

        public int TotalVaccinationsNumber { get; set; }

        public List<VaccineOrder> ArrivedInMonth { get; set; }

        public Dictionary<string, int> VaccineProducers { get; set; }

        public int ExpireToday { get; set; }

        public List<VaccineOrder> ExpireTodayList { get; set; }

        public int ExpireSoon { get; set; }

        public List<VaccineOrder> ExpireSoonList { get; set; }
    }
}
