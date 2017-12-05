using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StartUp
{
    static void Main()
    {
        int[] arrayInput = { 1, 2, 3 };
        Solution p = new Solution();
        Console.WriteLine(p.solution(arrayInput));
    }
}

class Solution
{
    public int solution(int[] A)
    {
        A = A.Distinct().ToArray();
        Array.Sort(A);
        bool hasPositive = false;
        int compareWith = 0;

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i]>0)
            {
                hasPositive = true;
                compareWith++;
                if (A[i] != compareWith)
                {
                    return compareWith;
                }
            }            
        }

        if (hasPositive)
        {
            return A[A.Length-1] + 1;
        }
        else
        {
            return 1;
        }
    }
}
