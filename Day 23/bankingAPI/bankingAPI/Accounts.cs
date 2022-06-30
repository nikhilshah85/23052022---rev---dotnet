using System.Data.SqlClient;
namespace bankingAPI
{
    public class Accounts
    {
        public int accNo { get; set; }
        public string accName { get; set; }
        public string accType { get; set; }
        public double accBalance { get; set; }
        public bool accIsActive { get; set; }

        SqlConnection con = new SqlConnection(@"server=WIN8\NIKHILINSTANCE;database=bankingDBAPI;user id=sa;password=Password1234");

        public List<Accounts> GetAllAccounts()
        {
            SqlCommand cmd = new SqlCommand("select * from accountsInfo", con);
            con.Open();
            List<Accounts> accountsList = new List<Accounts>();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                accountsList.Add(new Accounts()
                {
                    accNo = Convert.ToInt32(rd[0]),
                    accName = rd[1].ToString(),
                    accType = rd[2].ToString(),
                    accBalance = Convert.ToDouble(rd[3]),
                    accIsActive = Convert.ToBoolean(rd[4])
                });
            }
            rd.Close();
            con.Close();

            return accountsList;

        }

        public Accounts GetAccountById(int p_accNo)
        {
            SqlCommand cmd = new SqlCommand("select * from accountsInfo where accNo=@accNo", con);
            cmd.Parameters.AddWithValue("@accNo", p_accNo);
            SqlDataReader rd = null;
            try
            {
                con.Open();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    Accounts acc = new Accounts()
                    {
                        accNo = Convert.ToInt32(rd[0]),
                        accName = rd[1].ToString(),
                        accType = rd[2].ToString(),
                        accBalance = Convert.ToDouble(rd[3]),
                        accIsActive = Convert.ToBoolean(rd[4])
                    };
                    return acc;
                }
                else
                {
                    rd.Close();
                    con.Close();
                    throw new Exception("Account Not Found");
                }
            }
            catch(Exception es)
            {
                throw new Exception(es.Message);
            }
            finally
            {
                rd.Close();
                con.Close();
            }


        }


        public string AddAccount(Accounts newAccount)
        {
            SqlCommand cmd = new SqlCommand("insert into accountsinfo values(@accNo,@accName,@accType,@accBalance,@accIsActive)", con);
            cmd.Parameters.AddWithValue("@accNo", newAccount.accNo);
            cmd.Parameters.AddWithValue("@accName", newAccount.accName);
            cmd.Parameters.AddWithValue("@accType", newAccount.accType);
            cmd.Parameters.AddWithValue("@accBalance", newAccount.accBalance);
            cmd.Parameters.AddWithValue("@accIsActive", newAccount.accIsActive);
            con.Open();
           int result = cmd.ExecuteNonQuery();
            con.Close();
            return "Account Created Successfully";
        }

        public string DeleteAccount(int accNo)
        {
            SqlCommand cmd = new SqlCommand("delete from accountsinfo where accNo=@accNo", con);
            cmd.Parameters.AddWithValue("@accNo", accNo);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();

            if (result == 1)
            {
                return "Account Deleted Successfully";
            }
            throw new Exception("Invalid Account Number, account number not found in system");

        }

        public string EditAccount(Accounts changes)
        {
            SqlCommand cmd = new SqlCommand("update accountsinfo set accIsActive=@isActive,accName=@accName where accNo =@accNo", con);
            cmd.Parameters.AddWithValue("@isActive", changes.accIsActive);
            cmd.Parameters.AddWithValue("@accName", changes.accName);
            cmd.Parameters.AddWithValue("@accNo", changes.accNo);

            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();

            return "Account Updated Successfully";
        }

        public string TransferFunds(int fromAccount,int toAccount,int amount)
        {
            SqlCommand cmd_fromAccount = new SqlCommand("update accountsinfo set accBalance=accBalance-@amt where accno=@FromaccNo",con);
            SqlCommand cmd_toAccount = new SqlCommand("update accountsinfo set accBalance = accBalance + @amt where accno = @toAccNo",con);
            SqlCommand cmd_transaction = new SqlCommand("insert into transactions values(@trType,GetDate(),@FromaccNo,@toAccNo,@amt)",con);

            cmd_fromAccount.Parameters.AddWithValue("@amt",amount);
            cmd_fromAccount.Parameters.AddWithValue("@FromaccNo",fromAccount);


            cmd_toAccount.Parameters.AddWithValue("@amt",amount);
            cmd_toAccount.Parameters.AddWithValue("@toAccNo",toAccount);

            cmd_transaction.Parameters.AddWithValue("@trType","Transfer");
            cmd_transaction.Parameters.AddWithValue("@FromaccNo",fromAccount);
            cmd_transaction.Parameters.AddWithValue("@toAccNo",toAccount);
            cmd_transaction.Parameters.AddWithValue("@amt",amount);

            con.Open();
            cmd_fromAccount.ExecuteNonQuery();
            cmd_toAccount.ExecuteNonQuery();
            cmd_transaction.ExecuteNonQuery();

            con.Close();
            return "Transfer Done";
        }

    }
}
