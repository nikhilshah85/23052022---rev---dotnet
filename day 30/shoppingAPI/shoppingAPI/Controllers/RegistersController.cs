using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shoppingAPI.Models.EF;

namespace shoppingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistersController : ControllerBase
    {
        private readonly shoppingDBContext _context = new shoppingDBContext();

        //public RegistersController(shoppingDBContext context)
        //{
        //    _context = context;
        //}

        // GET: api/Registers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Register>>> GetRegisters()
        {
          if (_context.Registers == null)
          {
              return NotFound();
          }
            return await _context.Registers.ToListAsync();
        }

        // GET: api/Registers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Register>> GetRegister(string id)
        {
          if (_context.Registers == null)
          {
              return NotFound();
          }
            var register = await _context.Registers.FindAsync(id);

            if (register == null)
            {
                return NotFound();
            }

            return register;
        }

        // PUT: api/Registers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRegister(string id, Register register)
        {
            if (id != register.DesiredUserName)
            {
                return BadRequest();
            }

            _context.Entry(register).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegisterExists(id))
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

        // POST: api/Registers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Register>> PostRegister(Register register)
        {
          if (_context.Registers == null)
          {
              return Problem("Entity set 'shoppingDBContext.Registers'  is null.");
          }
            _context.Registers.Add(register);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RegisterExists(register.DesiredUserName))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRegister", new { id = register.DesiredUserName }, register);
        }

        // DELETE: api/Registers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRegister(string id)
        {
            if (_context.Registers == null)
            {
                return NotFound();
            }
            var register = await _context.Registers.FindAsync(id);
            if (register == null)
            {
                return NotFound();
            }

            _context.Registers.Remove(register);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RegisterExists(string id)
        {
            return (_context.Registers?.Any(e => e.DesiredUserName == id)).GetValueOrDefault();
        }
    }
}
