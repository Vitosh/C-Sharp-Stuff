//http://codeforces.com/problemset/problem/676/C?locale=en
using System;
using System.Linq;

class VasyaAndStroka
{
    static void Main()
    {
        int[] int_line = Console.ReadLine().Split(new char[] { ' ' }).Select(int.Parse).ToArray();
        int n = int_line[0];
        int k = int_line[1];

        string str_line = Console.ReadLine();

        int ans = 0;
        int a = 0;
        int b = 0;
        int position = 0;

        foreach (var item in str_line)
        {
            if (item == 'a')
            {
                a++;
            }
            else
            {
                b++;
            }
            if (Math.Min(a,b) > k)
            {
                if (str_line[position] =='a')
                {
                    a--;
                }
                else
                {
                    b--;
                }
                position++;
            }
            else
            {
                ans++;
            }
        }
        Console.WriteLine(ans);
    }
}
