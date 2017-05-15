using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca0002
{
    class Startup
    {
        static void Main()
        {
            MyModel context = new MyModel();
            string strResult = "";
            var strComplete = @"C:\Users\v.doynov\Desktop\myFiles.txt";

            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;


            //11 - their name, description, start and end date 
            //string strPattern = "M/d/yyyy h:mm:ss tt";  

            //var lastProjects = context.Projects
            //                    .OrderByDescending(pro => pro.StartDate)
            //                    .Take(10)
            //                    .OrderBy(pro=>pro.Name);

            //string strEndDate = "";

            //foreach (Project pro in lastProjects)
            //{
            //    string strStartDate = pro.StartDate.ToString(strPattern, CultureInfo.InvariantCulture);

            //    if (pro.EndDate == null)
            //    {
            //        strEndDate = "";
            //    }
            //    else
            //    {
            //        strEndDate = ((DateTime)pro.EndDate).ToString(strPattern);
            //    }

            //    strResult += $"{pro.Name} {pro.Description} {strStartDate} {strEndDate}\r\n";
            //}

            //12
            //var empInSpecificDept = context.Employees
            //                            .Where(e => e.Department.Name == "Engineering" ||
            //                                        e.Department.Name == "Tool Design" ||
            //                                        e.Department.Name == "Marketing" ||
            //                                        e.Department.Name == "Information Services");

            //foreach (Employee emp in empInSpecificDept)
            //{

            //    decimal decSalary = emp.Salary;
            //    decSalary *= 1.12M;
            //    emp.Salary = decSalary;
            //    strResult += $"{emp.FirstName} {emp.LastName} (" + $"${decSalary:F6})" + "\r\n";
            //}
            //context.SaveChanges();

            //13 - Print their first, last name, their job title and salary in the format given in the example below.
            //var empWithSA = context.Employees
            //                            .Where(e => e.FirstName.Substring(0, 2).ToLower() == "sa");

            //foreach (Employee emp in empWithSA)
            //{
            //    strResult += $"{emp.FirstName} {emp.LastName} - {emp.JobTitle} - (${emp.Salary:F4})\r\n";
            //}

            StreamWriter file = new StreamWriter(strComplete, false);
            file.WriteLine(strResult);
            file.Close();
        }
    }
}
