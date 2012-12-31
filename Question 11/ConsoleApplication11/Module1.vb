Module Module1

    Sub Main()
        Console.Write("Enter number of 3 digits: ")
        Dim n As Integer = Console.ReadLine()
        Dim s As String = n.ToString()
        Dim sa() As Char = s.ToCharArray()
        System.Array.Reverse(sa)
        Console.WriteLine("The Inverse number is: " + sa(0).ToString() + sa(1).ToString() + sa(2).ToString())
        Main()
    End Sub

End Module
