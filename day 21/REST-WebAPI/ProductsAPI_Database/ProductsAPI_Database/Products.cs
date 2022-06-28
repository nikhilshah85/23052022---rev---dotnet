using System.Data.SqlClient;

namespace ProductsAPI_Database
{
    public class Products
    {
        public string productName { get; set; }

        SqlConnection con = new SqlConnection("server=Win8\\nikhilinstance;database=ProductsDB;integrated security=true");

        public List<Products> GetAllProducts()
        {
            SqlCommand cmd = new SqlCommand("select * from productlist", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            List<Products> pList = new List<Products>();

            while (rd.Read())
            {
                pList.Add(new Products() { productName = rd[0].ToString() });
            }

            con.Close();
            return pList;

        }




        //public Products GetProductById(int pId)
        //{
        //    SqlCommand cmd = new SqlCommand("select * from productlist where pid=@pid",con);
        //    cmd.Parameters.AddWithValue("@pid",pId);
        //}

        public string AddProduct(Products newProduct)
        {
            SqlCommand cmd = new SqlCommand("insert into productlist values(@newProduct)", con);
            cmd.Parameters.AddWithValue("@newProduct", newProduct.productName);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return "Product Added Successfully";
        }

        public string DeleteProduct(int pId)
        {
            SqlCommand cmd = new SqlCommand("delete from productlist where pid=@pid", con);
            cmd.Parameters.AddWithValue("@pid", pId);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return "Product Deleted Succssfully";

        }

        //public string UpdateProduct(string newName)
        //{
        //    SqlCommand cmd = new SqlCommand("update productlist set productname=@newName where pid=@pId", con);
        //    cmd.Parameters.AddWithValue("@newName", newName);
        //    cmd.Parameters.AddWithValue("@pId", pId);

        //}



    }
}
