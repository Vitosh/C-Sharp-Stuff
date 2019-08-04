using System;
class Startup
{
    static void Main()
    {
        string inputText = "kkbkannabannavannabb";
        int maxLength = 1;
        int length = inputText.Length;
        int[,] matrix = new int[length,length];
        int startAt = 1;

        //for 1:
        for (int i = 0; i < length; i++)
        {
            matrix[i, i] = 1;
        }

        //for 2:
        for (int i = 0; i < length-1; i++)
        {
            if (inputText[i]==inputText[i+1])
            {
                maxLength = 2;
                startAt = i;
                matrix[i,i+1] = 1;
            }
        }

        //for >2:
        for (int k = 3; k <= length; k++)
        {
            for (int startingIndex = 0; startingIndex < length-k+1; startingIndex++)
            {
                int endingIndex = startingIndex + k - 1;
                if (matrix[startingIndex + 1, endingIndex-1] == 1 && inputText[startingIndex] ==inputText[endingIndex])
                {
                    Console.WriteLine(startingIndex+1 +" " + inputText[startingIndex]);
                    matrix[startingIndex, endingIndex] = 1;
                    maxLength = k;
                    startAt = startingIndex;
                }
            }
        }
        Console.WriteLine(inputText.Substring(startAt,maxLength));
    }
}
