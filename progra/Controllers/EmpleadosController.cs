using System.Linq;
using Microsoft.AspNetCore.Mvc;
using progra.Models;

namespace progra.Controllers
{
    public class EmpleadosController  : Controller
    {
        private TiendaContext _context;
        public EmpleadosController(TiendaContext x) {
            _context = x;
        }

        public IActionResult Index()
        {
            var lista = _context.Empleados.ToList();
        
            return View(lista);
        }

        public IActionResult Registrar()
        {
            ViewBag.Empleados = _context.Empleados.ToList();
            return View();
        }        

        [HttpPost]
        public IActionResult Registrar(Empleado e)
        {   ViewBag.Empleados = _context.Empleados.ToList();
            
            if (ModelState.IsValid) {
                _context.Add(e);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(e);
        
         }
    }
}