using Microsoft.AspNetCore.Mvc;
using MVCPortal.Data;
using MVCPortal.Models;
using System.Diagnostics;

namespace MVCPortal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly ISQLDataAccess _dataAccess;
        private readonly IPatientData _data;

        public HomeController(ILogger<HomeController> logger, IPatientData data)//, ISQLDataAccess dataAccess)
        {
            _logger = logger;
            //_dataAccess = dataAccess;
            _data = data;
        }

        public async Task<IActionResult> Index()
        {
            //var test = await _dataAccess.GetPatient(1);
            var test = await _data.GetPatient(1);
            Debug.WriteLine(test.FirstOrDefault());
            return View(test);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
