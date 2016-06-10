using System;
using System.Collections.Generic;

class CompositeAndPrime
{
    static void Main()
    {
        List<int> l_prime = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 4, 9, 25, 49 };
        int i_sum = 0;

        for (int i = 0; i < l_prime.Count; i++)
        {
            Console.WriteLine(l_prime[i]);
            Console.Out.Flush();
            string reader1 = Console.ReadLine();
            if (reader1.Equals("yes"))
            {
                i_sum++;
                if (i_sum >= 2)
                {
                    Console.WriteLine("composite");
                    Console.Out.Flush();
                    return;
                }
            }
        }
        Console.WriteLine("prime");
        Console.Out.Flush();
        return;
    }
}
