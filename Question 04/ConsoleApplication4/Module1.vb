Module Module1

    Sub Main()
        Console.Write("Enter how many numbers: ")
        Dim i As Integer = Console.ReadLine()
        Console.WriteLine("Enter your numbers:")
        Dim index As Integer = 0
        Dim nums((i - 1)) As Integer
        While index < i
            nums(index) = Convert.ToInt32(Console.ReadLine())
            index += 1
        End While
        Dim sum, av As Integer
        i = 0
        While i < nums.Length
            sum += nums(i)
            i += 1
        End While
        av = sum / i
        Console.WriteLine("Sum = " + sum.ToString() + ", Average = " + av.ToString())
        Console.ReadLine()
    End Sub

End Module
