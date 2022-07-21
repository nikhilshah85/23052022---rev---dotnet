using Newtonsoft.Json;

namespace shoppingAPPMVC.Models
{
    public class AuthenticateUser
    {
        public string uName { get; set; }
        public string pwd { get; set; }

        public async Task<string> CheckUserLogin(string userName, string password)
        {

            string url = "https://localhost:7001/api/Login/login/" + userName + "/" + password;

            //var myContent = JsonConvert.SerializeObject(newProduct);
            ////var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            //var byteContent = new ByteArrayContent(buffer);
            //byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(url))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        return data;
                    }
                }
            }
            return "please contact Admin ";



        }
    }
}
