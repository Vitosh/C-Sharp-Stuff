//http://codeforces.com/contest/733/problem/B

using System;
using System.Collections.Generic;
using System.Linq;

class cf378_2
{
    static void Main()
    {
        string str_read = "";
        int int_better_beauty = -1;
        int int_current_beauty;
        int int_row = 0;
        int int_total = int.Parse(Console.ReadLine());

        int int_total_l = 0;
        int int_total_r = 0;

        List<int> lst_left = new List<int>();
        List<int> lst_right = new List<int>();

        for (int i = 0; i < int_total; i++)
        {
            str_read = Console.ReadLine();
            lst_left.Add(int.Parse(str_read.Split()[0]));
            lst_right.Add(int.Parse(str_read.Split()[1]));
            int_total_l += int.Parse(str_read.Split()[0]);
            int_total_r += int.Parse(str_read.Split()[1]);
        }

        int int_initial_beauty = Math.Abs(int_total_l-int_total_r);
        for (int i = 0; i < int_total; i++)
        {
            int_current_beauty = Math.Abs(int_total_l - 2 * lst_left[i] + 2 * lst_right[i] - int_total_r);
            if ((int_current_beauty>int_better_beauty) && (int_current_beauty > int_initial_beauty))
            {
                int_better_beauty = int_current_beauty;
                int_row = i+1;
            }
        }
        Console.WriteLine(int_row);
    }
}
