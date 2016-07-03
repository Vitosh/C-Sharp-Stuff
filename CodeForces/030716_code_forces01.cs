using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class test_code_forces01
{
    static void Main()
    {

        string[] input = Console.ReadLine().Split();
        int enemies_count = int.Parse(input[0]);
        int days_count = int.Parse(input[1]);
        List<int> results = new List<int>();

        string number_max = CheckNumber(enemies_count);
        string current_string = "";
        int biggest_sequence = 0;

        for (int i = 0; i < days_count; i++)
        {
            current_string = Console.ReadLine();
            if (current_string.Equals(number_max,StringComparison.Ordinal))
            {
                biggest_sequence = 0; 
            }
            else
            {
                biggest_sequence++;
            }
            results.Add(biggest_sequence);
        }
        Console.WriteLine(results.Max());
    }

    static string CheckNumber(int enemies_count)
    {
        string result = "";
        for (int i = 0; i < enemies_count; i++)
        {
            result += "1";
        }
        return result;
    }
}
