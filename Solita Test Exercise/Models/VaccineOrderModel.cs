using System;
using System.ComponentModel.DataAnnotations;

namespace Solita_Test_Exercise.Models
{
    public class VaccineOrderModel
    {
        [Required]
        public string Id { get; set; }

        [Required, Range(1, 10000)]
        public int OrderNumber { get; set; }

        [Required, StringLength(30)]
        public string ResponsiblePerson { get; set; }

        [Required, StringLength(10)]
        public string HealthCareDistrict { get; set; }

        [Required, StringLength(20)]
        public string Vaccine { get; set; }

        [Required, Range(1, 20)]
        public int Injections { get; set; }

        [Required, DataType(DataType.DateTime)]
        public DateTime Arrived { get; set; }
    }
}
