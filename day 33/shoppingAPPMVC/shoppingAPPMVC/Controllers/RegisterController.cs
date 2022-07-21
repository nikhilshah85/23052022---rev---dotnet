using Microsoft.AspNetCore.Mvc;
using shoppingAPPMVC.Models;
namespace shoppingAPPMVC.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Register()
        {
            ViewBag.response = "";
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterUser reg)
        {
            RegisterUser rObj = new RegisterUser(); //new object of model
            ViewBag.response = rObj.Register(reg).Result;
            return View();
        }
    }

}
