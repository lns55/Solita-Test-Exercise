using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Solita_Test_Exercise.Models;
using Solita_Test_Exercise.Services;
using System.Diagnostics;

namespace Solita_Test_Exercise.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly DataService _dataService;

        public HomeController(ILogger<HomeController> logger, DataService dataService)
        {
            _logger = logger;
            _dataService = dataService;
        }

        public IActionResult Index()
        {
            var allVaccines = _dataService.Count();

            return View(allVaccines);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
