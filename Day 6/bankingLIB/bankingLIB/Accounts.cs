using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingLIB
{
    public class Accounts
    {
        public int accNo { get; set; }
        public string accName { get; set; }
        public double accBalance { get; set; }
        public bool accIsActive { get; set; }
        public string accBranch { get; set; }

        public double Widraw(int w_amt)
        {
            accBalance = accBalance - w_amt;
            return accBalance;
        }
        public double Deposit(int d_amt)
        {
            accBalance = accBalance - d_amt;
            return accBalance;
        }

        public void test()
        {
            var s = new Savings();
            var l = new Loan();
        }
    }
}

