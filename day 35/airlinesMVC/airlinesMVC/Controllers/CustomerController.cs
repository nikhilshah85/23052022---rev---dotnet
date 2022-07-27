using Microsoft.AspNetCore.Mvc;

namespace airlinesMVC.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult CustomerList()
        {
            return View();
        }
    }
}
