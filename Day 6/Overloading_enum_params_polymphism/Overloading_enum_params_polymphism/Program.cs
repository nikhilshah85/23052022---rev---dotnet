using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_enum_params_polymphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Method Overloading and Params
            //Calculations cal = new Calculations();
            //Console.WriteLine(cal.Add(20, 30));

            //Console.WriteLine(Calculations.Add(30, 20));

            //Console.WriteLine(Calculations.Add(30, 40, 50));
            //Console.WriteLine(Calculations.Add("one", "ten"));
            //Console.WriteLine(Calculations.Add(1, 2, 3, 8, 9, 20));
            ////Console.WriteLine(HigherCalculation.Add(30.3, 60.9));


            ////string[] friends = new string[20];

            // Console.WriteLine(HigherCalculation.Add(1,2,2,9,6,3,6,5,1,4,5,45,12,5,5,5,6,34,6,56,547,67,42672,457,546,547,645));
            #endregion

            //Console.WriteLine(Calculations.BuyNewVehicleInsurance(VehicleType.Chopper));

            var num1 = 10;
            var myName = "Nikhil";
            var isPermenant = true;
            var height = 5.6;
            var calObj = new Calculations();
            var higherCalObj = new HigherCalculation();

            var something = "";
            var age = 30.2;

            //compiler will assign the data type implicitly
            Console.WriteLine(num1.GetType());
            Console.WriteLine(myName.GetType());
            Console.WriteLine(calObj.GetType());

            var friends = new string[5];

            //rules for VAR

            //a. Once initilised, you cannot change the data type
            //var myage = 30;
            //myage = 40; //accepted
            //myage = "Fifty"; //not accepted, as you cannot change the data type

            //b. you can use var only as a variable, not as a parameter

            //c. u can have var only as a local variable not as global

            var test = "";
            Console.WriteLine(test.GetType());



            


            


        }
    }
}
