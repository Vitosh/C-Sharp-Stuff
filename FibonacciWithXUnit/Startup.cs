using System;

namespace FibonacciWithXUnit
{
    class Startup
    {
        static void Main()
        {
            Fibonacci fibonacci = new Fibonacci();
            for (int i = 1; i < 30; i++)
            {
                Console.WriteLine(fibonacci.Calculate(i));
            }
        }
    }
}