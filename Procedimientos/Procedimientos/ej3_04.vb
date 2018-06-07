Module ej3_04
    'Dados los lados A y B de un triángulo rectángulo, según el teorema de Pitágoras, el cuadrado de
    'la hipotenusa(C), es igual a la suma del cuadrado de los catetos (lados) de lo que se da la
    'siguiente fórmula :  c² = a² + b². Elaborar una función que reciba el tamaño de los lados A y B,
    'calcule y devuelva C (hipotenusa). Ingresar los valores por teclado y mostrar el resultado en
    'consola. Utilizar una función para validar los valores ingresados sean enteros positivos, si no
    'cumple esta condición pedir el reingreso del dato.

    Dim ladoa As Integer
    Dim ladob As Integer
    Sub Main()
        Console.WriteLine("Calculo de la Hipotenusa ")
        Console.WriteLine("--------------------------------------")
        Console.WriteLine("Ingrese valor de lado a: ")
        IValor(ladoa)
        Console.WriteLine("Ingrese valor de lado b: ")
        IValor(ladob)

        Console.WriteLine("Su hipotenusa es: " & Hipotenusa(ladoa, ladob))
    End Sub

    Public Sub IValor(ByRef valor As Integer)
        Do
            valor = Console.ReadLine()
        Loop Until Validar(valor)

    End Sub
    Public Function Validar(num As Integer) As Boolean
        Return num >= 0
    End Function

    Function Hipotenusa(a As Integer, b As Integer) As Double
        Return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))
    End Function

End Module
