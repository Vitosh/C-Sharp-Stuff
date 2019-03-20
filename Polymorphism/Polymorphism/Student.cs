using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Student : IMoneyMaker
    {
        decimal Money { get; set; }

        public void MakeMoney()
        {
            Money += 10;
            Console.WriteLine($"The money are {Money}");    
        }

        public string TellMeYourName(string name)
        {
            return $"My name is {name} and I have ${Money}";
        }

        public string InfoSchool()
        {
            return "I study at 163!";
        }
    }
}
