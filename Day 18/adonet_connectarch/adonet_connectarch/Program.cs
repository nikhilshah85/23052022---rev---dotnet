using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace adonet_connectarch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee empObj = new Employee();


            try
            {
                Console.WriteLine("Enter Employee Number");
                int v_empNo = Convert.ToInt32(Console.ReadLine());
                Employee emp = empObj.GetEmployee(v_empNo);

                Console.WriteLine(emp.empNo);
                Console.WriteLine(emp.empName);
                Console.WriteLine(emp.empDesignation);
                Console.WriteLine(emp.empSalary);
                Console.WriteLine(emp.empIsActive);
                Console.WriteLine(emp.empDeptNo);
            }
            catch(Exception es)
            {
                Console.WriteLine(es.Message);
            }
                
        }
    }
}
