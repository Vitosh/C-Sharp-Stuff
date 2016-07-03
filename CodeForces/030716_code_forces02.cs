using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class test_code_forces02
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(input+Reverse(input));
    }

    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

}

