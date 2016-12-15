using System;
using System.Runtime.InteropServices;

namespace IntDemo
{
    [ClassInterface(ClassInterfaceType.None)]
    public class Demo : IIntellisenseDemo
    {
        public int numberBy2;
        public int numberBy3;

        public int NumberBy3
        {
            get
            {
                return numberBy3;
            }
            set
            {
                numberBy3 = value * 3;
            }

        }

        public int NumberBy2
        {
            get
            {
                return numberBy2;
            }
            set
            {
                numberBy2 = value * 2;
            }
        }
        public string TestString(string name)
        {
            return "Here comes " + name;
        }
    }
}
