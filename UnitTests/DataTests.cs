using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using Solita_Test_Exercise.Controllers;
using Solita_Test_Exercise.Services;

namespace AppUnitTests
{
    [TestFixture]
    public class Tests
    {
        private DataService dataService;

        private HomeController controller;

        [SetUp]
        public void SetUp()
        {
            dataService = new DataService();

            controller = new HomeController();
        }

        [Test]
        public void Test1()
        {
            //Action
            var data = dataService.GetType().GetMethods();

            //Assert
            Assert.IsNotEmpty(data);
        }

        [Test]
        public void Test2()
        {
            //Action 
            var data = controller.GetType().GetMethods();

            //Assert
            Assert.IsNotEmpty(data);
        }
    }
}