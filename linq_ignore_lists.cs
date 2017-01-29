using System;
using System.Collections.Generic;
using System.Linq;


class Sample
{
    static void Main()
    {
        List<string> lstStrMyList = new List<string>() { "Vityata","Vitosh","Academy","MyAcademy","Vitosh", "Pesho", "Gosho"};
        List<string> lstStrIgnore = new List<string>() { "Pesho", "Gosho", "Atanas", "Academy" };
        string strIgnored = "Academy";

        List<string> lstStrFiltered = lstStrMyList.Distinct().Where(x => x != strIgnored).ToList();
        Console.WriteLine("List 1:");
        foreach (var item in lstStrFiltered)
        {
            Console.WriteLine(item);
        }


        List<string> lstStrFiltered2 = lstStrMyList.Distinct().Where(x => !lstStrIgnore.Any(e => x.Contains(e))).ToList();
        Console.WriteLine("List 2:");
        foreach (var item in lstStrFiltered2)
        {
            Console.WriteLine(item);
        }
    }
}
