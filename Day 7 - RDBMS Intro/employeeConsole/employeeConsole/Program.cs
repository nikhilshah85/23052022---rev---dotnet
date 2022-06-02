using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using employeeLIB;
namespace employeeConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Exception Demo 1
            //try
            //{
            //    var empObj = new Employee(101, "Nikhil", "Sales", 8000, 10);
            //    Console.WriteLine(empObj.DivideNumber(10,0));
            //}
            //catch(Exception es)
            //{
            //    Console.WriteLine(es.Message);
            //}
            //finally
            //{
            //    //this is an optional block
            //    //also a neutral block for try / catch.
            //    //code written here will be be executed irrecptive of success or failure
            //    //this block is used to clear the reference, like close the file, close database connection etc
            //    Console.WriteLine("Thank you !!");
            //}
            #endregion


            try
            {
                var empObj2 = new Employee(101, "Justin", "Developer", 7000, 10);

                Console.WriteLine("Enter Number of days for for leave");
                int leaveDays = Convert.ToInt32(Console.ReadLine());

               bool result =  empObj2.Applyleaves(leaveDays);
                Console.WriteLine("Leaves Approved, remaining balance leaves are " + empObj2.empAvailableLeaves);

                empObj2.DivideNumber(20, 0);


            }
            catch(FormatException fc)
            {
                Console.WriteLine(fc.Message);
                Console.WriteLine("Please enter only Numeric value");
            }
            catch(DivideByZeroException dv)
            {
                Console.WriteLine(dv.Message);
            }
            catch (Exception es)
            {

                Console.WriteLine(es.Message);
            }





}
    }
}
