Module Ej3_01
    Private hoy As Date = Now
    Sub Main()
        fecha()
        hora()
        Console.ReadKey()
    End Sub
    Private Sub Fecha()
        Console.WriteLine(hoy.Day & "/" & hoy.Month & "/" & hoy.Year)
    End Sub
    Private Function Hora() As Date
        Console.WriteLine(hoy.Hour & ":" & hoy.Minute & ":" & hoy.Second)
        Return Hora
    End Function
End Module
