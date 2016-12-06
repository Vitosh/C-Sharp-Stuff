//http://codeforces.com/contest/742/problem/A?locale=en

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class round383_1
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int result=-1;

        if (n == 0)
        {
            result = 1;
        }else {
            switch (n % 4)
            {
                case 0:
                    result = 6;
                    break;
                case 1:
                    result = 8;
                    break;
                case 2:
                    result = 4;
                    break;
                case 3:
                    result = 2;
                    break;
            }
        }
        Console.WriteLine(result);
    }
}
