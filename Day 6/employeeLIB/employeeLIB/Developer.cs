using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeLIB
{
    public class Developer : Employee
    {
        //var devObj = new Developer();

        public Developer(int p_empNo, string p_empName, double p_empSalary, bool p_empIsPermenant, Designation p_empDesignation):base(p_empNo,p_empName,p_empSalary,p_empIsPermenant,p_empDesignation)
        {
            Console.WriteLine("Developer constructor is called");
        }
    }
}
