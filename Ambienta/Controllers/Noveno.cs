using Ambienta.Services.Tests;
using Microsoft.AspNetCore.Mvc;

namespace Ambienta.Controllers
{
    public class Noveno : Controller
    {
        private readonly NovenoTest _novenoTest;

        public Noveno (NovenoTest novenoTest)
        {
            _novenoTest = novenoTest;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SintesisDeProteinas()
        {
            return View();
        }

        public JsonResult SintesisDeProteinasTest(char question1, char question2, char question3, char question4, char question5, char question6, char question7, char question8, char question9, char question10)
        {
            object result = _novenoTest.SintesisDeProteinasTest(question1, question2, question3, question4, question5, question6, question7, question8, question9, question10);

            // Devolver el resultado como JSON
            return Json(result);
        }

        public IActionResult LeyesDeMendel()
        {
            return View();
        }

        public JsonResult LeyesDeMendelTest(char question1, char question2, char question3, char question4, char question5, char question6, char question7, char question8, char question9, char question10)
        {
            object result = _novenoTest.LeyesDeMendelTest(question1, question2, question3, question4, question5, question6, question7, question8, question9, question10);

            // Devolver el resultado como JSON
            return Json(result);
        }
    }
}
