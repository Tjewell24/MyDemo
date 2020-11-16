using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
     public static class EmployeeProcessor
    {
        public static int CreateEmployee(int employeeId, string role, string lastName, string firstName, string city, string country, string email)
        {
            EmployeeModel data = new EmployeeModel
            {
                EmployeeId = employeeId,
                Role = role,
                LastName = lastName,
                FirstName = firstName,
                City = city,
                Country = country,
                Email = email
               

            };

            string sql = @"insert into dbo.Employee (EmployeeId, Role, LastName, FirstName, City, Country, Email) values (@EmployeeId, @Role, @LastName, @FirstName, @City, @Country, @Email);";
            return SqlDataAccess.SaveData(sql, data);
        
        }

        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = @"select EmployeeId, Role, LastName, FirstName, City, Country, Email from dbo.Employee;";

            return SqlDataAccess.LoadData<EmployeeModel>(sql);

        }

    }
}
