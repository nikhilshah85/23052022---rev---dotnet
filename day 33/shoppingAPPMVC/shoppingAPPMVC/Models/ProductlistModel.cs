using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace shoppingAPPMVC.Models
{
    public class ProductlistModel
    {
        //        "pId": 0,
        //"pName": "string",
        //"pCategory": "string",
        //"pPrice": 0,
        //"pAvailableQty": 0,
        //"pIsInStock": true,

        public int pId { get; set; }
        public string pName { get; set; }
        public string pCategory { get; set; }
        public int pPrice { get; set; }
        public int pAvailableQty { get; set; }
        public bool pIsInStock { get; set; }

        public async Task<string> AddNewProduct(ProductlistModel newProduct)
        {
            string url = "https://localhost:7001/api/products";

            var myContent = JsonConvert.SerializeObject(newProduct);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PostAsync(url, byteContent))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null) { return "Product Added Successfully"; }
                    }
                }
            }
            return "please contact Admin ";


        }
    }
}
