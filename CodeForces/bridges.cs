using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Startup
{
    static void Main()
    {
        List<int> liInput = ReadLineAndParseToList();
        List<string> liStrOutput = new List<string>(new string[liInput.Count]);
        List<string> liStrResults = new List<string>();
        int intLastPosition = 0;
        liStrOutput[0] = liInput[0].ToString();

        for (int i = 1; i < liInput.Count; i++)
        {
            liStrOutput[i] =  liInput[i].ToString();
            for (int j = intLastPosition; j < i; j++)
            {
                if (liInput[j]==liInput[i])
                {
                    intLastPosition = i;
                    liStrOutput[i] = "X";
                    liStrOutput[j] = "X";
                    break;
                }
            }    
        }

        //Reverse the X
        for (int i = 0; i < liInput.Count; i++)
        {
            if (liStrOutput[i] == "X")
            {
                liStrResults.Add(liInput[i].ToString());
            }
            else
            {
                liStrResults.Add("X");
            }
        }        
        Console.WriteLine(string.Join(" ", liStrResults.ToList()));
    }

    public static List<int> ReadLineAndParseToList()
    {
        return Console.ReadLine().Split().Select(int.Parse).ToList();
    }

}
