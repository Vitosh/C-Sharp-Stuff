using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StartUp
{
    static void Main()
    {
        Solution p = new Solution();
        Console.WriteLine(p.solution(1, 8, 3, 2, 6, 4));
        Console.WriteLine(p.solution(2, 2, 2, 2, 6, 4));
        Console.WriteLine(p.solution(1, 9, 9, 9, 9, 9));
        Console.WriteLine(p.solution(1, -1, 3, 2, 6, 4));
    }
}

class Solution
{
    public string solution(int A, int B, int C, int D, int E, int F)
    {
        int[] myArray = new int[6] { A, B, C, D, E, F };

        for (int i = 23; i > 0; i--)
        {
            for (int ii = 59; ii > 0; ii--)
            {
                for (int iii = 59; iii > 0; iii--)
                {
                    if (compareTwoArrays(i, ii, iii, myArray))
                    {
                        return i.ToString() + ":" + ii.ToString() + ":" + iii.ToString();
                    }
                }
            }
        }
        return "NOT POSSIBLE";
    }

    public bool compareTwoArrays(int i, int ii, int iii, int[] myArray)
    {
        char[] A = (i.ToString() + ii.ToString() + iii.ToString()).ToCharArray();
        char[] B = string.Join("", myArray.Select(a => a.ToString()).ToArray()).ToCharArray();

        Array.Sort(A);
        Array.Sort(B);

        return (int.Parse(string.Join("", A)) == int.Parse(string.Join("", B)));
    }
}
