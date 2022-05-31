using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using employeeLIB;
namespace employeeSolutionConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dev = new Developer(101, "Nikhil", 100, true, Designation.Manager);

            Console.WriteLine(dev.empName);
            Console.WriteLine(dev.empSalary);
        }
    }
}
