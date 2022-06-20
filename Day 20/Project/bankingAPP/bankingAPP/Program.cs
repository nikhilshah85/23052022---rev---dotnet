using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bankingLIB;
namespace bankingAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variables and Objects
            Security secObj = new Security();
            Transactions trObj = new Transactions();
            #endregion


            Console.WriteLine("Welcome to Banking");
            Console.WriteLine("Select Login Type");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Customer");

            int userType =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter User Name");
            string uName = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string pwd = Console.ReadLine();



            if (userType == 1)
            {
                string isValidUser = secObj.Login(uName, pwd, UserType.Admin);               
                if (isValidUser.Contains("Successful"))
                {
                    //show the admin menu here

                    //in the case 5 : Transfer
                    Console.WriteLine("Enter From Account Number ");
                    int v_fromAcc =Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter To Account Number ");
                    int v_ToAcc = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Amount To Transfer ");
                    int v_Amount = Convert.ToInt32(Console.ReadLine());

                 string transferResult=   trObj.Transfer(v_fromAcc, v_ToAcc, v_Amount, UserType.Admin);
                    Console.WriteLine(transferResult);
                }
                else
                {
                    Console.WriteLine(isValidUser);
                }

     
            }
            else
            {
                string isValidUser = secObj.Login(uName, pwd, UserType.User);
                if (isValidUser.Contains("Successful"))
                {
                    //show the user menu here
                }
                else
                {
                    Console.WriteLine(isValidUser);
                }

            }


        }
    }
}
