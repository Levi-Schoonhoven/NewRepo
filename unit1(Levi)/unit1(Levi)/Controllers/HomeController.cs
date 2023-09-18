using Microsoft.AspNetCore.Mvc;

namespace unit1_Levi_.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FV = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(FutureValueModel Model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FV = Model.CalculateFutureValue();
            }
            else
            {
                ViewBag.FV = 0;
            }
            return View(Model);

        }

    }
}
