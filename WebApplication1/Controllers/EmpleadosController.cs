﻿using ClassLibrary;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class EmpleadosController : Controller
    {
        Sistema sistema = Sistema.Instancia;

        [HttpGet]
        public IActionResult DatosPersonales()
        {
            string email = HttpContext.Session.GetString("Email");

            Peon peon = sistema.ObtenerPeonPorEmail(email);

            return View(peon);
        }

        [HttpGet]
        public IActionResult RegistrarVacunacion()
        {
            ViewBag.Ovinos = sistema.ObtenerOvinos();
            ViewBag.Bovinos = sistema.ObtenerBovinos();
            ViewBag.Vacunas = sistema.Vacunas;
            return View();
        }

        [HttpPost]
        public IActionResult Vacunar(string codigoCaravana, string vacuna)
        {
            try
            {
                if (string.IsNullOrEmpty(codigoCaravana) || string.IsNullOrEmpty(vacuna)) throw new Exception("Seleccione una Vacuna");

                int id = int.Parse(vacuna);

                Vacuna vacuna1 = sistema.ObtenerVacunaPorId(id);

                Animal animal = sistema.ObtenerAnimalPorCodigoCaravana(codigoCaravana);

                if (animal is null) throw new Exception("Animal No Encontrado");

                animal.Vacunar(vacuna1, DateTime.Now, DateTime.Now.AddMonths(6));

                ViewBag.Exito = $"{vacuna1.Nombre} Asignada Correctamente Al Animal Con Código Caravana: {codigoCaravana}";

                return View("RegistrarVacunacion");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;

                return View("RegistrarVacunacion");
            }
        }

        public IActionResult AnimalesVacunados()
        {
            ViewBag.Animales = sistema.Animales;
            return View();
        }
    }
}
