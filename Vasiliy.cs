//http://codeforces.com/contest/706/problem/A

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Code_160813_01
{
    static void Main()
    {
        string[] s_input = Console.ReadLine().Split();

        int i_point_a = int.Parse(s_input[0]);
        int i_point_b = int.Parse(s_input[1]);
        int i_cars_total = int.Parse(Console.ReadLine());

        List<List<int>> l_cars_info = new List<List<int>>();
        List<double> l_result = new List<double>();

        double d_distance;
        double d_result;

        for (int i = 0; i < i_cars_total; i++)
        {
            List<int> l_3 = new List<int>();
            string[] s_input2 = Console.ReadLine().Split();
            l_3.Add(int.Parse(s_input2[0]));
            l_3.Add(int.Parse(s_input2[1]));
            l_3.Add(int.Parse(s_input2[2]));
            l_cars_info.Add(l_3);
        }

        for (int i = 0; i < i_cars_total; i++)
        {
            d_distance = Math.Sqrt(Math.Pow(i_point_a - l_cars_info[i][0],2)+Math.Pow(i_point_b-l_cars_info[i][1],2));
            d_distance = d_distance / l_cars_info[i][2];
            l_result.Add(d_distance);
        }

        d_result = l_result.Min();
        Console.WriteLine(d_result.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US")));
    }
}

