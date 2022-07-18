using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using bankingAPI.Models.EF;

namespace bankingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly bankingLINQContext _context = new bankingLINQContext();

        //public AccountsController(bankingLINQContext context)
        //{
        //    _context = context;
        //}

        // GET: api/Accounts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccountsInfo>>> GetAccountsInfos()
        {
          if (_context.AccountsInfos == null)
          {
              return NotFound();
          }
            return await _context.AccountsInfos.ToListAsync();
        }

        // GET: api/Accounts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AccountsInfo>> GetAccountsInfo(int id)
        {
          if (_context.AccountsInfos == null)
          {
              return NotFound();
          }
            var accountsInfo = await _context.AccountsInfos.FindAsync(id);

            if (accountsInfo == null)
            {
                return NotFound();
            }

            return accountsInfo;
        }

        // PUT: api/Accounts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAccountsInfo(int id, AccountsInfo accountsInfo)
        {
            if (id != accountsInfo.AccNo)
            {
                return BadRequest();
            }

            _context.Entry(accountsInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccountsInfoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Accounts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AccountsInfo>> PostAccountsInfo(AccountsInfo accountsInfo)
        {
          if (_context.AccountsInfos == null)
          {
              return Problem("Entity set 'bankingLINQContext.AccountsInfos'  is null.");
          }
            _context.AccountsInfos.Add(accountsInfo);
            
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AccountsInfoExists(accountsInfo.AccNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAccountsInfo", new { id = accountsInfo.AccNo }, accountsInfo);
        }

        // DELETE: api/Accounts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAccountsInfo(int id)
        {
            if (_context.AccountsInfos == null)
            {
                return NotFound();
            }
            var accountsInfo = await _context.AccountsInfos.FindAsync(id);
            if (accountsInfo == null)
            {
                return NotFound();
            }

            _context.AccountsInfos.Remove(accountsInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AccountsInfoExists(int id)
        {
            return (_context.AccountsInfos?.Any(e => e.AccNo == id)).GetValueOrDefault();
        }

        [HttpGet]
        [Route("totalAccounts/{type}")]
        public IActionResult GetTotalAccount(string type)
        {
            var total = (from a in _context.AccountsInfos
                         where a.AccType == type
                         select a).Count();

            return Ok(total);
        }

    }
}
