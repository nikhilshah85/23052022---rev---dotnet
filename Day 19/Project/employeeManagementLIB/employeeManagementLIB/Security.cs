using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace employeeManagementLIB
{
    public  class Security
    {
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string userStatus { get; set; }
        public int attempts { get; set; }

        SqlConnection con = new SqlConnection("server=WIN8\\NIKHILINSTANCE;database=employeeManagementDB;user id=sa;password=Password1234");

        public  bool CheckUserCredentials(string p_uName, string p_pwd)
        {
            SqlCommand cmdCheckLogin = new SqlCommand("select count(*) from tbl_Login where userName=@uName and password=@pwd", con);
            cmdCheckLogin.Parameters.AddWithValue("@uName", p_uName);
            cmdCheckLogin.Parameters.AddWithValue("@pwd", p_pwd);
            con.Open();
            int v_queryResult =Convert.ToInt32(cmdCheckLogin.ExecuteScalar());
            //int v_queryResult2 = (int)cmdCheckLogin.ExecuteScalar();
            con.Close();
            if (v_queryResult == 0)
            {
                return false;
            }
            return true;
        }
    }
}
