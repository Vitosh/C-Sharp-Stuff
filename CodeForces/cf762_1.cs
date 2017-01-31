//http://codeforces.com/problemset/problem/762/A?locale=en

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class cf1
{
    static void Main()
    {
        string strInfo01 = Console.ReadLine();

        long lngNumber = long.Parse(strInfo01.Split()[0]);
        long lngPosition = long.Parse(strInfo01.Split()[1]);
        long lngSquare = (long)Math.Sqrt(lngNumber);

        List<long> lstResults = new List<long>();

        for (long i = 1; i <= lngSquare; i++)
        {
            if (lngNumber % i == 0)
            {
                lstResults.Add(i);
                if (i != lngNumber/i)
                {
                    lstResults.Add(lngNumber / i);
                }
            }
        }

        lstResults.Sort();

        if (lstResults.Count< lngPosition)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(lstResults [(int)lngPosition-1]);
        }
    }
}
