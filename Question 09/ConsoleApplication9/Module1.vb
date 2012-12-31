Module Module1

    Sub Main()
        Console.Write("Enter number of lines: ")
        Dim l As Integer = Console.ReadLine()
        If (l >= 79) Then
            Console.WriteLine("WARNING: A value of 79 or more will lead to unexpected, non trianglulary results. Don't expect sunshine and rainbows.")
            Console.Write("Press Enter to continue with this disaster...")
            Console.ReadLine()
        End If
        Dim i As Integer = 1
        Dim s As String = ""
        Dim sp As Integer = 1
        While i < l
            If (i = 1) Then
                Console.WriteLine("*")
            Else
                s = "*"
                sp = 1
                While sp < i
                    s += " "
                    sp += 1
                End While
                s += "*"
                Console.WriteLine(s)

            End If
            i += 1
        End While
        i = 1
        s = "* "
        While i < l
            s += "*"
            i += 1
        End While

        Console.WriteLine(s)
        Main()
    End Sub

End Module
