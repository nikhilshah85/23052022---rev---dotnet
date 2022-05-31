using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeLIB
{

    public enum Designation
    {
        Developer,
        Manager,
        HR
    }

    public abstract class Employee
    {
        public int empNo { get; set; }
        public string empName { get; set; }
        public double empSalary { get; set; }
        public bool empIsPermenant { get; set; }
        public string empDesignation { get; set; }

        //Employee emp = new Employee();  //this means a new object is created in memory 
        //but it has no name, no empno etc... this should not be allowed

        //Parameterless constructor
        //if you do not create this, this is added by default by compiler
        //thats why it is also called as default constructor
        //u create this in  calls only when you want to initilize some variables values inside it, eg. connect to database
        //public Employee()
        //{

        //}

        public Employee(int p_empNo,string p_empName,double p_empSalary,bool p_empIsPermenant,Designation p_empDesignation)
        {
            empNo = p_empNo;
            empName = p_empName;
            empDesignation = p_empDesignation.ToString();
            empIsPermenant = p_empIsPermenant;
            empSalary = p_empSalary;

            Console.WriteLine("Employee Constructor is called");
        }





    }
}





