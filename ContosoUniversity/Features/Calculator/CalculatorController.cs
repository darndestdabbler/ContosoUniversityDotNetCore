using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.Features.Calculator
{
    public class CalculatorController : Controller
    {
        public IActionResult Index() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(decimal left, decimal right)
        {
            ViewData["Left"] = left;
            ViewData["Right"] = right;
            ViewData["Sum"] = Calculator.Add(left, right);
            ViewData["Difference"] = Calculator.Subtract(left, right);

            return View();
        }
    }
}
