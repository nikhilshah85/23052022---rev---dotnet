using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingLIB_with_Exception
{
    public abstract class Accounts
    {
       
        public int accNo { get; set; }
        public string accName { get; set; }
        public double accBalance { get; set; }
        public bool accIsActive { get; set; }



        public Accounts(int accNo, string accName, double accBalance)
        {
            if (accName.Length < 3)
            {
                throw new Exception("Please provide a name more than 3 characters");
            }
            if (accBalance < 100)
            {
                throw new Exception("Sorry cannot open your account, as initial funding needs to be 100$");
            }

            this.accNo = accNo;
            this.accName = accName;
            this.accBalance = accBalance;
            this.accIsActive = true;

            
        }

        public virtual double Widraw(int p_widrawalAmt)
        {
            if (p_widrawalAmt < 0)
            {
                throw new Exception("Sorry cannot allow widrawing negative amount");
            }
            if (p_widrawalAmt > accBalance)
            {
                throw new Exception("Insufficient Balance");
            }
            accBalance = accBalance - p_widrawalAmt;            
            return accBalance;
        }

        public virtual double Deposit(int p_depositAmt)
        {
            if (p_depositAmt < 0)
            {
                throw new Exception("Sorry cannot accept negative amount");
            }
            accBalance = accBalance + p_depositAmt;
            return accBalance;
        }
    }
}
