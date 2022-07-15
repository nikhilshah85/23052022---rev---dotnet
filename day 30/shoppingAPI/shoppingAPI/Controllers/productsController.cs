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
    public class productsController : ControllerBase
    {
        private readonly shoppingDBContext _context = new shoppingDBContext();

        //public productsController(shoppingDBContext context)
        //{
        //    _context = context;
        //}

        // GET: api/products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductList>>> GetProductLists()
        {
          if (_context.ProductLists == null)
          {
              return NotFound();
          }
            return await _context.ProductLists.ToListAsync();
        }

        // GET: api/products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductList>> GetProductList(int id)
        {
          if (_context.ProductLists == null)
          {
              return NotFound();
          }
            var productList = await _context.ProductLists.FindAsync(id);

            if (productList == null)
            {
                return NotFound();
            }

            return productList;
        }

        // PUT: api/products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductList(int id, ProductList productList)
        {
            if (id != productList.PId)
            {
                return BadRequest();
            }

            _context.Entry(productList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductListExists(id))
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

        // POST: api/products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductList>> PostProductList(ProductList productList)
        {
          if (_context.ProductLists == null)
          {
              return Problem("Entity set 'shoppingDBContext.ProductLists'  is null.");
          }
            _context.ProductLists.Add(productList);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProductListExists(productList.PId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProductList", new { id = productList.PId }, productList);
        }

        // DELETE: api/products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductList(int id)
        {
            if (_context.ProductLists == null)
            {
                return NotFound();
            }
            var productList = await _context.ProductLists.FindAsync(id);
            if (productList == null)
            {
                return NotFound();
            }

            _context.ProductLists.Remove(productList);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductListExists(int id)
        {
            return (_context.ProductLists?.Any(e => e.PId == id)).GetValueOrDefault();
        }
    }
}
