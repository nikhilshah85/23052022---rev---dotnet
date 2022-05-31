using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_enum_params_polymphism
{
    internal class HigherCalculation : Calculations
    {
        //public static double Add(double num1, double num2)
        //{
        //    return Add(num1, num2);
        //}

        public static int Add(int num1, int num2, params int[] morenumbers)
        {
            int temp = 0;
            for (int i = 0; i < morenumbers.Length; i++)
            {
                temp = temp + morenumbers[i];
            }
            return num1 + num2 + temp;
        }
    }
}
