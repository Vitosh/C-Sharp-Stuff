using System;

class StartUp
{
    static void Main()
    {
        string sample = "*AAAaa*SEPARATOR*zzZZZ*";
        string first = sample.Substring(0, sample.IndexOf("SEPARATOR"));
        string second = sample.Substring(sample.IndexOf("SEPARATOR") + "SEPARATOR".Length);
        Console.WriteLine("{0} - {1}",first,second);

        sample = "111SEPARATOR222SEPARATOR333SEPARATOR333SEPARATOR999";
        first = sample.Split("SEPARATOR".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)[0];
        second = sample.Split("SEPARATOR".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)[1];
        string lastOne = sample.Split("SEPARATOR".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            [sample.Split("SEPARATOR".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Length-1];
        Console.WriteLine("{0} - {1} - {2}", first, second, lastOne);
    }
}
