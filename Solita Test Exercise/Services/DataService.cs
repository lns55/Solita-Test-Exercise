using System.Linq;
using THL.DAL.Context;

namespace Solita_Test_Exercise.Services
{
    public class DataService
    {
        private readonly VaccineContext _db;

        public DataService(VaccineContext context)
        {
            _db = context;
        }

        internal int TotalVaccinesCame()
        {
            int data = _db.VaccineOrders.Count();

            return data;
        }

        internal int TotalVaccinationsNumber()
        {
            int data = _db.Vaccines.Count();

            return data;
        }
    }
}
