//http://codeforces.com/problemset/problem/762/B

using System;
using System.Collections.Generic;
using System.Linq;

class cf2
{
    static void Main()
    {
        string strInfo01 = Console.ReadLine();

        long longCountA = long.Parse(strInfo01.Split()[0]);
        long longCountB = long.Parse(strInfo01.Split()[1]);
        long longCountAB = long.Parse(strInfo01.Split()[2]);

        long longTotalCount = long.Parse(Console.ReadLine());
        long longTotalSum = 0;
        long longTotalBought = 0;

        Dictionary<long, List<long>> dictInfo01 = new Dictionary<long, List<long>>();
        dictInfo01.Add(1, new List<long>());
        dictInfo01.Add(2, new List<long>());

        Dictionary<long, LinkedList<long>> dictInfo02 = new Dictionary<long, LinkedList<long>>();
        dictInfo02.Add(1, new LinkedList<long>());
        dictInfo02.Add(2, new LinkedList<long>());

        for (long i = 1; i <= longTotalCount; i++)
        {
            string strInfo02 = Console.ReadLine();
            string strInfo0201 = strInfo02.Split()[1].Substring(0, 1);
            long longValue = long.Parse(strInfo02.Split()[0]);

            if (strInfo0201 == "U")
            {
                dictInfo01[1].Add(longValue);
            }
            else
            {
                dictInfo01[2].Add(longValue);
            }
        }

        dictInfo01[1].Sort();
        dictInfo01[2].Sort();

        foreach (var item in dictInfo01[1])
        {
            dictInfo02[1].AddLast(item);
        }

        foreach (var item in dictInfo01[2])
        {
            dictInfo02[2].AddLast(item);
        }

        for (long i = 1; i <= longTotalCount; i++)
        {
            long longSmaller = 0;
            long longFromWhich = 0;

            if (dictInfo02[1].Count > 0)
            {
                longSmaller = dictInfo02[1].First();
                longFromWhich = 1;
            }

            if (dictInfo02[2].Count > 0)
            {
                if (longFromWhich == 1)
                {
                    if (dictInfo02[2].First() < longSmaller)
                    {
                        longSmaller = dictInfo02[2].First();
                        longFromWhich = 2;
                    }
                }
                else
                {
                    longSmaller = dictInfo02[2].First();
                    longFromWhich = 2;
                }
            }
            if (longFromWhich == 1)
            {
                dictInfo02[1].RemoveFirst();
                if (longCountA > 0)
                {
                    FixNumbers(ref longCountA, ref longTotalSum, ref longSmaller, ref longTotalBought);
                }
                else if (longCountAB > 0)
                {
                    FixNumbers(ref longCountAB, ref longTotalSum, ref longSmaller, ref longTotalBought);
                }
            }
            else if (longFromWhich == 2)
            {
                dictInfo02[2].RemoveFirst();
                if (longCountB > 0)
                {
                    FixNumbers(ref longCountB, ref longTotalSum, ref longSmaller, ref longTotalBought);
                }
                else if (longCountAB > 0)
                {
                    FixNumbers(ref longCountAB, ref longTotalSum, ref longSmaller, ref longTotalBought);
                }

            }
        }
        Console.WriteLine("{0} {1}", longTotalBought, longTotalSum);
    }

    private static void FixNumbers(ref long longCount,ref long LongTotalSum,ref long longSmaller,ref long longTotalBought)
    {
        longCount--;
        LongTotalSum += longSmaller;
        longTotalBought++;
    }

}
