Module Module1

    Sub Main()
        Console.Write("Enter X: ")
        Dim x As Integer = Console.ReadLine()
        Dim i As Integer = 0
        Dim nums(x - 1) As Integer
        Console.WriteLine("Enter the numbers:")
        While i < x
            nums(i) = Console.ReadLine()
            i += 1
        End While
        Dim index As Integer = 0
        Dim sum As Integer = 0
        Dim y As Integer
        While index < x
            If (nums(index) <= 100) And (nums(index) >= 50) Then
                sum += nums(index)
                y += 1
            End If
            index += 1
        End While
        If Not (y = 0) Then
            Dim av As Integer = sum / y
            Console.WriteLine("Average for selected numbers is: " + av.ToString())
        Else
            Console.WriteLine("Sorry. Can't divide by zero, yet!")
        End If
        Console.ReadLine()
    End Sub

End Module
