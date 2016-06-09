using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class problem_8june2016_02
{
    static void Main()
    {
        int[] int_line1 = Console.ReadLine().Split(new char[] { ' ' }).Select(int.Parse).ToArray();
        int[] int_line2 = Console.ReadLine().Split(new char[] { ' ' }).Select(int.Parse).ToArray();

        int int_cities = int_line1[0];
        int int_capital = int_line1[1]-1;

        int int_result = 0;
        
        List<int> list_left = new List<int>();
        List<int> list_right = new List<int>();

        for (int i = 0; i < int_cities; i++)
        {
            if (i < int_capital)
            {
                list_left.Add(int_line2[i]);
            }
            if (i > int_capital)
            {
                list_right.Add(int_line2[i]);
            }
        }

        list_left.Reverse();
        int max_len = Math.Min(list_left.Count, list_right.Count);
        int another_len = Math.Max(list_left.Count, list_right.Count);

        for (int i = 0; i < max_len; i++)
        {
            if (list_left[i]==list_right[i])
            {
                int_result += list_left[i] * 2;
            }
        }

        //list_left.Reverse();
        List<int> list_last = new List<int>();

        if (list_left.Count>list_right.Count)
        {
            list_last = list_left;
        }
        else
        {
            list_last = list_right;
        }

        for (int i = max_len; i < another_len ; i++)
        {
            int_result += list_last[i];
        }

        int_result += int_line2[int_capital];
        Console.WriteLine(int_result);
    }
}
