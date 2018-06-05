Module ej3_03
    Dim a As Int16 = 1
    Sub Main()
        Console.WriteLine("0 = FIN")
        Do While a <> 0
            P()
        Loop
    End Sub
    Private Function P() As Integer
        Console.WriteLine("Ingrese un numero a potenciar: ")
        a = Console.ReadLine()
        Console.WriteLine("{0}^2={1} {0}^3={2} {0}^4={3} {0}^5={4} {0}^6={5}", a, a ^ 2, a ^ 3, a ^ 4, a ^ 5, a ^ 6)
        Return P
    End Function
End Module
