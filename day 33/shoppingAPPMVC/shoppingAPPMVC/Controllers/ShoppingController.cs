using Microsoft.AspNetCore.Mvc;

namespace shoppingAPPMVC.Controllers
{
    public class ShoppingController : Controller
    {
       public IActionResult Productlist()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Orders()
        {
            return View();
        }

        public IActionResult Photos()
        {
            return View();
        }
    }
}
