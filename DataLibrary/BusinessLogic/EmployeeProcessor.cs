using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DataAccess;
using DataLibrary.Models;

namespace DataLibrary.BusinessLogic
{
    public static class EmployeeProcessor
    {
        public static int CreateEmployee(int employeeId, string firstName, string lastName, string emailId, string password)
        {
            Employee data = new Employee
            {
                EmployeeId = employeeId,
                FirstName = firstName,
                LastName = lastName,
                Email_Id = emailId,
                Password = password
            };

            string sql = @"insert into dbo.Employee(EmployeeId, FirstName, LastName, Email_Id, Password)
                           values (@EmployeeId, @FirstName, @LastName, @Email_Id, @Password);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<Employee> LoadEmployees()
        {
            string sql = @"select Id, EmployeeId, FirstName, LastName, Email_Id, Password
                          from dbo.Employee;";

            return SqlDataAccess.LoadData<Employee>(sql);
        }
    }
}
