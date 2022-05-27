using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeManagmentAPP
{
    public abstract class Employee
    {
        

        public int empNo { get; set; }
        public string empFirstName { get; set; }
        public string empLastName { get; set; }
        public int empLeaves { get; set; }
        public string empEmail { get; set; }
        public string empAddress { get; set; }
        public double empPhone { get; set; }
        public double empPay { get; set; }
       public string name;
        public string modifyFirstName(string p_FirstName)
        {
            empFirstName = p_FirstName;     
            return "Changed done Successfully";
        }

        //Named parameter
        //optional parameter

        public string modifyEmployeeDetails(string p_firstName = "" , string p_lastName = "",string p_emailAdd="",string p_Address="",double p_phone =0)
        {
            empFirstName = p_firstName;
            empLastName = p_lastName;
            empEmail = p_emailAdd;
            empAddress = p_Address;
            empPhone = p_phone;
            return "Changes Saved Successfully";
        }

        public virtual string ApplyLeaves(int days)
        {
            if (days == 0 || days <0)
            {
                Console.WriteLine("Leave has to be minimul 1 day");
                return "";
            }
            else if(days > empLeaves)
            {
                Console.WriteLine("Not sufficient leave available.");
                return "";
            }
            empLeaves = empLeaves - days;
            return "Leave Approved, balance leave is now " + empLeaves;
        }

        


    }
}





