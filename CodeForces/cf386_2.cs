'http://codeforces.com/contest/746/problem/B

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CodifyMe
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int start = 1;
        string word = Console.ReadLine();
        string result = "";

        if (n % 2 == 0)
        {
            start = 0;
        }

        for (int i = n-1; i >= 0; i-=2)
        {
            result =  word[i]+ result;
        }

        for (int i = start; i < n-1; i+=2)
        {
            result = word[i] + result;
        }
        Console.WriteLine(result);
    }
}

'VBA Code here:
Option Explicit

Public Function str_locate_median(Optional my_test As String = "testme") As String

    Dim l_median        As Long
    Dim l_position      As Long
    
    l_position = CLng(Len(my_test) / 2 + 0.1)
    str_locate_median = Mid(my_test, l_position, 1)
    
End Function

Public Function lng_locate_median(Optional my_test As String = "testme") As Long
    
    lng_locate_median = CLng(Len(my_test) / 2 + 0.1)
    
End Function

Public Sub SmallTest()

    Dim l_counter       As Long
    Dim l_len           As Long
    Dim str_word        As String: str_word = "vitosh"
    Dim str_new_word    As String
    Dim str_char        As String

    For l_counter = 1 To Len(str_word)
        str_char = str_locate_median(str_word)
        str_new_word = str_char & str_new_word
        str_word = Left(str_word, lng_locate_median(str_word) - 1) & Right(str_word, Len(str_word) - lng_locate_median(str_word))
    Next l_counter

    str_new_word = StrReverse(str_new_word)
    Debug.Print str_new_word

End Sub

Public Sub TestMe()

    Dim str_word        As String: str_word = "toisvh"
    Dim str_new_word    As String
    Dim l_counter       As Long
    Dim l_counter2      As Long

    For l_counter = Len(str_word) To 1 Step -2
        str_new_word = Mid(str_word, l_counter, 1) & str_new_word
    Next l_counter

    For l_counter = IIf(Len(str_word) Mod 2, 2, 1) To Len(str_word) - 1 Step 2
        str_new_word = Mid(str_word, l_counter, 1) & str_new_word
    Next l_counter

    Debug.Print str_new_word

End Sub
