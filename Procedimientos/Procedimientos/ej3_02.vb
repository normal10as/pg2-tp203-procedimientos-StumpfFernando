Module ej3_02
    Public fecha = Date.Now
    Public e As Int16
    Sub Main()
        Console.WriteLine(N(fecha, e))
        Console.ReadKey()
    End Sub
    Private Function N(fecha As Date, e As Int16) As Date
        Console.WriteLine(fecha)
        Console.WriteLine("Ingrese los dias a sumar: ")
        e = Console.ReadLine()
        fecha = fecha.AddDays(e)
        Return fecha
    End Function
End Module
