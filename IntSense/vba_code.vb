Option Explicit

Public Sub TestMe()

    Dim objI    As New IntSense.Demo
    
    objI.NumberBy2 = 222
    Debug.Print objI.NumberBy2
    
    objI.NumberBy3 = 100
    Debug.Print objI.NumberBy3
    
    Debug.Print objI.TestString("vit!")
    
End Sub
