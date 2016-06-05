using System;

class vitbit
{
    static void Main()
    {
        string input = Console.ReadLine();
        long zeroes = 0;

        foreach (char my_char in input)
        {
            long i = GenerateValue(my_char);

            for (int j = 5; j >= 0; j--)
            { 
                if (((i >> j) & 1) == 0)
                zeroes++;
            }
        }

        long result = 1;
        long mod = (long)(Math.Pow(10, 9))+7;

        for (long i = 0; i < zeroes; i++)
        {
            result *= 3;
            result %= mod;
        }

        Console.WriteLine(result);
    }

    static long GenerateValue(char my_char)
    {
        if (my_char >= '0' && my_char <= '9')
            return my_char-'0';
        if (my_char >= 'a' && my_char <= 'z')
            return my_char - 'a' + 36;
        if (my_char >= 'A' && my_char <= 'Z')
            return my_char - 'A' + 10;
        if (my_char == '-')
            return 62;
        return 63;
    }
}
