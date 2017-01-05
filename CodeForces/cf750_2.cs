http://codeforces.com/contest/750/problem/B


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Problem002
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int x = 0;
        int maxLine = 20000;
        int maxLine2 = 2 * maxLine;

        string strReader;
        int iPath;
        string direction;

        for (int i = 0; i < n; i++)
        {
            strReader = Console.ReadLine();
            iPath = int.Parse(strReader.Split()[1]);
            direction = strReader.Split()[0].Substring(0,1);

            if (x == 0)
            {
                direction = "S";
            }

            if (x == maxLine)
            {
                direction = "N";
            }

            if (direction == "S")
            {
                if ((iPath + x) > maxLine2)
                {
                    int times = iPath / maxLine2;
                    iPath -= times * maxLine2;
                }

                if ((iPath+x)> maxLine)
                {
                    int iLeft = maxLine - iPath;
                    iPath -= iLeft;
                    
                    if (iPath - x < 0)
                    {
                        x = Math.Abs(iPath - x);
                    }
                    else
                    {
                        x -= iPath;
                    }
                }
            }
            else if (direction == "N")
            {
            }
        }
    }
}
