using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace shoppingAPPMVC.Models
{
    public class RegisterUser
    {

        public string desiredUserName { get; set; }
        public string desiredPassword { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public int contactNo { get; set; }
        public int age { get; set; }
        public string city { get; set; }
        public string address { get; set; }


        public async Task<string> Register(RegisterUser newRegister)
        {
               string url = "https://localhost:7001/api/Registers";          

            var myContent = JsonConvert.SerializeObject(newRegister);
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
                        if (data != null) { return "User Registered Successfully"; }
                    }
                }
            }
            return "Registration Failed, please contact Admin ";

        }

    }
}
