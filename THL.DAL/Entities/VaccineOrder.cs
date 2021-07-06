using System;

namespace THL.DAL.Entities
{
    class VaccineOrder
    {
        public string Id { get; set; }

        public int OrderNnumber { get; set; }

        public string ResponsiblePerson { get; set; }

        public string HeatlhCareDistrict { get; set; }

        public string Vaccine { get; set; }

        public int Injections { get; set; }

        public DateTime Arrived { get; set; }
    }
}
