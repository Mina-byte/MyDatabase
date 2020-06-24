using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemoApp.Models
{
    public class MyDatabaseDataAccessLayer
    {
        string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EmployeeDB;Data Source=DESKTOP-GN5T5KD\\SQLEXPRESS";
        //To View all employees details
        public IEnumerable<Employee> GetAllEmployees()
        {
            List<Employee> lstemployee = new List<Employee>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetAllEmployees", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Employee employee = new Employee();

                    employee.ID = Convert.ToInt32(rdr["EmployeeID"]);
                    employee.HireLevelName = rdr["HireLevelName"].ToString();
                    employee.HireDate = Convert.ToDateTime(rdr["HireDate"]);
                    employee.AddressID = Convert.ToInt32(rdr["AddressID"]);
                    employee.FirstName = rdr["FirstName"].ToString();
                    employee.MiddleName = rdr["MiddleName"].ToString();
                    employee.LastName = rdr["LastName"].ToString();
                    employee.DOB = Convert.ToDateTime(rdr["DOB"]);
                    employee.Gender = rdr["Gender"].ToString();
                    employee.SIN = rdr["SIN"].ToString();

                    lstemployee.Add(employee);
                }
                con.Close();
            }
            return lstemployee;
        }


        //To Add new employee record
        public void AddEmployee(Employee employee)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@HireLevelName", employee.HireLevelName);
                cmd.Parameters.AddWithValue("HireDate", employee.HireDate);
                cmd.Parameters.AddWithValue("AddressID", employee.AddressID);
                cmd.Parameters.AddWithValue("FirstName", employee.FirstName);
                cmd.Parameters.AddWithValue("MiddleName", employee.MiddleName);
                cmd.Parameters.AddWithValue("LastName", employee.LastName);
                cmd.Parameters.AddWithValue("DOB", employee.DOB);
                cmd.Parameters.AddWithValue("Gender", employee.Gender);
                cmd.Parameters.AddWithValue("SIN", employee.SIN);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //To Update the records of a particular employee
        public void UpdateEmployee(Employee employee)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@HireLevelName", employee.HireLevelName);
                cmd.Parameters.AddWithValue("HireDate", employee.HireDate);
                cmd.Parameters.AddWithValue("AddressID", employee.AddressID);
                cmd.Parameters.AddWithValue("FirstName", employee.FirstName);
                cmd.Parameters.AddWithValue("MiddleName", employee.MiddleName);
                cmd.Parameters.AddWithValue("LastName", employee.LastName);
                cmd.Parameters.AddWithValue("DOB", employee.DOB);
                cmd.Parameters.AddWithValue("Gender", employee.Gender);
                cmd.Parameters.AddWithValue("SIN", employee.SIN);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //Get the details of a particular employee
        public Employee getEmployeeData(int? id)
        {
            Employee employee = new Employee();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM tblEmployee WHERE EmployeeID= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    employee.ID = Convert.ToInt32(rdr["EmployeeID"]);
                    employee.HireLevelName = rdr["HireLevelName"].ToString();
                    employee.HireDate = Convert.ToDateTime(rdr["HireDate"]);
                    employee.AddressID = Convert.ToInt32(rdr["AddressID"]);
                    employee.FirstName = rdr["FirstName"].ToString();
                    employee.MiddleName = rdr["MiddleName"].ToString();
                    employee.LastName = rdr["LastName"].ToString();
                    employee.DOB = Convert.ToDateTime(rdr["DOB"]);
                    employee.Gender = rdr["Gender"].ToString();
                    employee.SIN = rdr["SIN"].ToString();
                }
            }
            return employee;
        }

        //To Delete the record on a particular employee
        public void DeleteEmployee(int? id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeleteEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmpId", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
