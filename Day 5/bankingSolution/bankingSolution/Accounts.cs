using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingSolution
{
    internal abstract class Accounts
    {
        public int accNo { get; set; }
        public string accName { get; set; }
        public double accBalance { get; set; }
        public bool accIsActive { get; set; }
        public DateTime accCreationDate { get; set; }

        public  double  CheckBalance()
        {
            return accBalance;
        }

        public virtual double Widraw(int w_amount)
        {
            accBalance = accBalance - w_amount;
            return accBalance;
        }

        public double Deposit(int d_amount)
        {
            accBalance = accBalance + d_amount;
            return accBalance;
        }



    }
}
