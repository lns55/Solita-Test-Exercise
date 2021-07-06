using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel.DataAnnotations;

namespace THL.DAL.Entities
{
    public class VaccineOrder
    {
        [Required]
        public string Id { get; set; }

        [Required, Range(1, 10000)]
        public int OrderNnumber { get; set; }

        [Required, StringLength(20)]
        public string ResponsiblePerson { get; set; }

        [Required, StringLength(5)]
        public string HeatlhCareDistrict { get; set; }

        [Required, StringLength(15)]
        public string Vaccine { get; set; }

        [Required, Range(1,10)]
        public int Injections { get; set; }

        [Required, DataType(DataType.DateTime)]
        public DateTime Arrived { get; set; }

        public JObject JsonFile { get; set; }
    }
}
