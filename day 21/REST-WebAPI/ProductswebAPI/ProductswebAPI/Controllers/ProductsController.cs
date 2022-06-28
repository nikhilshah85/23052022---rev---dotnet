using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductswebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        #region Test Methods
        [HttpGet]
        [Route("greet")]
        public IActionResult Greetings()
        {
            return Ok("Hello and Welcome to Web API Development");
        }

        [HttpGet]
        [Route("greet/{guestName}")]
        public IActionResult Greetings(string guestName)
        {
            return Ok("Welcome to Products API " + guestName);
        }

        [HttpGet]
        [Route("add/{num1}/{num2}")]
        public IActionResult Addnumbers(int num1, int num2)
        {
            return Ok(num1 + num2);
        }
        #endregion

        #region Static Product List - CRUD Operation

        static List<string> pList = new List<string>()
        {
            "Pepsi","Coke","IPhone","Air Pods","Trail Hawk","Fossil"
        };


        //[HttpGet]
        //[Route("plist")]
        //public IActionResult ProductList()
        //{
        //    return Ok(pList);
        //}


        //[HttpGet]
        //[Route("plist/{idx}")]
        //public IActionResult GetProductByIndex(int idx)
        //{
        //    try
        //    {
        //        return Ok(pList[idx]);
        //    }
        //    catch(ArgumentOutOfRangeException es)
        //    {
        //        return NotFound("Product Not Found, try a value less than " + (pList.Count - 1));
        //    }

        //}


        //[HttpPost]
        //[Route("plist/add/{newProductName}")]
        //public IActionResult AddProduct(string newProductName)
        //{
        //    if (newProductName.Length < 3)
        //    {
        //        return Ok("Please Provide Product name greater than 3 characters");
        //    }
        //    if (pList.Contains(newProductName))
        //    {
        //        return Ok("Product Already Exists");
        //    }
        //    pList.Add(newProductName);
        //    return Created("","Product Added Successfully");
        //}


        //[HttpDelete]
        //[Route("plist/delete/{idx}")]
        //public IActionResult DeleteProduct(int idx)
        //{
        //    if ( idx > (pList.Count - 1))
        //    {
        //        return NotFound("Sorry incorrect position, try value less than " + (pList.Count - 1));
        //    }
        //    pList.RemoveAt(idx);
            
        //    return Accepted("","Product Removed successfully");
        //}


        //[HttpPut]
        //[Route("plist/update/{idx}/{newValue}")]
        //public IActionResult EditProduct(int idx,string newValue)
        //{
        //    if (idx > (pList.Count - 1))
        //    {
        //        return NotFound("Sorry incorrect position, try value less than " + (pList.Count - 1));
        //    }
        //    var oldvalue = pList[idx];
        //    pList[idx] = newValue;
        //    return Accepted("Product " + oldvalue + " updated to " + newValue);
        //}


        #endregion

        #region dummy
        //public IActionResult SearchProduct(int pId)
        //{
        //    //connect to database, fire a sql sql query
        //    //see if the data is coming

        //    if (dataIsFound)
        //    {
        //        return Ok("Product Details");
        //    }
        //    else
        //        return NotFound("Product not found in system");
        //}
        #endregion

        Products pobj = new Products();

        [HttpGet]
        [Route("plist")]
        public IActionResult ProductList()
        {
            return Ok(pobj.GetProductList());
        }
    }
}








