Module Module1

    Sub Main()
        Console.Write("Enter number of feet: ")
        Dim f, i, c As Decimal
        f = Console.ReadLine()
        i = f * 12
        c = i * 2.54
        Console.WriteLine(f.ToString() + " feet = " + Convert.ToString(Math.Round(i, 3)) + " in, " + _
                          Convert.ToString(Math.Round(c, 3)) + " cm, " + Convert.ToString(Math.Round((c / 100), 3)) + _
                          " m, " + Convert.ToString(Math.Round((f / 3), 3)) + " yard")
        Console.ReadLine()


    End Sub

End Module
