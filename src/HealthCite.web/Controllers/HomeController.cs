using HealthCite.Domain.Entities;
using HealthCite.Infrastructure;
using HealthCite.Web.ViewModels.Citas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HealthCite.web.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private readonly HealthCiteDbContext _context;

        public HomeController(HealthCiteDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            LoadGeneros();
            LoadConsultorios();
            return View();
        }

        [NonAction]
        private void LoadGeneros()
        {
            var Generos = _context.Generos.ToList();
            ViewBag.Generos = new SelectList(Generos, "Id", "Genero");
        }

        [NonAction]
        private void LoadConsultorios()
        {
            var Consultorios = _context.Consultorios.ToList();
            ViewBag.Consultorios = new SelectList(Consultorios, "Id", "Nombre");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(CreateCita model)
        {


            if (ModelState.IsValid)
            {

                var CitaDb= new Citas
                {
                    Nombre = model.Nombre,
                    FechaNacimiento = model.FechaNacimiento,
                    GeneroId = model.GeneroId,
                    CorroElectronico = model.CorroElectronico,
                    ConsultorioId = model.ConsultorioId,
                    FechaCita = model.FechaCita,
                    Motivo = model.Motivo
                };

                _context.Citas.Add(CitaDb);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
