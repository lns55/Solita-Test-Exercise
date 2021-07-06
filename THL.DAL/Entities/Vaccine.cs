using System;
using System.ComponentModel.DataAnnotations;

namespace THL.DAL.Entities
{
    class Vaccine
    {
        [Required]
        public string Id { get; set; }

        [Required]
        public string SourceBottle { get; set; }

        [Required, StringLength(15)]
        public string Gender { get; set; }

        [Required, DataType(DataType.DateTime)]
        public DateTime VaccinationDate { get; set; }
    }
}
