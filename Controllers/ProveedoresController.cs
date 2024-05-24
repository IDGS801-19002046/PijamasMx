using Microsoft.AspNetCore.Mvc;

namespace IntroduccionMVC.Controllers
{
    public class ProveedoresController : Controller
    {
        public string ListaProveedores()
        {
            return "Intel, Nvidia, MSI, Kingston, Samsumg, etc.";
        }
    }
}
