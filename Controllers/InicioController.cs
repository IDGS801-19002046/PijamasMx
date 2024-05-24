using Microsoft.AspNetCore.Mvc;

namespace IntroduccionMVC.Controllers
{
    public class InicioController : Controller
    {
        public String Index()
        {
            return "Mi primer controlador en ASP .NEt Core MVC";
        }

        //GET: Buscar

        public ActionResult Buscar (string nombre)
        {
            return Content("El nombre a buscar es :" + nombre);
        }

        //GET: Redirecciona

        public ActionResult Redirecciona() 
        {
            return RedirectToAction("ListaProveedores",
                "Proveedores");
        }
            
    }
}
