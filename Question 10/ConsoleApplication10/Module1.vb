Module Module1

    Sub Main()
        Console.Write("Enter number of terms: ")
        Dim t As Integer = Console.ReadLine()
        If (t >= 93) Then
            Console.WriteLine("WARNING: A value of 93 or more will cause the long unsigned integer to overflow, which causes security threats and also, it will" +
                              " break the program.")
            Console.WriteLine("Press Enter to continue with this disaster, you monster...") //Just wanted to point out it's (mostly) humorous and
                                                                                            //it won't cause your computer to go down in flames.
            Console.ReadLine()
        End If
        Dim i As Integer = 0
        Dim b, a, c As ULong
        b = 1
        a = 0
        While i < t
            Console.WriteLine(b.ToString())
            c = b
            b = b + a
            a = c
            i += 1
        End While
        Main()
    End Sub

End Module
