using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bankingLIB_with_Exception;
namespace bankingSolutionConsole_exception
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool continueBanking = true;

            while (continueBanking)
            {
                try
                {
                    Console.WriteLine("1. Create new Account");
                    Console.WriteLine("2. Widraw");
                    Console.WriteLine("3. Deposit");
                    Console.WriteLine("4. Check Balance");
                    Console.WriteLine("5. Exit");

                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {

                        case 1:

                            Console.WriteLine("Enter New Account No");
                            int v_newAccNo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter New Account Name");
                            string v_newAccName = Console.ReadLine();
                            Console.WriteLine("Enter new Account Balance");
                            double v_newAccBalance = Convert.ToDouble(Console.ReadLine());
                            var accObj = new Savings(v_newAccNo, v_newAccName, v_newAccBalance);
                            break;
                        case 2:
                            Console.WriteLine("Enter the Amout you wish to widraw");
                            int v_widrawmaount = Convert.ToInt32(Console.ReadLine());
                            var savObj = new Savings(101, "test", 8000);
                            savObj.Widraw(v_widrawmaount);
                            break;
                        case 3:
                            Console.WriteLine("Enter the Amount you wish to deposit");
                            int v_depositAmount = Convert.ToInt32(Console.ReadLine());
                            var savObj2 = new Savings(102, "test 2", 20000);
                            savObj2.Deposit(v_depositAmount);
                            break;
                        case 4:
                            var savObj3 = new Savings(102, "test 2", 5000);
                            Console.WriteLine("Avaialbel balance is : " + savObj3.accBalance);
                            break;
                        case 5:
                            continueBanking = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (Exception es)
                {
                    Console.WriteLine(es.Message);
                    Console.ReadLine();
                    Console.Clear();
                }
                finally
                {
                    Console.WriteLine("Thank you for banking");
                }


            }




        }
    }

}