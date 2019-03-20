using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractQuick
{
    class Startup
    {
        static void Main()
        {
            IDeveloper developer = new Employee("Jo-dev-a", 200);
            IPracticant practicant = new Employee("JoPracticant-a", 20);
            Employee employee = new Employee("Jo-employee-to", 250);

            List<object> myList = new List<object>();
            myList.Add(developer);
            myList.Add(practicant);
            myList.Add(employee);

            foreach (object worker in myList)
            {
                //Console.WriteLine(worker.PresentYourself());
            }
        }
    }
}
