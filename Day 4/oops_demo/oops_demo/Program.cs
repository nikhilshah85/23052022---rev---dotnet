using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A new account/object for Micheal is created 

            Accounts accObj = new Accounts(); //we instanciate a new object from a class
            accObj.accNo = 101;
            accObj.accName = "Micheal";
            accObj.accEmail = "micheal@gmail.com";
            accObj.accBalance = 6000;
            accObj.accIsActive = true;

            Console.WriteLine("Account Number " + accObj.accNo);
            Console.WriteLine("Account Name " + accObj.accName);
            Console.WriteLine("Account Email " + accObj.accEmail);
            Console.WriteLine("Account Balance " + accObj.accBalance);
            Console.WriteLine("Account Is Active " + accObj.accIsActive);

            accObj.Widraw(900);
            //6000 - 900 = 5100



            Console.WriteLine("Account Balance " + accObj.accBalance);



            #region without encapsulation

            //Accounts accKaramo = new Accounts();
            ////accKaramo.v_accNo = 101;
            ////accKaramo.v_accName = "Katamo";
            ////accKaramo.v_accBalance = 9000;

            accKaramo.AccountNumber = 101;

            #endregion


        }
    }
}
