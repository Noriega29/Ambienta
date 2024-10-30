using Ambienta.Services.Tests;
using Microsoft.AspNetCore.Mvc;

namespace Ambienta.Controllers
{
    public class Decimo : Controller
    {
        private readonly DecimoTest _decimoTest;

        public Decimo (DecimoTest decimoTest)
        {
            _decimoTest = decimoTest;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
