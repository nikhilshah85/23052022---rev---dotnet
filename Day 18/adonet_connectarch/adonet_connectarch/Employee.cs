using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace adonet_connectarch
{
    internal class Employee
    {
        public int empNo { get; set; }
        public string empName { get; set; }
        public string empDesignation { get; set; }
        public double empSalary { get; set; }
        public bool empIsActive { get; set; }
        public int empDeptNo { get; set; }

        public Employee GetEmployee(int p_empNo)
        {

            SqlConnection conn = new SqlConnection(@"server=WIN8\NIKHILINSTANCE;database=employeeManagementDB;integrated security=true");
            SqlCommand cmdGetEmp = new SqlCommand("select * from empInfo where empNo=@eNo",conn);
            cmdGetEmp.Parameters.AddWithValue("@eNo", p_empNo);

            conn.Open();
                SqlDataReader readRecord = cmdGetEmp.ExecuteReader(); //store the output in read variable
            Employee emp = new Employee();
            if (readRecord.Read()) //start reading please
            {                
                emp.empNo = Convert.ToInt32(readRecord[0]);
                emp.empName = Convert.ToString(readRecord[1]);
                emp.empDesignation = Convert.ToString(readRecord[2]);
                emp.empSalary = Convert.ToDouble(readRecord[3]);
                emp.empIsActive = Convert.ToBoolean(readRecord[4]);
                emp.empDeptNo = Convert.ToInt32(readRecord[5]);
            }
            else
            {
                throw new Exception("Record Not Found");
            }
            readRecord.Close();
            conn.Close();

            return emp;

        


        }

    }
}
