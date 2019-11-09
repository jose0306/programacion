using System.Linq;
using Microsoft.AspNetCore.Mvc;
using progra.Models;

namespace progra.Controllers
{
    public class ClientesController :Controller
    {
         private TiendaContext _context;
        public ClientesController(TiendaContext x) {
            _context = x;
        }

        public IActionResult Index()
        {
            var lista = _context.Clientes.ToList();
        
            return View(lista);
        }

        public IActionResult Registrar()
        {
            ViewBag.Clientes = _context.Clientes.ToList();
            return View();
        }        

        [HttpPost]
        public IActionResult Registrar(Cliente c)
        {   ViewBag.Clientes = _context.Clientes.ToList();
            
            if (ModelState.IsValid) {
                _context.Add(c);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(c);
        
         }
    }
        
}