using Microsoft.AspNetCore.Mvc;
using ClassLibrary;

namespace WebApplication1.Controllers
{
    public class UsuariosController : Controller
    {
        Sistema sistema = Sistema.Instancia;

        [HttpGet]
        public IActionResult Login()
        {
            if (TempData["Exito"] is not null) ViewBag.Exito = TempData["Exito"];
            return View();
        }

        [HttpPost]
        public IActionResult IniciarSesion(string email, string password)
        {
            try
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password)) throw new Exception("Todos los Campos Son Obligatorrios");

                Empleado empleado = sistema.ObtenerEmpleadoPorEmailYPassword(email, password);

                if (empleado == null) throw new Exception("Credenciales Incorrectas");

                HttpContext.Session.SetString("Nombre", empleado.Nombre);
                HttpContext.Session.SetString("Email", empleado.Email);
                HttpContext.Session.SetString("TipoUsuario", empleado.TipoEmpleado());

                TempData["Nombre"] = empleado.Nombre;
                TempData["Email"] = empleado.Email;

                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.Email = email;
                return View("Login");
            }
        }

        [HttpGet]
        public IActionResult Registrarse()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registro(string nombre, string email, string password, string residente)
        {
            try
            {
                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(residente)) throw new Exception("Todos Los Campos Son Obligatorios");

                bool esResidente = bool.TryParse(residente, out esResidente);

                sistema.AltaEmpleado(new Peon(email, password, nombre, DateTime.Now, esResidente));

                TempData["Exito"] = "Usuario Creado Correctamente";

                return RedirectToAction("Login", "Usuarios");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.nombre = nombre;
                ViewBag.Email = email;
                ViewBag.Residente = residente;

                return View("Registrarse");
            }
        }

        [HttpGet]
        public IActionResult CerrarSesion()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Usuarios");
        }
    }
}
