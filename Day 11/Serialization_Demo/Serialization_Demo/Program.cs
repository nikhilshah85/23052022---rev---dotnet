using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

namespace Serialization_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Binary Serialization
            //Employee employee = new Employee();

            //Console.WriteLine("Enter Employee No");
            //employee.empNo =Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Employee Name");
            //employee.empName = Console.ReadLine();

            //Console.WriteLine("Enter Employee Designation");
            //employee.empDesigantion = Console.ReadLine();

            //Console.WriteLine("Enter Employee Salary");
            //employee.empSalary = Convert.ToDouble(Console.ReadLine());
            ////employee.empSalary = Convert.ToDouble("1234.89");                

            //Console.WriteLine("Enter Employee Is Permenant");
            //employee.empIsPermenant = true;

            //Console.WriteLine("Enter Employee Available Leaves");
            //employee.empAvailableLeaves = 15;


            //FileStream fs = new FileStream(@"C:\Users\hp\Desktop\Employee\" + employee.empNo + ".txt", FileMode.Create, FileAccess.Write);
            //BinaryFormatter formatter = new BinaryFormatter();
            //formatter.Serialize(fs, employee);
            //fs.Close();
            //Console.WriteLine("Object Saved Successfully");
            #endregion

            #region Binary Deserialization 

            //Console.WriteLine("Enter employee number : ");
            //int no = Convert.ToInt32(Console.ReadLine());

            //FileStream readObj = new FileStream(@"C:\Users\hp\Desktop\Employee\" + no + ".txt", FileMode.Open, FileAccess.Read);

            //BinaryFormatter bfDeserialize = new BinaryFormatter();
            //Employee empDetails = (Employee)bfDeserialize.Deserialize(readObj);

            //// I have not created a new employee objet
            //Console.WriteLine("Employee Number : " + empDetails.empNo);
            //Console.WriteLine("Employee Name : " + empDetails.empName);
            //Console.WriteLine("Employee Designation : " + empDetails.empDesigantion);
            //Console.WriteLine("Employee Salary : " + empDetails.empSalary);
            //Console.WriteLine("Employee Is Permenant " + empDetails.empIsPermenant);
            //Console.WriteLine("Employee Available Leaves : " + empDetails.empAvailableLeaves);

            //readObj.Close();

            #endregion

            #region XML Serialization

            //Employee employee = new Employee();

            //Console.WriteLine("Enter Employee No");
            //employee.empNo = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Employee Name");
            //employee.empName = Console.ReadLine();

            //Console.WriteLine("Enter Employee Designation");
            //employee.empDesigantion = Console.ReadLine();

            //Console.WriteLine("Enter Employee Salary");
            //employee.empSalary = Convert.ToDouble(Console.ReadLine());
            ////employee.empSalary = Convert.ToDouble("1234.89");                

            //Console.WriteLine("Enter Employee Is Permenant");
            //employee.empIsPermenant = true;

            //Console.WriteLine("Enter Employee Available Leaves");
            //employee.empAvailableLeaves = 15;

            //FileStream fs = new FileStream(@"C:\Users\hp\Desktop\Employee\" + employee.empNo + ".xml", FileMode.Create, FileAccess.Write);

            //XmlSerializer xs = new XmlSerializer(typeof(Employee));

            //xs.Serialize(fs, employee);
            //fs.Close();
            //Console.WriteLine("Object Saved to " + employee.empNo + " File");

            #endregion

            #region XML Deserialization
            //Employee empDetails;
            //Console.WriteLine("Enter Employee Number");
            //int no = Convert.ToInt32(Console.ReadLine());

            //FileStream myFile = new FileStream(@"C:\Users\hp\Desktop\Employee\" + no + ".xml", FileMode.Open, FileAccess.Read);

            //XmlSerializer xs = new XmlSerializer(typeof(Employee));

            //empDetails = (Employee)xs.Deserialize(myFile);

            //Console.WriteLine("Employee Number : " + empDetails.empNo);
            //Console.WriteLine("Employee Name : " + empDetails.empName);
            //Console.WriteLine("Employee Designation : " + empDetails.empDesigantion);
            //Console.WriteLine("Employee Salary : " + empDetails.empSalary);
            //Console.WriteLine("Employee Is Permenant " + empDetails.empIsPermenant);
            //Console.WriteLine("Employee Available Leaves : " + empDetails.empAvailableLeaves);

            //myFile.Close();

            #endregion

            Employee employee = new Employee();

            Console.WriteLine("Enter Employee No");
            employee.empNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name");
            employee.empName = Console.ReadLine();

            Console.WriteLine("Enter Employee Designation");
            employee.empDesigantion = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary");
            employee.empSalary = Convert.ToDouble(Console.ReadLine());
            //employee.empSalary = Convert.ToDouble("1234.89");                

            Console.WriteLine("Enter Employee Is Permenant");
            employee.empIsPermenant = true;

            Console.WriteLine("Enter Employee Available Leaves");
            employee.empAvailableLeaves = 15;

            FileStream fs = new FileStream(@"C:\Users\hp\Desktop\Employee\" + employee.empNo + ".xml", FileMode.Create, FileAccess.Write);


            SoapFormatter sp = new SoapFormatter();

            sp.Serialize(fs, employee);
            fs.Close();
            Console.WriteLine("Employee Save to " + employee.empNo + " File");

        }
    }
}
