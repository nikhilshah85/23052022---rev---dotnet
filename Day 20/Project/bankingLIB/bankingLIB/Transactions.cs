using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace bankingLIB
{
    public class Transactions
    {

        public string Transfer(int p_fromAcc,int p_toAccount,int p_amount,UserType p_userType)
        {
            SqlConnection con = new SqlConnection("server=WIN8\\NIKHILINSTANCE;database=BankingDB;integrated security=true");
            SqlCommand cmdFrom = new SqlCommand("update AccountsInfo set accBalance = accBalance - @amount where accNo = @fromAccount", con);
            cmdFrom.Parameters.AddWithValue("@amount", p_amount);
            cmdFrom.Parameters.AddWithValue("@fromAccount", p_fromAcc);

            SqlCommand cmdTo = new SqlCommand("update AccountsInfo set accBalance = accBalance + @amount where accNo = @ToAccount", con);
            cmdTo.Parameters.AddWithValue("@amount", p_amount);
            cmdTo.Parameters.AddWithValue("@ToAccount", p_toAccount);

            SqlCommand cmdTransaction = new SqlCommand("insert into TransactionsInfo values(GETDATE(),@fromAccount,@ToAccount,@amount,@uType)", con);
            cmdTransaction.Parameters.AddWithValue("@fromAccount", p_fromAcc);
            cmdTransaction.Parameters.AddWithValue("@ToAccount", p_toAccount);
            cmdTransaction.Parameters.AddWithValue("@amount", p_amount);
            if (p_userType == 0)
            {
                cmdTransaction.Parameters.AddWithValue("@uType", "Admin");
            }
            else
            {
                cmdTransaction.Parameters.AddWithValue("@uType", "Customer");
            }

            con.Open();
            cmdFrom.ExecuteNonQuery();
            cmdTo.ExecuteNonQuery();
            cmdTransaction.ExecuteNonQuery();
            con.Close();

            return "Transfer Done";
        }


    }
}
