using HealthCite.web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HealthCite.web.Controllers
{
    public class PanelController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AdminPanel()
        {
            return View();
        }

        public IActionResult MedicalPanel()
        {
            return View();
        }

        public IActionResult DepartamentPanel()
        {
            return View();
        }

        public IActionResult AppointmentPanel()
        {
            return View();
        }

        public IActionResult AppointmentDetails()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
