Module Module1

    Sub Main()
        Dim w, l, h As Integer
        Console.Write("Enter length: ")
        l = Convert.ToInt32(Console.ReadLine())
        Console.Write("Enter width: ")
        w = Convert.ToInt32(Console.ReadLine())
        Console.Write("Enter height: ")
        h = Convert.ToInt32(Console.ReadLine())

        If (l = 0) Then
            Console.WriteLine("Area of triangle: " + Convert.ToString((0.5) * w * h))
        ElseIf (h = 0) And (w = l) Then
            Console.WriteLine("Area of square: " + Convert.ToString(l * w))
        ElseIf (h = 0) Then
            Console.WriteLine("Area of rectangle: " + Convert.ToString(l * w))
        End If

        Console.ReadLine()
    End Sub

End Module
