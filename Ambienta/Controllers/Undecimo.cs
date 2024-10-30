using Ambienta.Services.Tests;
using Microsoft.AspNetCore.Mvc;

namespace Ambienta.Controllers
{
    public class Undecimo : Controller
    {
        private readonly UndecimoTest _undecimoTest;

        public Undecimo (UndecimoTest undecimoTest)
        {
            _undecimoTest = undecimoTest;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
