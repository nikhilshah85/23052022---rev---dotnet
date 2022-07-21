using Microsoft.AspNetCore.Mvc;
using shoppingAPPMVC.Models;
namespace shoppingAPPMVC.Controllers
{
    public class SecurityController : Controller
    {
        public IActionResult Login()
        {
            ViewBag.result = "";
            return View();
        }

        [HttpPost]
        public IActionResult Login(string uName, string pwd)
        {
            AuthenticateUser user = new AuthenticateUser();
            ViewBag.result = user.CheckUserLogin(uName, pwd).Result;

            if (ViewBag.result == "Login Successfull")
            {
                RedirectToAction("AddProducts", "Products");
            }
            return View();
        }
    }
}
