using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingSolution
{
    internal class Savings : Accounts
    {
        public override double Widraw(int w_amount)
        {
            if (w_amount > 20000)
            {
                //throw an exception
                return 0;
            }
            return base.Widraw(w_amount);
        }

    }
}
