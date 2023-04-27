using Microsoft.AspNetCore.Mvc;

namespace EatAndDrink.Controllers
{
    public class RestaurantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
