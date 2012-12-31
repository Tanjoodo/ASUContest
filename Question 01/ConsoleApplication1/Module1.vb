Module Module1

    Sub Main()
        Console.Write("Enter operation: ")
        Dim op As String = Console.ReadLine()
        Console.Write("Enter number 1: ")
        Dim n1, n2 As Double
        Try
            n1 = Console.ReadLine()
        Catch e As Exception
            Console.WriteLine("y u enter text not number?")
            Console.ReadLine()
            Main()
        End Try
        Console.Write("Enter number 2: ")
        Try
            n2 = Console.ReadLine()
        Catch e As Exception
            Console.WriteLine("y u no enter number?")
            Main()
        End Try

        If (op = "+") Then
            Console.WriteLine("Result is: " + Convert.ToString((n1 + n2)))
        ElseIf (op = "-") Then
            Console.WriteLine("Result is: " + Convert.ToString((n1 - n2)))
        Else
            Console.WriteLine("Please enter an appropriate operator.")
            Main()
        End If
        Console.ReadLine()
    End Sub

End Module
