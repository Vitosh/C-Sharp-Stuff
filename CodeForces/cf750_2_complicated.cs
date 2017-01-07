http://codeforces.com/contest/750/problem/B


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class cf002
{
    const int intSizeLine = 20000;
    const int intSizeLine2 = 40000;
    const string SOUTH = "S";
    const string NORTH = "N";

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

            if (y == 0)
            {
                y = GetY(intSize, SOUTH);
            }
            else if(y == intSizeLine)
            {
                y = GetY(intSize, NORTH);
            }
            else if (strDirection == SOUTH)
            {
                y = GetY(intSize, SOUTH);
            }
            else if (strDirection == NORTH)
            {
                y = GetY(intSize, NORTH);
            }
        }

        if (y==0)
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
        int intLeft = 0;

        if (intValue >= intSizeLine2)
        {
            intValue -= (intValue / intSizeLine2) * intSizeLine2;
        }

        switch (strDirection)
        {
            case NORTH:
                if (y-intValue<0)
                {
                    intLeft = y;
                    intValue -= intLeft;
                    if (intValue > intSizeLine)
                    {
                        intValue -= intSizeLine;
                        intResult = GetY(intValue, NORTH);
                    }
                    else
                    {
                        intResult = intValue;
                    }
                }
                else
                {
                    intResult = y - intValue;
                }


                break;

            case SOUTH:
                if (intValue+y>intSizeLine)
                {
                    intLeft = intSizeLine - y;
                    intValue -= intLeft;
                    if (intValue > intSizeLine)
                    {
                        intValue -= intSizeLine;
                        intResult = GetY(intValue, SOUTH);
                    }
                    else
                    {
                        intResult = intSizeLine - intValue;
                    }
                }else
                {
                    intResult = y + intValue;
                }
                break;
        }

        return intResult;
    }
}
