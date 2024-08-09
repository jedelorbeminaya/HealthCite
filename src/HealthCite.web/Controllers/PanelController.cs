using HealthCite.Domain.Entities;
using HealthCite.Infrastructure;
using HealthCite.web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        private readonly HealthCiteDbContext _context;

        public PanelController(HealthCiteDbContext context)
        {
            _context = context;
        }

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


        public async Task<IActionResult> AppointmentPanel()
        {
            return View(await _context.Citas.ToListAsync());
        }


        public async Task<IActionResult> AppointmentDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Appointment = await _context.Citas.Include("Genero").FirstOrDefaultAsync(m => m.Id == id);

            if (Appointment == null)
            {
                return NotFound();
            }

            return View(Appointment);
        }

        [HttpPost, ActionName("AppointmentDetails")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AppointmentDetails(int id)
        {
            var Appointment = await _context.Citas.FindAsync(id);
            _context.Citas.Remove(Appointment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(AppointmentPanel));
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
