using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First For loop
            //For loop, you use for loop when you are aware how many iterations you wish to perform
            //eg. print Hello for 20 times

            //for(int i = 1; i <= 80; i++)
            //{
            //    Console.WriteLine("Hello " + i);
            //}
            #endregion

            #region Print a Table loop

            //Console.WriteLine("Enter a number to wish to see the table for");
            //int tableToPrint =Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine(tableToPrint + " x " + i + " = " + (tableToPrint * i));
            //}
            #endregion

            #region First While loop
            //int num = 0;
            //while(num < 100)
            //{
            //    Console.WriteLine("Enter a Number");
            //  num =   Convert.ToInt32(Console.ReadLine());
            //}
            #endregion

            #region Second while loop
            //Console.WriteLine("Tell something about you, Say Thank You once done");
            //string userinfo = "";
            //while(userinfo != "Thank You")
            //{
            //    userinfo = Console.ReadLine();
            //}
            #endregion

            #region Number entries
            int no = 1;
            int addition = 0;
            int evenNumber = 0;
            int oddNumbers = 0;
            int countEnteries = 0;
            while (no != 0)
            {
                Console.WriteLine("Enter a number");
                no = Convert.ToInt32(Console.ReadLine());
                addition = addition + no;
                countEnteries++;
                if (no % 2 == 0)
                {
                    evenNumber++;
                }
                else
                {
                    oddNumbers++;
                }
            }
            Console.Clear();
            Console.WriteLine("Total Entries " + countEnteries);
            Console.WriteLine("Addition of all the numbers is " + addition);
            Console.WriteLine("Total Even Numbers " + evenNumber);
            Console.WriteLine("Total Odd Numbers " + oddNumbers);
            #endregion
        }
    }
}





