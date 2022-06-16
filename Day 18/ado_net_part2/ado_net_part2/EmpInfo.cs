using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ado_net_part2
{
    internal class EmpInfo
    {
        SqlConnection con = new SqlConnection("server=WIN8\\NIKHILINSTANCE;database=employeeManagementDB;integrated security=true");


        #region Insert Employee and Department
        //public string AddNewEmployee()
        //{
        //    SqlCommand cmdAddNewEmployee = new SqlCommand("insert into empInfo values(21,'Mary','HR',500,1,20)", con);
        //    con.Open();
        //    cmdAddNewEmployee.ExecuteNonQuery();
        //    con.Close();
        //    return "Employee Added Successfully";
        //}

        //public string AddNewDept()
        //{
        //    SqlCommand cmdDept = new SqlCommand("insert into deptInfo values(90,'Sales','Paris','sales@rev.com')",con);
        //    con.Open();
        //    cmdDept.ExecuteNonQuery();
        //    con.Close();
        //    return "Dept Added";
        //}
        #endregion

        #region delete employee
        public string DeleteEmployee()
        {
            SqlCommand cmdDelete = new SqlCommand("delete from empInfo where empNo=21",con);
            con.Open();
            cmdDelete.ExecuteNonQuery();
            con.Close();
            return "Employee Deleted Successfully";
        }
        #endregion

        #region Update Employee
        public string updateEmployee()
        {
            SqlCommand cmd = new SqlCommand("update empInfo set empSalary =9000", con);
            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
            return "Employee Updated";
        }
        #endregion

        #region Count Employee
        public int CountEmployee()
        {
            SqlCommand cmd = new SqlCommand("select count(empNo) from empInfo", con);
            con.Open();
            int total = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return total;
        }
        #endregion

        #region Select Employee
        //public void ViewEmployee()
        //{
        //    SqlCommand cmd = new SqlCommand("select * from empInfo where empNo=3", con);
        //    con.Open();

        //    SqlDataReader rd = cmd.ExecuteReader();

        //    if (rd.Read())
        //    {
        //        Console.WriteLine(rd[0]);
        //        Console.WriteLine(rd[1]);
        //        Console.WriteLine(rd[2]);
        //        Console.WriteLine(rd[3]);
        //        Console.WriteLine(rd[4]);
        //    }

        //    con.Close();
        //}
        #endregion
    }
}
