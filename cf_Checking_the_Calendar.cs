using System;
using System.Collections.Generic;
//http://codeforces.com/contest/724/problem/A

class Problem1
{
    static void Main()
    {
        string str_first = Console.ReadLine();
        string str_second = Console.ReadLine();

        List<string> my_days = new List<String> { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" };

        int i_first = my_days.FindIndex(my_day => my_day.Equals(str_first));
        int i_second = my_days.FindIndex(my_day => my_day.Equals(str_second));

        if ((i_first == i_second) || ((i_first+2) % 7 == i_second) || ((i_first + 3) % 7 == i_second))
        {
            Console.WriteLine("YES");
        }else{
            Console.WriteLine("NO");
        }
    }
}

