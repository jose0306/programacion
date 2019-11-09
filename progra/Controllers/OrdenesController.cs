using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using progra.Models;

namespace progra.Controllers
{
    public class OrdenesController : Controller
    {
        private TiendaContext _context;
        public OrdenesController(TiendaContext x) {
            _context = x;
        }

        public IActionResult Index()
        {
            var lista = _context.Ordenes.Include(x => x.Empleado).Include(x => x.Cliente).ToList();
        
            return View(lista);
        }

        public IActionResult Registrar()
        {
            ViewBag.Empleados = _context.Empleados.ToList();
            ViewBag.Clientes = _context.Clientes.ToList();
            return View();
        }        

        [HttpPost]
        public IActionResult Registrar(Orden o)
        {   ViewBag.Empleados = _context.Empleados.ToList();
            ViewBag.Clientes = _context.Clientes.ToList();
            
            if (ModelState.IsValid) {
                _context.Add(o);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(o);
        
         }
    }
}