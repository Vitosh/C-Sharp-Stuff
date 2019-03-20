using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Actor : IMoneyMaker
    {
        public void MakeMoney()
        {
            Console.WriteLine("I make money somehow");
        }

        public string TellMeYourName(string name)
        {
            return $"My name is {name} and I am pleased to meet you!";
        }
    }
}
