using Microsoft.AspNetCore.Mvc;

namespace EatAndDrink.Controllers
{
    public class EatAndDrink : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
