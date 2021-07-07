using System;
using System.ComponentModel.DataAnnotations;

namespace Solita_Test_Exercise.Models
{
    public class VaccinationsModel
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
