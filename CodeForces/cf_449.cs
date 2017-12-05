using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Startup
{
    static void Main()
    {
        List <int> inputList = ReadLineAndParseToList();
        int n = inputList[0];
        int m = inputList[1];
        string s = Console.ReadLine();
        
        for (int i = 0; i < m; i++)
        {
            List<string> charList = ReadLineAndParseToListOfChars();
            int fromV = int.Parse(charList[0]) - 1;
            int toV = int.Parse(charList[1]) - 1;
            string lookFor = charList[2];
            string replaceWith = charList[3];

            for (int k = fromV; k <= toV; k++)
            {                
                if (s[k].ToString().Equals(lookFor))
                {
                    System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(s);
                    strBuilder[k] = char.Parse(replaceWith);
                    s = strBuilder.ToString();
                }
            }
            
        }
        Console.WriteLine(s);

    }
    public static List<string> ReadLineAndParseToListOfChars()
    {
        return Console.ReadLine().Split().ToList();
    }

    public static List<int> ReadLineAndParseToList()
    {
        return Console.ReadLine().Split().Select(int.Parse).ToList();
    }

    static int[] ReadLineAndParseToArray()
    {
        return Console.ReadLine().Split().Select(int.Parse).ToArray();
    }

    public static int[,] TransposeMaxtrix(int[,] matrix)
    {
        int w = matrix.GetLength(0);
        int h = matrix.GetLength(1);

        int[,] result = new int[h, w];

        for (int i = 0; i < w; i++)
        {
            for (int j = 0; j < h; j++)
            {
                result[j, i] = matrix[i, j];
            }
        }
        return result;
    }
}
