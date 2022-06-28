using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductsAPI_Database.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        Products pObj = new Products();
        
        [HttpGet]
        [Route("plist")]
        public IActionResult GetAllProducts()
        {
            return Ok(pObj.GetAllProducts());
        }

        [HttpPost]
        [Route("plist/add/{newProduct}")]
        public IActionResult AddProduct(Products newProduct)
        {
            return Created("",pObj.AddProduct(newProduct));
        }

        [HttpDelete]
        [Route("plist/delete/{pid}")]

        public IActionResult DeleteProduct(int pId)
        {
            return Accepted(pObj.DeleteProduct(pId));
        }
    
    }
}
