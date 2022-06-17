using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace employeeManagementLIB
{
    public class Employee
    {
        public int empNo { get; set; }
        public string empName { get; set; }
        public string empDesigantion { get; set; }
        public int empSalary { get; set; }
        public int empDept { get; set; }


        SqlConnection con = new SqlConnection("server=WIN8\\NIKHILINSTANCE;database=employeeManagementDB;user id=sa;password=Password1234");


        public List<Employee> GetAllEmployees()
        {
            SqlCommand cmdAllEmployees = new SqlCommand("select * from empInfo order by empDesignation", con);
            con.Open();
            SqlDataReader readEmp = cmdAllEmployees.ExecuteReader(); //this is point to output of query (not table)
                                                                     //then u will ask it to point to next record
            List<Employee> empList = new List<Employee>();
            while (readEmp.Read())
            {
                empList.Add(new Employee()
                {
                    empNo = (int)readEmp[0],
                    empName = readEmp[1].ToString(),
                    empDesigantion = readEmp[2].ToString(),
                    empSalary =(int) readEmp[3],
                    empDept =(int) readEmp[4]
                });
            }
            readEmp.Close();
            con.Close();
            return empList;
        }

        public Employee SearchById(int p_empNo)
        {
            SqlCommand cmdSearchById = new SqlCommand("select * from empInfo where empNo=@eNo", con);
            cmdSearchById.Parameters.AddWithValue("@eNo", p_empNo);
            Employee empDetail = new Employee();
            con.Open();
             SqlDataReader readEmp = cmdSearchById.ExecuteReader();
            if (readEmp.Read())
            {
                empDetail.empNo = (int)readEmp[0];
                empDetail.empName = readEmp[1].ToString();
                empDetail.empDesigantion = readEmp[2].ToString();
                empDetail.empSalary = (int)readEmp[3];
                empDetail.empDept = (int)readEmp[4];
            }
            else
            {
                readEmp.Close();
                con.Close();
                throw new Exception("Employee Not Found");
            }
            readEmp.Close();
            con.Close();
            return empDetail;
        }

        public bool checkEmployeeExist(int p_empNo)
        {
            SqlCommand cmdCheck = new SqlCommand("select count(*) from empInfo where empNo = @eNo", con);
            cmdCheck.Parameters.AddWithValue("@eNo", p_empNo);

            con.Open();
            int count =(int) cmdCheck.ExecuteScalar();
            con.Close();
            if (count == 1)
            {
                return true;
            }
            return false;
        }

        public string AddEmployee(Employee p_empObj)
        {            
            SqlCommand cmdNewEmployee = new SqlCommand("insert into empInfo values(@eNo,@eName,@eDesignation,@eSal,@eDno)", con);
            cmdNewEmployee.Parameters.AddWithValue("@eNo", p_empObj.empNo);
            cmdNewEmployee.Parameters.AddWithValue("@eName", p_empObj.empName);
            cmdNewEmployee.Parameters.AddWithValue("@eDesignation", p_empObj.empDesigantion);
            cmdNewEmployee.Parameters.AddWithValue("@eSal", p_empObj.empSalary);
            cmdNewEmployee.Parameters.AddWithValue("@eDno", p_empObj.empDept);
            con.Open();
          int recordsAffected =  cmdNewEmployee.ExecuteNonQuery(); //this method returns number of records affected in datbase
            con.Close();
            return "Employee Added Successfully";
        }

        public string DeleteEmployee(int p_empNo)
        {
            SqlCommand cmdDeleteEmployee = new SqlCommand("delete from empInfo where empNo =@eNo", con);
            cmdDeleteEmployee.Parameters.AddWithValue("@eNo", p_empNo);
            con.Open();
            int recordAffected = cmdDeleteEmployee.ExecuteNonQuery();
            con.Close();

            if (recordAffected == 0)
            {
                return "Employee Not Found, and thus we could not delete";
            }
            return "Employee Deleted Successfully";


        }

        public string UpdateEmployee(Employee p_empObj)
        {
            SqlCommand cmdUpdateEmployee = new SqlCommand("update empInfo set empName=@eName,empDesignation=@eDesignation,empSalary=@eSal,empDeptNo=@eDno where empNo=@eNo", con);
            cmdUpdateEmployee.Parameters.AddWithValue("@eNo", p_empObj.empNo);
            cmdUpdateEmployee.Parameters.AddWithValue("@eName", p_empObj.empName);
            cmdUpdateEmployee.Parameters.AddWithValue("@eDesignation", p_empObj.empDesigantion);
            cmdUpdateEmployee.Parameters.AddWithValue("@eSal", p_empObj.empSalary);
            cmdUpdateEmployee.Parameters.AddWithValue("@eDno", p_empObj.empDept);

            con.Open();
            int updateResult = cmdUpdateEmployee.ExecuteNonQuery();
            con.Close();

            if (updateResult > 0)
            {
                return "Employee Updated Successfully !!";
            }
            return "Employee Not Found";

        }

    }
}
