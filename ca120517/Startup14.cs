using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ca00003
{
    class Startup
    {
        static void Main()
        {
            MyModel context = new MyModel();
            string strResult = "";
            var strComplete = @"C:\Users\v.doynov\Desktop\myFiles.txt";

            CultureInfo customCulture = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = customCulture;

            //14 Use the Gringotts database.
            //Write a program that prints all unique wizard first letters of their first names only if they have deposit of type Troll Chest. 
            //Order them alphabetically.Use DISTINCT for uniqueness.

            var wizWithDepo = context.WizzardDeposits
                                .Where(p=>p.DepositGroup == "Troll Chest")
                                .OrderBy(p=>p.FirstName)
                                .Select(p => p.FirstName.Substring(0,1))
                                .Distinct()
                                .ToList();

            foreach (var alpha in wizWithDepo)
            {
                strResult += alpha + "\r\n";
            }

            StreamWriter file = new StreamWriter(strComplete, false);
            file.WriteLine(strResult);
            file.Close();
        }
    }
}
