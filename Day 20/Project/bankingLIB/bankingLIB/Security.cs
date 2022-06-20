using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace bankingLIB
{
   public enum UserType
    {
        Admin,
        User
    }
    public class Security
    {
        public string Login(string userName, string password,UserType p_uType)
        {
            SqlConnection con = new SqlConnection("server=WIN8\\NIKHILINSTANCE;database=BankingDB;integrated security=true");
            SqlCommand cmd;
            if (p_uType == UserType.Admin)
            {
                cmd = new SqlCommand("select count(*) from AdminLogin where userName=@uName and password=@pwd",con);
            }
            else
            {
                cmd = new SqlCommand("select count(*) from userLogin where userName=@uName and password=@pwd", con);
            }

            cmd.Parameters.AddWithValue("@uName",userName);
            cmd.Parameters.AddWithValue("@pwd", password);

            con.Open();                    
             int loginResult =(int) cmd.ExecuteScalar();
            con.Close();

            if (p_uType == UserType.User)
            {
                SqlCommand cmdAttemps = new SqlCommand("select status,attemps from userLogin where userName=@uName", con);

                cmdAttemps.Parameters.AddWithValue("@uName", userName);
                con.Open();

                SqlDataReader readUser = cmdAttemps.ExecuteReader();
                if (readUser.Read())
                {
                    string status = readUser[0].ToString();
                    int attemps = (int)readUser[1];
                    readUser.Close();

                    if (status == "Blocked")
                    {
                        return "Account is Blocked, please contact Admin";
                    }                    
                    if(loginResult == 1 && status == "Active")
                    {
                        return "Login Successful";
                    }                   
                    else
                    {
                        SqlCommand updateAccount;
                        if (attemps == 3)
                        {
                            updateAccount = new SqlCommand("update userLogin set status = 'Blocked' where userName=@uName", con);
                        }
                        else
                        {
                             updateAccount = new SqlCommand("update userLogin set attemps=attemps+1 where userName=@uName", con);
                        }
                        updateAccount.Parameters.AddWithValue("@uName", userName);
                        updateAccount.ExecuteNonQuery();

                        return "Login Failed for User " + userName;
                    }
                
                }
                con.Close();
                return "Blank";
            }
            else
            {
                if (loginResult == 1)
                {
                    return "Login Successful For Admin";
                }
                else
                {
                    return "Login Failed For Admin";
                }
            }














        }

    }
}



