using IntroduccionMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntroduccionMVC.Controllers
{
    public class ClientesController : Controller
    {
        public static List<Cliente> ListaClientes = new List<Cliente> 
        {

            new Cliente{
            Id = 1,
            Nombre = "Ángel",
            FechaAlta = DateTime.Parse
            (DateTime.Today.ToString()),
            Correo = "angel@gmail.com"

            },

            new Cliente{
              Id = 2,
            Nombre = "Patricia",
            FechaAlta = DateTime.Parse
            (DateTime.Today.ToString()),
            Correo = "paty@gmail.com"
            }
         };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Pedidos()
        {
            return View();
        }



        public IActionResult ListadoClientes()
        {

            return View(ListaClientes);
        }

        public IActionResult Create() {
            return View();
        }
        //POST: cLIENTES/cREATE
        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            try
            {

                //Agregamos el nuevo cliente al modelo
                ListaClientes.Add(cliente);
                return RedirectToAction("ListadoClientes");
            }

            catch (Exception ex)
            {
                return View();
            }   
        
        }
    }



}
