using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threads
{
    public class Writer
    {
        public void WriteSomething(string strSomething)
        {
            while (true)
            {
                Console.WriteLine(strSomething);
            }
        }

        public void WriteSomethingOnce()
        {
            Console.WriteLine("Writing just once");
        }

    }
}
