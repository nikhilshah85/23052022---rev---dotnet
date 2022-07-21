using Microsoft.AspNetCore.Mvc;
using shoppingAPPMVC.Models;
namespace shoppingAPPMVC.Controllers
{
    public class ProductsController : Controller
    {
      
        public IActionResult AddProduct()
        {
            ViewBag.result = "";
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(ProductlistModel newProduct)
        {
            ProductlistModel pObj = new ProductlistModel();
            ViewBag.result = pObj.AddNewProduct(newProduct).Result;
            return View();
        }
    }
}
