using System;

class StartUp
{
    static void Main()
    {
        string sample = "*AAAaa*SEPARATOR*zzZZZ*";
        string first = sample.Substring(0, sample.IndexOf("SEPARATOR"));
        string second = sample.Substring(sample.IndexOf("SEPARATOR") + "SEPARATOR".Length);

        Console.WriteLine(first);
        Console.WriteLine(second);
    }
}
