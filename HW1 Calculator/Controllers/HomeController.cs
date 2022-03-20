using Microsoft.AspNetCore.Mvc;
using HW1_Calculator.Models;

namespace HW1_Calculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Result = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(Calculator calc, string type)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Result = calc.Calculate(type);
            }
            else
                ViewBag.Result = 0;

            return View(calc);
        }
    }
}
