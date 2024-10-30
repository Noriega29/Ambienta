using Ambienta.Services.Tests;
using Microsoft.AspNetCore.Mvc;

namespace Ambienta.Controllers
{
    public class Quinto : Controller
    {
        private readonly QuintoTest _quintoTest;

        public Quinto (QuintoTest quintoTest)
        {
            _quintoTest = quintoTest;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LaCelula()
        {
            return View();
        }

        public JsonResult LaCelulaTest(char question1, char question2, char question3, char question4, char question5)
        {
            object result = _quintoTest.LaCelulaTest(question1, question2, question3, question4, question5);

            // Devolver el resultado como JSON
            return Json(result);
        }

        public IActionResult LosEcosistemasYElMedioAmbiente()
        {
            return View();
        }

        public JsonResult LosEcosistemasYElMedioAmbienteTest(char question1, char question2, char question3, char question4, char question5)
        {
            object result = _quintoTest.EcosistemasYMedioAmbienteTest(question1, question2, question3, question4, question5);

            // Devolver el resultado como JSON
            return Json(result);
        }
    }
}
