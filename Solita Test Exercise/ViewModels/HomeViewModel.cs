using System.Collections.Generic;
using THL.DAL.Entities;

namespace Solita_Test_Exercise.ViewModels
{
    public class HomeViewModel
    {
        public int TotalVaccinesCame { get; set; }

        public int TotalVaccinationsNumber { get; set; }

        public List<VaccineOrder> ArrivedInMonth { get; set; }
    }
}
