//http://codeforces.com/contest/750

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class cf750_02
{
    const int intSizeLine = 20000;
    const string SOUTH = "S";
    const string NORTH = "N";

    static bool violation = false;
    static int y;

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        y = 0;

        for (int i = 0; i < n; i++)
        {
            string strInfo = Console.ReadLine();
            int intSize = int.Parse(strInfo.Split()[0]);
            string strDirection = strInfo.Split()[1].Substring(0, 1);

            if (y == 0 && strDirection!=SOUTH)
            {
                violation = true;
            }

            if (y == intSizeLine && strDirection != NORTH)
            {
                violation = true;
            }

            if (strDirection == SOUTH)
            {
                y = GetY(intSize, SOUTH);
            }
            else if (strDirection == NORTH)
            {
                y = GetY(intSize, NORTH);
            }
        }

        if (y == 0 && !violation )
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }

    public static int GetY(int intValue, string strDirection)
    {
        int intResult = 0;

        switch (strDirection)
        {
            case NORTH:
                if (y - intValue < 0)
                {
                    violation = true;
                    return intResult;
                }
                else
                {
                    intResult = y - intValue;
                }
                break;

            case SOUTH:
                if (intValue + y > intSizeLine)
                {
                    violation = true;
                    return intResult;
                }
                else
                {
                    intResult = y + intValue;
                }
                break;
        }

        return intResult;
    }
}

