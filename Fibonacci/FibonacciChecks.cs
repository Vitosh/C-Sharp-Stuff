using System;
namespace Fibonacci
{
    public class FibonacciChecks
    {
        public static long[] my_memo;
        public static DateTime my_time;
        public static long my_counter;

        public static void Main()
        {
            Console.WriteLine("Enter number between 2 and 1300 for Fibonacci calculation:");
            long k = long.Parse(Console.ReadLine());
            my_memo = new long[k + 1];

            my_counter = 0;
            my_time = DateTime.Now;

            Console.WriteLine("\n{0}", FibWithMemo(k));
            Console.WriteLine("Calculations {0}", my_counter);
            Console.WriteLine(DateTime.Now - my_time);
        }

        public static long FibWithMemo(long counter_inside, bool with_memo = true)
        {
            if (with_memo)
            {
                if (my_memo[counter_inside] != 0) return my_memo[counter_inside];
            }

            my_counter++;

            if (counter_inside == 0) return 0;
            if (counter_inside == 1) return 1;
            my_memo[counter_inside] = FibWithMemo(counter_inside - 1, with_memo) + FibWithMemo(counter_inside - 2, with_memo);
            return my_memo[counter_inside];
        }
    }
}