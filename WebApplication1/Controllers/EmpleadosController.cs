using ClassLibrary;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class EmpleadosController : Controller
    {
        Sistema sistema = Sistema.Instancia;

        public IActionResult DatosPersonales()
        {
            string email = HttpContext.Session.GetString("Email");

            Peon peon = sistema.ObtenerPeonPorEmail(email);

            return View(peon);
        }
    }
}
