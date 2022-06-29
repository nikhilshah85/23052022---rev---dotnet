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



    }
}
