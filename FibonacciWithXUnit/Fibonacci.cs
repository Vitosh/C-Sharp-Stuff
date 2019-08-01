using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciWithXUnit
{
    public class Fibonacci
    {
        public long Calculate(int position)
        {
            //if (position == 1) return 1;
            //if (position == 2) return 1;
            //return Calculate(position - 1) + Calculate(position - 2);

            if (position == 1 || position == 2)
            {
                return 1;
            }

            int fib1 = 1;
            int fib2 = 1;
            int result = -1;

            for (int i = 3; i <= position; i++)
            {
                result = fib1 + fib2;
                fib1 = fib2;
                fib2 = result;
            }

            return result;

        }
    }
}
