using System;

class FibonacciChecks
{
    public static long[] my_memo;
    public static DateTime my_time;
    public static long my_counter;

    static void Main()
    {
        Console.WriteLine("Enter number between 2 and 1300 for Fibonacci calculation:");
        long k = long.Parse(Console.ReadLine());
        my_memo = new long[k+1];

        my_counter = 0;
        my_time = DateTime.Now;

        Console.WriteLine("\n{0}", FibWithMemo(k));
        Console.WriteLine("Calculations {0}", my_counter);
        Console.WriteLine(DateTime.Now - my_time);

        my_counter = 0;
        my_time = DateTime.Now;

        Console.WriteLine("\n{0}",FibWithMemo(k, false));
        Console.WriteLine("Calculations {0}", my_counter);
        Console.WriteLine(DateTime.Now - my_time);

        my_counter = 2; //Here we already have the first two numbers, so it is a bit unfair
        my_time = DateTime.Now;

        Console.WriteLine("\n{0}", FibWithLoop(k));
        Console.WriteLine("Calculations {0}", my_counter);
        Console.WriteLine(DateTime.Now - my_time);
    }

    static long FibWithLoop(long counter_inside)
    {
        long f1 = 1;
        long f2 = 1;
        long f_result = 0;

        for (my_counter=2; my_counter < counter_inside; my_counter++)
        {
            f_result = f1 + f2;
            f1 = f2;
            f2 = f_result;
        }

        return f_result;
    }

    static long FibWithMemo(long counter_inside, bool with_memo = true)
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
