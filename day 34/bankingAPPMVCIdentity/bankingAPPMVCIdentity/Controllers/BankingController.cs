using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace bankingAPPMVCIdentity.Controllers
{

    [Authorize] //user will need to identify themself on a login page to get access to actions in this controller
    public class BankingController : Controller
    {
        [AllowAnonymous]
        public IActionResult Banking()
        {
            return View();
        }

        public IActionResult TranferFunds()
        {
            return View();
        }

        public IActionResult DownloadStatements()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }
    }
}
