Module Module1

    Sub Main()
        Console.Write("Enter your grade:")
        Dim g As Integer
        g = Console.ReadLine()
        If (g >= 80) Then
            Console.WriteLine("EXCELLENT")
        ElseIf (g >= 70) Then
            Console.WriteLine("GOOD")
        ElseIf (g >= 60) Then
            Console.WriteLine("FAIR")
        Else
            Console.WriteLine("FAIL")
        End If
        Console.ReadLine()
    End Sub


End Module
