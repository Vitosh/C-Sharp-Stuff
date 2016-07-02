using System;
using System.Collections.Generic;

delegate void PrintMeInfo(int number);
delegate int Calculations(int first_number, int second_number, int multiplier);

class DelegateTest
{
    public static int SumAndMultiply1(int A, int B, int C)
    {
        Console.WriteLine("Without brackets for {0}+{1}*{2}.",A,B,C);
        return A + B * C;
    }

    public static int SumAndMultiply2(int A, int B, int C)
    {
        Console.WriteLine("With brackets for {0}+{1}*{2}.", A, B, C);
        return (A + B) * C;
    }

    public static int SumAndMultiply3(int A, int B, int C)
    {
        Console.WriteLine("Just multiplying all of them.", A, B, C);
        return A * B * C;
    }

    public void BiggerThanTen(int number)
    {
        string result = "";
        if (number>10)
        {
            result = "Bigger than 10.";
        } else {
            result = "Not bigger than 10.";
        }
        Console.WriteLine(result);
    }

    public static void IsOdd(int number)
    {
        string result = "";

        if (number % 2 == 1)
        {
            result = "It is odd.";    
        } else {
            result = "It is not odd";
        }
        Console.WriteLine(result);
    }

    public static void IsDividableByTen (int number)
    {
        string result = "";

        if (number % 10 == 0)
        {
            result = "Number is dividable by ten.";
        } else {
            result = "Number is not dividable by ten.";
        }
        Console.WriteLine(result);
    }

    public static void ShowMeTheNumber (int number)
    {
        Console.WriteLine("The number is {0}.",number);
    }
        
    static void Main()
    {
        PrintMeInfo info = null;
        info += new PrintMeInfo(ShowMeTheNumber);
        info += new PrintMeInfo(DelegateTest.IsOdd);
        info += new PrintMeInfo(IsDividableByTen);

        DelegateTest additional_info = new DelegateTest();
        info += new PrintMeInfo(additional_info.BiggerThanTen); //The method is not static!

        Calculations calc = null;
        calc += new Calculations(DelegateTest.SumAndMultiply1);
        calc += new Calculations(DelegateTest.SumAndMultiply2);

        List<Calculations> my_list = new List<Calculations> { SumAndMultiply1, SumAndMultiply2 , SumAndMultiply3};

        foreach (var my_result in my_list)
        {
            Console.WriteLine(my_result(5,6,7));
        }

        info(25);
    }
}
