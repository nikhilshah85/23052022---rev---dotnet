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

        [HttpPost]
        [Route("accountlist/add")]
        public IActionResult AddAccount(Accounts newObj)
        {
           return Ok(accObj.AddAccount(newObj));
        }

        [HttpDelete]
        [Route("accountlist/delete/{accNo}")]
        public IActionResult DeleteAccount(int accNo)
        {
            try
            {
                return Ok(accObj.DeleteAccount(accNo));
            }
            catch (Exception es)
            {
                return BadRequest(es.Message);
            }
        }

        [HttpPut]
        [Route("accountslist/edit")]
        public IActionResult UpdateAccount(Accounts change)
        {
            return Ok(accObj.EditAccount(change));
        }


        [HttpPost]
        [Route("accountlist/transfer")]
        public IActionResult Transfer(int fromAccount, int toAccount, int amount)
        {
            return Ok(accObj.TransferFunds(fromAccount, toAccount, amount));
        }



    }
}
