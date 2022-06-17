using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using employeeManagementLIB;
namespace employeeManagementAPP
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Employee Management APP");
            #region Ask user credentials and check login
            Console.WriteLine("Enter User Name");
            string v_uName = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string v_pwd = Console.ReadLine();

            Security secObj = new Security();
            bool loginResult = secObj.CheckUserCredentials(v_uName, v_pwd);
            bool continueAPP = false;
            if (loginResult == true)
            {
                continueAPP = true;

            }
            else
            {
                Console.WriteLine("Invalid Credentials Please try again");
            }
            #endregion


            while (continueAPP == true)
            {
                Console.Clear();
                #region Menu
                Console.WriteLine("Welcome to Employee Management ");
                Console.WriteLine("1. View All Employees");
                Console.WriteLine("2. Search Employee By ID");
                Console.WriteLine("3. Add New Employee");
                Console.WriteLine("4. Edit Employee");
                Console.WriteLine("5. Delete Employee");
                Console.WriteLine("6. Logout");
                #endregion

                #region Common variables for multiple cases initilised to defaults
                int choice = Convert.ToInt32(Console.ReadLine());
                Employee empObj = new Employee(); //used for calling methods from library
                Employee newEmp = new Employee(); //used for adding and updateing the record
                bool check = false;
                #endregion

                #region Switch case
                switch (choice)
                {
                    case 1:
                        //call method from lib
                        break;
                    case 2:
                        //call the method from lib
                        break;

                    #region Case 3 :Add New Employee
                    case 3:
                                              
                        Console.WriteLine("Enter Employee Number");
                        newEmp.empNo = Convert.ToInt32(Console.ReadLine());

                        check = empObj.checkEmployeeExist(newEmp.empNo);
                        if (!check)
                        {
                            Console.WriteLine("Enter Employee Name");
                            newEmp.empName = Console.ReadLine();
                            Console.WriteLine("Enter Employee Salary");
                            newEmp.empSalary = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Employee Designation");
                            newEmp.empDesigantion = Console.ReadLine();
                            Console.WriteLine("Enter Employee Department Number");
                            newEmp.empDept = Convert.ToInt32(Console.ReadLine());

                            string result = empObj.AddEmployee(newEmp);
                            Console.WriteLine(result);
                        }
                        else
                        {
                            Console.WriteLine("Duplicate Employee Number");
                        }
                        break;
                    #endregion

                    #region Case 4: Update / Edit
                    case 4:
                                              

                        Console.WriteLine("Enter Employee Number");
                        newEmp.empNo = Convert.ToInt32(Console.ReadLine());

                        check = empObj.checkEmployeeExist(newEmp.empNo);
                        if (check)
                        {
                            Console.WriteLine("Enter Employee Name");
                            newEmp.empName = Console.ReadLine();
                            Console.WriteLine("Enter Employee Salary");
                            newEmp.empSalary = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Employee Designation");
                            newEmp.empDesigantion = Console.ReadLine();
                            Console.WriteLine("Enter Employee Department Number");
                            newEmp.empDept = Convert.ToInt32(Console.ReadLine());
                            string updateResult = empObj.UpdateEmployee(newEmp);
                            Console.WriteLine(updateResult);
                        }
                        else
                        {
                            Console.WriteLine("Employee Not Found in System, please try again");
                        }
                        break;
                    #endregion

                    #region Case 5 : Delete
                    case 5:
                        Console.WriteLine("Enter Employee Number to be deleted");
                        int v_empNo_toDelete = Convert.ToInt32(Console.ReadLine());
                    string deleteResult  =    empObj.DeleteEmployee(v_empNo_toDelete);
                        Console.WriteLine(deleteResult);

                        break;
                    #endregion

                    #region Case 6 : Logout
                    case 6:
                        continueAPP = false;
                        break;
                    #endregion

                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
                #endregion
                Console.ReadLine();
      }

            
           




        }
    }
}
