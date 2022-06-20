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
