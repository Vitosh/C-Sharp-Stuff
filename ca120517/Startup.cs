using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ca120517
{
    class Startup
    {
        static void Main()
        {
            SoftUniDb context = new SoftUniDb();
            string strResult = "";
            var systemPath = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            var complete = Path.Combine(systemPath, "myFiles.txt");

            //PROBLEM 3
            //var employees = context.Employees
            //        .OrderBy(e=>e.EmployeeID);
            //foreach (Employee e in employees)
            //{
            //    strResult += $"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary.ToString().Replace(",",".")}\r\n";
            //}


            //PROBLEM 4
            //var employeeNames = context.Employees
            //        .Where(e => e.Salary > 50000)
            //        .OrderBy(e => e.EmployeeID);

            //foreach (Employee e in employeeNames)
            //{
            //    strResult += $"{e.FirstName}\r\n";
            //}

            //PROBLEM 5
            //var employees = context.Employees.Where(e =>
            //                        e.Department.Name == "Research and Development")
            //    .OrderBy(e => e.Salary)
            //    .ThenByDescending(e => e.FirstName);

            //foreach (Employee e in employees)
            //{
            //    strResult += $"{e.FirstName} {e.LastName} " + $"from {e.Department.Name} - ${e.Salary:F2}".ToString().Replace(",",".")+"\r\n";
            //}

            //PROBLEM 6

            StreamWriter file = new System.IO.StreamWriter(complete,false);
            file.WriteLine(strResult);
            Console.WriteLine(complete);
            file.Close();
        }
    }
}
