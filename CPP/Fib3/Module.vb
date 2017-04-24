Option Explicit
Declare Function fib3 Lib _
    "C:\~\ject3.dll" _
    (ByRef x As Long) As Long

Public Sub TestMe()

    Dim i As Long
    
    For i = 0 To 30
        Debug.Print fib3(i)
    Next i

End Sub
