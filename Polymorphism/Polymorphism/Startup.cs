using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Startup
    {
        static void Main()
        {
            Student student = new Student();
            Actor actor = new Actor();

            student.MakeMoney();
            student.MakeMoney();
            actor.MakeMoney();
            actor.MakeMoney();

            Console.WriteLine(actor.TellMeYourName("Jo"));
            Console.WriteLine(student.TellMeYourName("Ben"));

            IMoneyMaker student2 = new Student();
            IMoneyMaker actor2 = new Actor();

            student2.MakeMoney();
            student2.MakeMoney();
            actor2.MakeMoney();
            actor2.MakeMoney();

            Console.WriteLine(actor2.TellMeYourName("Jo"));
            Console.WriteLine(student2.TellMeYourName("Ben"));
            Console.WriteLine(student.InfoSchool()); 
        }
    }
}
