Module ej3_03
    Private a, b As Int16
    Sub Main()

        Console.WriteLine("Ingrese valor a potenciar:")
        a = Console.ReadLine()

        For c = 1 To 5
            b += 1
            Console.WriteLine(P(a, b))

        Next
    End Sub
    Private Function P(ByVal a As Int16, ByVal b As Int16) As Integer
        Return Math.Pow(a, b)
    End Function
End Module