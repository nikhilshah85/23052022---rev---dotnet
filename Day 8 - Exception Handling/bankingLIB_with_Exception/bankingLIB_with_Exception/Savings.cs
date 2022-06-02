using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingLIB_with_Exception
{
    public class Savings : Accounts
    {

        public Savings(int p_accNo,string p_accName,double p_accBalance):base(p_accNo,p_accName, p_accBalance)
        {

        }

        public override double Widraw(int p_widrawalAmt)
        {
            if (p_widrawalAmt > 20000)
            {
                throw new Exception("Savings account is allowed an widrawal of max 20000");
            }
            return base.Widraw(p_widrawalAmt);
        }

        public override double Deposit(int p_depositAmt)
        {
            if (p_depositAmt > 50000)
            {
                throw new Exception("You can deposit max 50000 in a day");
            }
            return base.Deposit(p_depositAmt);
        }


    }
}
