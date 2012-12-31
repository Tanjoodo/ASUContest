Module Module1

    Sub Main()
        Console.Write("Enter number of 3 digits: ")
        Dim n As ULong = Console.ReadLine()
        Dim s As String = n.ToString()
        Dim sa() As Char = s.ToCharArray()
        Console.WriteLine("The first number  is: " + sa(0).ToString())
        Console.WriteLine("The second number is: " + sa(1).ToString())
        Console.WriteLine("The third  number is: " + sa(2).ToString())
        Main()
    End Sub

End Module
