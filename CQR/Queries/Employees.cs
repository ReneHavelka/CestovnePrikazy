using CestovnePrikazy.CQR.Common;
using CestovnePrikazy.Models;
using System.Data.SqlClient;

namespace CestovnePrikazy.CQR.Queries
{
    internal class Employees
    {
        string connectionString;

        internal Employees()
        {
            connectionString = new ConnectionStr().ConnectionString;
        }

        internal IList<Employee> GetEmployees()
        {
            IList<Employee> employees = new List<Employee>();
            string queryStr = @"SELECT * FROM EMPLOYEES";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(queryStr, conn);
                sqlCommand.Connection.Open();

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var employee = new Employee();
                        employee.Id = (int)reader.GetValue(0);
                        employee.EmployeeNo = (string)reader.GetValue(1);
                        employee.Name = (string)reader.GetValue(2);
                        employee.Surname = (string)reader.GetValue(3);
                        employee.DateOfBirth = DateOnly.FromDateTime((DateTime)reader.GetValue(4));
                        employees.Add(employee);
                    }
                }

                sqlCommand.Connection.Close();
            }

            return employees;
        }
    }
}
