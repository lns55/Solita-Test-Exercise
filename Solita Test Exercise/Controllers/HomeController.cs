using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Solita_Test_Exercise.Models;
using Solita_Test_Exercise.Services;
using Solita_Test_Exercise.ViewModels;
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
            var viewModel = new HomeViewModel();

            viewModel.TotalVaccinesCame = _dataService.TotalVaccinesCame();

            viewModel.TotalVaccinationsNumber = _dataService.TotalVaccinationsNumber();

            viewModel.ArrivedInMonth = _dataService.ArrivedInMonth();

            return View(viewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
