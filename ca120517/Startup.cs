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
            var employees = context.Employees
                    .OrderBy(e=>e.EmployeeID);
            string strResult = "";

            CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = customCulture;

            foreach (Employee e in employees)
            {
                strResult += $"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary.ToString().Replace(",",".")}\r\n";
            }

            var systemPath = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            var complete = Path.Combine(systemPath, "myFiles.txt");
            Console.WriteLine(complete);

            System.IO.StreamWriter file = new System.IO.StreamWriter(complete, true);
            file.WriteLine(strResult);

            file.Close();
        }
    }
}
