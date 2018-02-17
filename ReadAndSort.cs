using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class Startup
{
    static void Main()
    {
        string keyAlphabet = "abc~WITHSOMEADDITIONALLCHARACTERS~yz_";
        string keyInput = File.ReadAllText(@"C:\Input.txt");
        Dictionary<string, long> countDic= new Dictionary<string, long>();

        for (int i = 0; i < keyAlphabet.Count(); i++)
        {
            countDic.Add(keyAlphabet[i].ToString(), 0);
        }

        for (int i = 0; i < keyInput.Count(); i++)
        {
            if (countDic.ContainsKey(keyInput[i].ToString()))
            {
                long countDicSize = countDic[keyInput[i].ToString()];
                countDic[keyInput[i].ToString()] = countDicSize + 1;
            }
        }
        var ordered = countDic.OrderBy(x => x.Value).Reverse();
        Console.WriteLine(String.Join("",ordered.ToArray()));
    }
}
