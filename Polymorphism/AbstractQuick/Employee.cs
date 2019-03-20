using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractQuick
{
    public class Employee : IDeveloper, IPracticant, IWorker
    {
        public Employee(string name, int Salary)
        {
            this.Name = name;
            this.Salary = Salary;
        }

        public string Name { get; private set; }

        public int Salary { get; private set; }
         
        public string PresentYourself()
        {
            return "I am an employee!";
        }

        string IPracticant.PresentYourself()
        {
            return "Practicant am I!";
        }

        string IDeveloper.PresentYourself()
        {
            return "I am developer.";
        }
    }
}
