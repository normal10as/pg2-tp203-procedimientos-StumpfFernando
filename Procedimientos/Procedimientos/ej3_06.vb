Module ej3_06
    'Elaborar un algoritmo que lea un número N, que imprima la sumatoria de los cuadrados de los
    'enteros entre 1 y N. Utilizar un método para el cálculo de la sumatoria vía parámetro por
    'referencia. Utilizar un método para validar los valores ingresados sean enteros positivos, si no
    'cumple esta condición pedir el reingreso del dato.

    Dim n As Integer
    Dim r As Integer = 0
    Sub Main()
        Do
            Console.WriteLine("Ingrese un valor: ")
            IValor(n)
            'funcion ingresar valor y validar si es positivo en ej 04
            Console.WriteLine("La sumatoria de los cuadrados enteros entre 1 y " & n & " es: " & SCuadrado(n))
        Loop Until Validar(n)
    End Sub

    Function SCuadrado(ByRef n As Integer)
        For i As Int16 = 1 To n
            If i Mod 2 = 0 Then
                r = r + Math.Pow(i, 2)
            End If
        Next
        Return r
    End Function
End Module
