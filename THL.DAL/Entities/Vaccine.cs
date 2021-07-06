using System;

namespace THL.DAL.Entities
{
    class Vaccine
    {
        public string Id { get; set; }

        public string SourceBottle { get; set; }

        public string Gender { get; set; }

        public DateTime VaccinationDate { get; set; }
    }
}
