using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Accounts acc = new Accounts();

            Savings sav = new Savings() { accBalance = 80000 };
            Checking chk = new Checking() { accBalance = 80000 };
            Investment invst = new Investment() { accBalance = 80000 };

            Console.WriteLine("Savings : " + sav.Widraw(55000));
            Console.WriteLine("Checking : " + chk.Widraw(55000));
            Console.WriteLine("Investment : " + invst.Widraw(55000));

        }
    }
}
