using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingSolution
{
    internal class Investment : Accounts
    {
        public override double Widraw(int w_amount)
        {
            if (w_amount > (accBalance * 70 / 100))
            {
                return 0;
            }
            return base.Widraw(w_amount);
        }
    }
}
