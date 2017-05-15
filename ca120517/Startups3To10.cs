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
            //var address = new Address()
            //{
            //    AddressText = "Vitoshka 15",
            //    TownID = 4
            //};
            //Employee empN = null;
            //empN =  context.Employees.Where(e =>
            //                                    e.LastName == "Nakov").FirstOrDefault();
            //empN.Address = address;
            //context.SaveChanges();
            //var allEmployees = context.Employees.OrderByDescending(e => e.AddressID).Take(10);
            //foreach (Employee e in allEmployees)
            //{
            //    strResult += $"{e.Address.AddressText}\r\n";
            //}

            //PROBLEM 7
            //DateTime dtStart = DateTime.Parse("01/01/2001");
            //DateTime dtEnd = DateTime.Parse("01/01/2003");

            //var empWithProjects = context.Employees
            //                            .Where(emp => emp.Projects.Any
            //                                 (
            //                                    pro => pro.StartDate >= dtStart
            //                                    && pro.StartDate <= dtEnd)
            //                                 )
            //                            .OrderBy(emp => emp.EmployeeID)
            //                            .Take(30);

            //string pattern = "M/d/yyyy h:mm:ss tt";
            //string startDate1;
            //string endDate1;

            //foreach (Employee e in empWithProjects)
            //{
            //    strResult += $"{e.FirstName} {e.LastName} {e.Manager.FirstName}\r\n";
            //    foreach (Project pro in e.Projects)
            //    {
            //        startDate1 = pro.StartDate.ToString(pattern,CultureInfo.InvariantCulture);
            //        if (pro.StartDate == null)
            //        {
            //            startDate1 = "";
            //        }
            //        else
            //        {
            //            startDate1 = ((DateTime)pro.StartDate).ToString(pattern, CultureInfo.InvariantCulture);
            //        }

            //        if (pro.EndDate==null)
            //        {
            //            endDate1 = "";
            //        }
            //        else
            //        {
            //            endDate1 = ((DateTime)pro.EndDate).ToString(pattern, CultureInfo.InvariantCulture);
            //        }
                    
            //        strResult += $"--{pro.Name} {startDate1} {endDate1}\r\n";
            //    }
            //}
            
            //PROBLEM 8
            var addressesWithEmp = context.Addresses
                            .OrderByDescending(a=> a.Employees.Count())
                            .ThenBy(a=> a.Town.Name)
                            .Take(10);
            
            foreach (Address a in addressesWithEmp)
            {
                strResult += $"{a.AddressText}, " + $"{a.Town.Name} - {a.Employees.Count()} employees\r\n";

            }
            
            //PROBLEM 9
            //var empWithId147 = context.Employees
            //                        .Where(e => e.EmployeeID == 147).FirstOrDefault();


            //var proId147 = empWithId147.Projects
            //                        .OrderBy(pro => pro.Name);

            //strResult = $"{empWithId147.FirstName} {empWithId147.LastName} {empWithId147.JobTitle}\r\n";

            //foreach (Project pro in proId147)
            //{
            //    strResult += $"{pro.Name}\r\n";
            //}

            //PROBLEM 10
            //var departments = context.Departments
            //                        .Where(d => d.Employees.Count > 5)
            //                        .OrderBy(d => d.Employees.Count);
            //foreach (Department dep in departments)
            //{
            //    strResult += $"{dep.Name} {dep.Employee.FirstName}\r\n";
            //    foreach (Employee emp in dep.Employees)
            //    {
            //        strResult += $"{emp.FirstName} {emp.LastName} {emp.JobTitle}\r\n";
            //    }
            //}

            StreamWriter file = new System.IO.StreamWriter(complete,false);
            file.WriteLine(strResult);
            Console.WriteLine(complete);
            file.Close();
        }
    }
}
