using System;
using System.Collections.Generic;

class PrintOneLineDictionary
{
    static void Main()
    {
        Console.WriteLine(DateTime.Now.ToString("yyyyMMdd_hhmmss"));
        var myDict = new Dictionary<string, string> {{ "a1", "b1" }, { "c1", "d1" },{ "a2", "b2" }, { "c2", "d2" },{ "a3", "b3" }, { "c3", "d3" },{ "a4", "b4" }, { "c4", "d4" },{ "a10", "b100" }, { "c10", "d100" }, { "a20", "b200" }, { "c20", "d200" },{ "a30", "b300" }, { "c30", "d300" },{ "a40", "b400" }, { "c40", "d400" },};

        //var myDict = new Dictionary<string, string> {
        //    { "a1", "b1" }, { "c1", "d1" },
        //    { "a2", "b2" }, { "c2", "d2" },
        //    { "a3", "b3" }, { "c3", "d3" },
        //    { "a4", "b4" }, { "c4", "d4" },
        //    { "a10", "b100" }, { "c10", "d100" },
        //    { "a20", "b200" }, { "c20", "d200" },
        //    { "a30", "b300" }, { "c30", "d300" },
        //    { "a40", "b400" }, { "c40", "d400" },
        //};

        foreach (var item in myDict.Keys)
        {
            Console.WriteLine(myDict[item]);
            Console.WriteLine(item + "\n");
        }

    }
}
