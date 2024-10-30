using Ambienta.Services.Tests;
using Microsoft.AspNetCore.Mvc;

namespace Ambienta.Controllers
{
    public class Septimo : Controller
    {
        private readonly SeptimoTest _septimoTest;

        public Septimo (SeptimoTest septimoTest)
        {
            _septimoTest = septimoTest;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TaxonomiaBiologica()
        {
            return View();
        }

        public JsonResult TaxonomiaBiologicaTest(char question1, char question2, char question3, char question4, char question5, char question6)
        {
            object result = _septimoTest.TaxonomiaBiologicaTest(question1, question2, question3, question4, question5, question6);

            // Devolver el resultado como JSON
            return Json(result);
        }

        public IActionResult AlcanosAlquenosYAlquinos()
        {
            return View();
        }

        public JsonResult AlcanosAlquenosYAlquinosTest(char question1, char question2, char question3, char question4, char question5)
        {
            object result = _septimoTest.AlcanosAlquenosYAlquinosTest(question1, question2, question3, question4, question5);

            // Devolver el resultado como JSON
            return Json(result);
        }
    }
}
