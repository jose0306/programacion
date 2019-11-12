using Microsoft.AspNetCore.Mvc;
using example.Models;
using Microsoft.AspNetCore.Identity;

namespace example.Controllers
{
    public class CuentaController: Controller
    {
        private TiendaContext _context;
        private  UserManager<Usuario> _um;
        
        private SignInManager<Usuario> _sim;

        public CuentaController(TiendaContext x,UserManager<Usuario> um ,SignInManager<Usuario> sim) {
            _context = x;
            _um=um;
            _sim=sim;
        }
        public IActionResult Registro(){
            return View();
        }
        [HttpPost]
        public IActionResult Registro(string correo, string pass){
            var usuario=new Usuario();
            usuario.UserName=correo;
            usuario.Email=correo;
            var resultado=_um.CreateAsync(usuario,pass).Result;
            if(resultado.Succeeded){
                return RedirectToAction("index","home");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Login(string correo,string pass){
            var resultado = _sim.PasswordSignInAsync(correo,pass,false,false).Result;
            if(resultado.Succeeded){
                return RedirectToAction("index","home");
            }
            return View();
        }
        public IActionResult Login(){
            return View();
        }
        public IActionResult Logout(){
            _sim.SignOutAsync();
            return RedirectToAction("index","home");
        }

    }
}