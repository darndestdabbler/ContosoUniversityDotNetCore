using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.Features.Calculator
{
    /// <summary>
    /// The calculator page, reached as /Calculator by the default route.
    /// </summary>
    public class CalculatorController : Controller
    {
        /// <summary>Shows the calculator form with no result.</summary>
        /// <returns>The calculator view.</returns>
        public IActionResult Index() => View();

        /// <summary>Shows the sum and the difference of the two numbers submitted.</summary>
        /// <param name="left">The first number.</param>
        /// <param name="right">The second number.</param>
        /// <returns>The calculator view, carrying both numbers and both results.</returns>
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
