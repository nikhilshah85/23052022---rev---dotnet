using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_enum_params_polymphism
{
    public enum VehicleType
    {
        MotorBike,
        Car,
        Truck,
        Plane,
        Chopper
    }



    internal class Calculations
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        public static int Add(int num1, int num2, int num3, int num4)
        {
            return num1 + num2 + num3 + num4;
        }
        public static int Add(int num1, int num2, int num3, int num4, int num5)
        {
            return num1 + num2 + num3 + num4 + num5;
        }
        public static int Add(int num1, int num2, int num3, int num4, int num5, int num6)
        {
            return num1 + num2 + num3 + num4 + num5 + num6;
        }


        public static string Add(string num1, string num2)
        {
            return num1 + " " + num2;
        }

        public static string BuyNewVehicleInsurance(VehicleType vehicleType)
        {
            return "Vehicle is now insured";
        }
            
    }
}
