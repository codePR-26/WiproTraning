using Microsoft.AspNetCore.Mvc;
using WiproWebApp.DAL;

namespace WiproWebApp.Controllers
{
    public class PatientsController : Controller
    {
        private readonly CRUD _context;
        public PatientsController(CRUD context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<Patient> patients = _context.GetPatients();
            return View(patients);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Patient p)
        {
            _context.AddPatient(p);
            return RedirectToAction("Index");
        }
    }
}