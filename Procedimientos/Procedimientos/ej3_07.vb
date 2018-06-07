Module ej3_07
    'Crear una función sobrecargada capaz de operar dos, tres y cuatro valores de acuerdo a un
    'argumento que debe ser una enumeración para las siguientes operaciones: suma, resta,
    'multiplicación y división. También debe haber una versión de la función que no reciba la
    'enumeración y como operación predeterminada resuelva con una suma. Invocarla desde el
    'módulo main probando las diferentes alternativas y mostrando los resultados por consola. Ej.:
    'calcular(operaciones.suma, 5, 8). Minimizar la repetición de código



    Enum Op As Byte
        s
        r
        d
        m
    End Enum
    Dim a, b As Integer
    Sub Main()
        Dim x As Int16

        Console.WriteLine("Elija la operacion a realizar: " & vbCrLf & "1 - SUMA" & vbCrLf & "2 - RESTA" & vbCrLf & "3 - DIVISION" & vbCrLf & "4 - MULTIPLICACION")
        x = Console.ReadLine()
        Ing(a)
        Ing(b)



        If x = 1 Then
            Console.WriteLine("SUMA: " & Calcular(Op.s, a, b))

        ElseIf x = 2 Then
            Console.WriteLine("RESTA: " & Calcular(Op.r, a, b))

        ElseIf x = 3 Then
            Console.WriteLine("DIVISION: " & Calcular(Op.d, a, b))

        ElseIf x = 4 Then
            Console.WriteLine("MULTIPLICACION: " & Calcular(Op.m, a, b))

        Else
            Console.WriteLine("Invalido")

        End If

        'ME ESTA DEJANDO LOCO



    End Sub
    Sub Ing(ByRef valor As Integer)
        Console.WriteLine("Ingrese valor a operar")
        valor = Console.ReadLine()
    End Sub
    Function Calcular(operaciones As Op, a As Integer, b As Integer) As Integer
        Select Case operaciones
            Case Op.s
                Return a + b
            Case Op.r
                Return a - b
            Case Op.d
                Return a / b
            Case Op.m
                Return a * b
        End Select
        Return operaciones
    End Function

End Module
