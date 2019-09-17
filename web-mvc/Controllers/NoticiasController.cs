using Microsoft.AspNetCore.Mvc;

namespace web_mvc.Controllers
{
    public class NoticiasController :Controller
    {
        public IActionResult UltimasNoticias(){
            return View();
        }
        public IActionResult NoticiasPorCategoria(){
            return View();
        }
    }
}