using System.Collections.Generic;
using System.Linq;
using THL.DAL.Context;
using THL.DAL.Entities;

namespace Solita_Test_Exercise.Services
{
    public class DataService
    {
        private readonly VaccineContext _db;

        public DataService(VaccineContext context)
        {
            _db = context;
        }

        internal List<Vaccine> Count()
        {
            var data = _db.Vaccines.ToList();

            return data;
        }
    }
}
