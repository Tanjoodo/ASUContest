Module Module1

    Sub Main()
        Console.Write("Enter number of terms: ")
        Dim t As Integer = Convert.ToInt32(Console.ReadLine())
        Dim i As Integer = 0
        Dim current As Decimal = 1
        Dim nums(t - 1) As Decimal
        While i < t
            nums(i) = current
            current /= 2
            i += 1
        End While
        i = 0
        Dim sum As Decimal
        While i < t
            sum += nums(i)
            i += 1
        End While
        Console.WriteLine("Sum is: " + sum.ToString())
        Console.ReadLine()
    End Sub

End Module
