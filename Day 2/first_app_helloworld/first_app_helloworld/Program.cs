using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_app_helloworld
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            #region First Program
            //Console.WriteLine("Hello and Welcome to my first line of code");          

            //Console.WriteLine("Please Enter your name");
            //string guestName = Console.ReadLine();

            //Console.WriteLine("Thank you " + guestName);
            //Console.ReadLine();
            #endregion

            #region Data Types

            //int favNum1 = 10;
            //string firstName = "Nikhil";
            //bool isPermenantEmployee = true;
            //double height = 6.2;

            //Console.WriteLine("Enter First Number");
            //int firstNum = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Second Number");
            //int secondNum = Convert.ToInt32(Console.ReadLine());

            //int addition = firstNum + secondNum;
            //int subtraction = firstNum - secondNum;
            //int multiplication = firstNum * secondNum;
            //int division = firstNum / secondNum;

            //Console.WriteLine("Addition of your numbers are : " + addition);
            //Console.WriteLine("Subtraction of your numbers are : " + subtraction);
            //Console.WriteLine("Multiplication of your numbers are : " + multiplication);
            //Console.WriteLine("Division of your numbers are : " + division);




            #endregion

            #region conditions

            #region Simple if Condition 
            //Console.WriteLine("Please enter a number");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num >= 0)
            //{
            //    Console.WriteLine("Good and a Positive number");
            //}
            //else
            //{
            //    Console.WriteLine("Bad as it is a negative number");
            //} 
            #endregion

            //Console.WriteLine("Enter a number");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num < 0)
            //{
            //    Console.WriteLine("Bad Number");
            //}
            //else if(num >0 && num <= 10)
            //{
            //    Console.WriteLine("Good Number");
            //}
            //else if(num > 10 && num <= 20)
            //{
            //    Console.WriteLine("Very good number");

            //}
            //else if(num > 20 && num <= 30)
            //{
            //    Console.WriteLine("Excellent Number");
            //}
            //else
            //{
            //    Console.WriteLine("Number way to be more than excellent");
            //}

            #endregion

            #region Login
            //Console.WriteLine(" !! ~~~~~~~~~~~~~ Welcome to Banking ~~~~~~~~~~~~~~ !! ");
            //Console.WriteLine("Enter User Name");
            //string username = Console.ReadLine();

            //Console.WriteLine("Enter Password");
            //string password = Console.ReadLine();

            //if (username == "Nikhil" && password == "pass@word")
            //{
            //    Console.WriteLine("Login Successful !!");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Credentials");
            //}
            #endregion

            #region Switch Case
            //Console.WriteLine("!!!! ~~~~~~~~~~~~~~~~~~~ Welcome to Banking ~~~~~~~~~~~~~~~~~~~~~ !!!!");
            //Console.WriteLine("1. Open a new Account");
            //Console.WriteLine("2. Widraw ");
            //Console.WriteLine("3. Deposit");
            //Console.WriteLine("4. Wire Funds");
            //Console.WriteLine("5. View past transactions");
            //Console.WriteLine("6. Exit");

            //int choice =Convert.ToInt32(Console.ReadLine());

            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine("Provide details and documents to open a new account");
            //        Console.WriteLine("Code Coming up soon");
            //        break;
            //     case 2:
            //        Console.WriteLine("Enter Amount to widraw");
            //        int amount = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Widrawal of " + amount + "$ is successful");
            //        break;
            //     case 3:
            //        Console.WriteLine("Enter Amount to deposit");
            //        int deposit = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Deposit of amount " + deposit + "$ is successful");
            //        break;
            //    case 4:
            //        Console.WriteLine("Wire funds processing............");
            //        Console.WriteLine("Funds transfered");
            //        break;
            //    case 5:
            //        Console.WriteLine("Transaction History");
            //        Console.WriteLine("transaction 1");
            //        Console.WriteLine("transaction 2");
            //        Console.WriteLine("transaction 3");
            //        Console.WriteLine("transaction 4");
            //        Console.WriteLine("transaction 5");
            //        break;
            //    case 6:
            //        Console.WriteLine("Thank you for banking with us");
            //        break;
            //    default:
            //        Console.WriteLine("Sorry you choosed wrong option");
            //        break;
            //}
            #endregion
        }
    }
}
