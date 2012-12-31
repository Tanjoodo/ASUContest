Module Module1

    Sub Main()
        Console.Write("Enter X: ")
        Dim x As Integer = Console.ReadLine()
        Dim nums(x - 1) As Integer
        Dim current As Integer = 1
        Dim i As Integer = 0
        Dim index As Integer = 0
        While i < x
            If Not (current Mod 2 = 0) Then
                nums(index) = current
                index += 1
            End If
            i += 1
            current += 1
        End While
        Dim s As String = ""
        Dim stringIndex As Integer = 0
        Dim isStringComplete As Boolean = False
        i = 0
        Console.WriteLine("Odd numbers are:")
        While i < index
            If (nums(i) = 0) Then
                i += 1

            ElseIf (stringIndex = 5) Then
                Console.WriteLine(s)
                s = ""
                stringIndex = 0
                isStringComplete = True
            ElseIf (stringIndex = 4) Then
                s += nums(i).ToString()
                stringIndex += 1
            Else
                If (index - i = 1) Then
                    s += nums(i).ToString

                Else
                    s += nums(i).ToString() + ","
                End If
                stringIndex += 1
                isStringComplete = False
            End If

            If (isStringComplete = False) Then i += 1
        End While
        If Not (s.Length = 0) Then
            Console.WriteLine(s)
        End If
        Console.ReadLine()
    End Sub

End Module
