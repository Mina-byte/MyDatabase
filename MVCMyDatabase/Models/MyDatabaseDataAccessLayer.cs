using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMyDatabase.Models
{
    public class MyDatabaseDataAccessLayer
    {
        string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=MyDatabase;Data Source=DESKTOP-GN5T5KD\\SQLEXPRESS";
        //To View all employees details
        public IEnumerable<MyDatabase> GetAllEmployees()
        {
            List<MyDatabase> lstemployee = new List<MyDatabase>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllEmployees", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    MyDatabase employee = new MyDatabase();

                    //try
                    //{

                        employee.ID = Convert.ToInt32(rdr["EmployeeID"]);
                        //employee.HireLevelName = rdr["HireLevelName"].ToString();
                        employee.HireDate = Convert.ToDateTime(rdr["HireDate"]);
                        employee.AddressID = Convert.ToInt32(rdr["AddressID"]);
                        employee.FirstName = rdr["FirstName"].ToString();
                        employee.MiddleName = rdr["MiddleName"].ToString();
                        employee.LastName = rdr["LastName"].ToString();
                        employee.DOB = Convert.ToDateTime(rdr["DOB"]);
                        employee.Gender = rdr["Gender"].ToString();
                        employee.SIN = rdr["SIN"].ToString();   
                    /*}
                    catch
                    {
                        Console.WriteLine("No Information Found.");
                    }*/
                    

                    lstemployee.Add(employee);
                }
                con.Close();
            }
            return lstemployee;
        }


        //To Add new employee record
        public void InsertEmployee(MyDatabase employee)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("InsertEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@HireLevelName", employee.HireLevelName);
                cmd.Parameters.AddWithValue("@HireDate", employee.HireDate);
                cmd.Parameters.AddWithValue("@AddressID", employee.AddressID);
                cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", employee.MiddleName);
                cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                cmd.Parameters.AddWithValue("@DOB", employee.DOB);
                cmd.Parameters.AddWithValue("@Gender", employee.Gender);
                cmd.Parameters.AddWithValue("@SIN", employee.SIN);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //To Update the records of a particular employee
        public void UpdateEmployee(MyDatabase employee)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UpdateEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    cmd.Parameters.AddWithValue("@HireLevelName", employee.HireLevelName);
                    cmd.Parameters.AddWithValue("@HireDate", employee.HireDate);
                    cmd.Parameters.AddWithValue("@AddressID", employee.AddressID);
                    cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                    cmd.Parameters.AddWithValue("@MiddleName", employee.MiddleName);
                    cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                    cmd.Parameters.AddWithValue("@DOB", employee.DOB);
                    cmd.Parameters.AddWithValue("@Gender", employee.Gender);
                    cmd.Parameters.AddWithValue("@SIN", employee.SIN);

                }
                catch
                {
                    Console.WriteLine("No Information Found.");
                }

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //Get the details of a particular employee
        public MyDatabase GetAllEmployees(int? id)
        {
            MyDatabase employee = new MyDatabase();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM Employee WHERE EmployeeID= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    try
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
                    catch
                    {
                        Console.WriteLine("No Information Found.");
                    }
                    
                }
            }
            return employee;
        }

        //To Delete the record on a particular employee
        public void DeleteEmployee(int? id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DeleteEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmpId", id);
                cmd.Parameters.AddWithValue("PerId", 1);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
