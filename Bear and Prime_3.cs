using System;
using System.Collections.Generic;
using System.Linq;

class CompositeAndPrime
{
    static void Main()
    {
        int int_final = int.Parse(Console.ReadLine());
        List<int> l_prime = GeneratePrimesUpTo(int_final);
        List<int> l_prime_squares = GeneratePrimesSquaresUpTo(l_prime,int_final);

        string str_prime1 = string.Join(",", l_prime.ToArray());
        Console.WriteLine(str_prime1);
        string str_prime2 = string.Join(",", l_prime_squares.ToArray());
        Console.WriteLine(str_prime2);

        List<int> union = l_prime.Concat(l_prime_squares).ToList();
        string str_prime3 = string.Join(",", union.ToArray());
        Console.WriteLine(str_prime3);

        int i_sum = 0;

        for (int i = 0; i < union.Count; i++)
        {
            Console.WriteLine(union[i]);
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

    static List<int> GeneratePrimesSquaresUpTo(List<int> l_primes ,int int_final)
    {
        List<int> list_result = new List<int> {};

        for (int i = 0; i < int_final; i++)
        {
            if (l_primes[i]* l_primes[i] >= int_final)
            {
                break;
            }
            list_result.Add(l_primes[i] * l_primes[i]);
        }

        return list_result;

    }

    static List<int> GeneratePrimesUpTo(int int_final)
    {
        List<int> list_result = new List<int> {2};
        int int_next = 3;

        for (int i = 0; i<int_final; i++)
        {
            bool b_is_prime = true;
            int int_sqrt = int_next * int_next;
            for (int k = 0; k < list_result.Count; k++)
            {
                if (int_next % list_result[k] == 0)
                {
                    b_is_prime = false;
                    break;
                }
            }
            if (b_is_prime)
            {
                list_result.Add(int_next);
            }
            int_next+=2;
        }
        return list_result;
    }
}
