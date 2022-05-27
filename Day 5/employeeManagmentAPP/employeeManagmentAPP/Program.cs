using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeManagmentAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Before Lunch Code
            //one way to create an object, very old way, not convinient at all, prone to repetations, miss a property
            //Employee m = new Employee();
            //m.empFirstName = "Nikhil";
            //m.empLastName = "Shah";
            //m.empNo = 101;
            //m.empPay = 6000;
            //m.empLeaves = 20;
            //m.empAddress = "Mumbai, India";
            //m.empEmail = "nikhilshah@gmail.com";
            //m.empPhone = 0349587;

            //  Employee m = new Employee()
            //  {
            //      empNo = 101,
            //      empFirstName = "Nikhil",
            //      empLastName = "Shah",
            //      empAddress = "Mumbai, India",
            //      empEmail = "nikhilshah.net@hotmail.com",
            //      empLeaves = 20,
            //      empPay = 2000,
            //      empPhone = 304570
            //  };


            //  Console.WriteLine("Phone Number : "  + m.empPhone);
            //  Console.WriteLine("Address : " + m.empAddress);

            //  //m.modifyEmployeeDetails("Nik","Shaw ","nikki@gmail.com","Carters,West Mumbai, India", 98985632);
            ////  m.modifyEmployeeDetails(p_phone: 365698, p_firstName: "nikki", p_Address: "New Town, SGN", p_emailAdd: "nikki@somewhere.com",p_lastName:"Shaw");
            //  Console.WriteLine("Phone Number : " + m.empPhone);
            //  Console.WriteLine("Address : " + m.empAddress);

            //  m.modifyEmployeeDetails(p_Address: "Old Street, HKN");

            //  Console.WriteLine(m.empFirstName);

            #endregion

            // Employee employee = new Employee(); //this is not a good thing
            //we should never create an object of this class

            Manager manObj = new Manager() { empLeaves = 20 };
            Developer dev = new Developer() { empLeaves = 20};
            HR ehr = new HR() { empLeaves = 20 };


            Console.WriteLine(manObj.ApplyLeaves(11));
            Console.WriteLine(dev.ApplyLeaves(11));
            Console.WriteLine(ehr.ApplyLeaves(11));

            



           

         
        }
    }
}







