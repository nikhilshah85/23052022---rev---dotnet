using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Demo
{
    [Serializable] //this is called as an Attribute, which is an instruction to compiler and runtime
                  
    internal class Employee
    {
        public int empNo { get; set; }
        public string empName { get; set; }
        public string empDesigantion { get; set; }
        public double empSalary { get; set; }
        public bool empIsPermenant { get; set; }
        public int empAvailableLeaves { get; set; }

        public int ApplyLeave(int p_no_ofDays)
        {
            empAvailableLeaves = empAvailableLeaves - p_no_ofDays;
            return empAvailableLeaves;
        }

    }
}
