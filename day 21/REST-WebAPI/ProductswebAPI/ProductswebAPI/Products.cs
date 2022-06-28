using System.Data.SqlClient;
namespace ProductswebAPI
{
    public class Products
    {
          public string ProductName { get; set; }

        SqlConnection con = new SqlConnection("server=WIN8\\NIKHILINSTANCE;database=productsDB;integrated security=true");

        public List<string> GetProductList()
        {
            SqlCommand cmd = new SqlCommand("select * from ProductList", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            List<string> result = new List<string>();
            while (rd.Read())
            {
                // result.Add(new Products() { ProductName = rd[0].ToString() });
                result.Add(rd[0].ToString());
            }
            return result;
        }

    }
}



