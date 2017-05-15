using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;
using System.IO;

namespace EF_Part2
{
    class Startup
    {
        static void Main()
        {
            SoftUniDB context = new SoftUniDB();
            Gringotts contextG = new Gringotts();
            string strResult = "";
            var strComplete = @"C:\Users\gropc\Desktop\myModels.txt";

            CultureInfo customCulture = (CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            //Problem 11
            //var lastProjects = context.Projects
            //                        .OrderByDescending(pro => pro.StartDate)
            //                        .Take(10)
            //                        .OrderBy(pro => pro.Name);

            //foreach (Project pro in lastProjects)
            //{
            //    strResult += $"{pro.Name} {pro.Description} {pro.StartDate} {pro.EndDate}\r\n";
            //}

            //Problem 12
            //var empInSpecificDepartment = context.Employees
            //                                .Where(e => e.Department.Name == "Engineering" ||
            //                                            e.Department.Name == "Tool Design" ||
            //                                            e.Department.Name == "Marketing" ||
            //                                            e.Department.Name == "Information Services");

            //foreach (Employee emp in empInSpecificDepartment)
            //{
            //    decimal decSalary = emp.Salary;
            //    decSalary *= 1.12M;
            //    emp.Salary = decSalary;
            //    strResult += $"{emp.FirstName} {emp.LastName} (${decSalary:F6})\r\n";
            //}

            //context.SaveChanges();

            //Problem 13
            //var empWithSa = context.Employees
            //                            .Where(emp => emp.FirstName.Substring(0, 2).ToLower() == "sa");

            //foreach (Employee emp in empWithSa)
            //{
            //    strResult += $"{emp.FirstName} {emp.LastName} - {emp.JobTitle} - (${emp.Salary})\r\n";
            //}

            //Problem 14
            //var wizWithDepo = contextG.WizzardDeposits
            //                        .Where(p => p.DepositGroup == "Troll Chest")
            //                        .OrderBy(p => p.FirstName)
            //                        .Select(p => p.FirstName.Substring(0, 1))
            //                        .Distinct()
            //                        .ToList();

            //foreach (var alpha in wizWithDepo)
            //{
            //    strResult += alpha + "\r\n";
            //}

            StreamWriter file = new StreamWriter(strComplete, false);
            file.WriteLine(strResult);
            file.Close();            
        }
    }
}
