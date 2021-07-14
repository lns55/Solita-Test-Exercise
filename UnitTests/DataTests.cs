using NUnit.Framework;
using Solita_Test_Exercise.Controllers;
using Solita_Test_Exercise.Services;
using System.Linq;

namespace AppUnitTests
{
    [TestFixture]
    public class Tests
    {
        private DataService dataService;

        [SetUp]
        public void SetUp()
        {
            dataService = new DataService();
        }

        [Test]
        public void Test1()
        {
            //Action
            var totalVaccinations = dataService.TotalVaccinationsNumber();

            //Assert
            Assert.IsNotNull(totalVaccinations);
        }
    }
}