using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shoppingAPI.Models.EF;
namespace shoppingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        shoppingDBContext db = new shoppingDBContext();

        [HttpGet]
        [Route("login/{uName}/{pwd}")]
        public IActionResult CheckLogin(string uName, string pwd)
        {
            //Linq - set of 10-12 queries, which looks like SQL queries

            var loginResult = (from d in db.Registers
                               where d.DesiredUserName == uName && d.DesiredPassword == pwd
                               select d).Count();
            if (loginResult == 1)
            {
                return Ok("Login Successfull");
            }
            else
            {
                return NotFound("Sorry user not found");
            }
        }
    }
}
