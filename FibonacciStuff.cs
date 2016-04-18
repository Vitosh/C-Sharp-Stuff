using System;

class MaxSequenceOfEqualElements
{
    public static int[] my_memo;

    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        my_memo = new int[k + 2];
        Console.WriteLine(FibWith(k));
    }

    static int FibWith(int counter_inside)
    {
        if (my_memo[counter_inside] != 0) return my_memo[counter_inside];
        if (counter_inside == 0) return 0;
        if (counter_inside == 1) return 1;
        my_memo[counter_inside] = FibWith(counter_inside - 1) + FibWith(counter_inside - 2);
        return my_memo[counter_inside];
    }
}
