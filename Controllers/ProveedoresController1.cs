using Microsoft.AspNetCore.Mvc;

namespace IntroduccionMVC.Controllers
{
    public class ProveedoresController1 : Controller
    {
        public string ListaProveedores()
        {
            return "Intel, Nvidia, MSI, Kingston, Samsumg, etc.";
        }
    }
}
