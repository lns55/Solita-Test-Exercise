using System;
using System.ComponentModel.DataAnnotations;

namespace THL.DAL.Entities
{
    public class Vaccine
    {

        [Required]
        public string VaccinationId { get; set; }

        [Required]
        public string SourceBottle { get; set; }

        [Required, StringLength(15)]
        public string Gender { get; set; }

        [Required, DataType(DataType.DateTime)]
        public DateTime VaccinationDate { get; set; }
    }
}
