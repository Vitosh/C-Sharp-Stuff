using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Startup
{
    static void Main()
    {
        List<BigInteger> inputList = ReadLineAndParseToList();
        BigInteger k = inputList[0];
        BigInteger p = inputList[1];
        BigInteger sumOfK = 0;

        for (BigInteger i = 1; i <= k; i++)
        {
            sumOfK += ReverseAndMake(i);
        }

        Console.WriteLine(sumOfK%p);
    }

    public static BigInteger ReverseAndMake(BigInteger intS)
    {
        string s = intS.ToString();
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return BigInteger.Parse(s + new string(charArray));
    }

    public static List<BigInteger> ReadLineAndParseToList()
    {
        return Console.ReadLine().Split().Select(BigInteger.Parse).ToList();
    }

}
