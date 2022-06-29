using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bankingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        Accounts accObj = new Accounts();

        [HttpGet]
        [Route("accountlist")]
        public IActionResult GetAllAccounts()
        {
            return Ok(accObj.GetAllAccounts());
        }

        [HttpGet]
        [Route("accountlist/{accountId}")]
        public IActionResult GetAccounts(int accountId)
        {
            try
            {
                return Ok(accObj.GetAccountById(accountId));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
