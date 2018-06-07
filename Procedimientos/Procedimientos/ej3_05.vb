Module ej3_05
    '    El volumen de un cilindro se calcula multiplicando la constante Pi (π=3.14159265) por el
    'cuadrado del radio de la base(r) por la altura(h) de lo que se da la siguiente fórmula: v = πr²h.
    'Elaborar una función que lea el radio de la base y la altura de un cilindro, que calcule y
    'devuelva el volumen. Ingresar los valores por teclado y mostrar el resultado en consola. Utilizar
    'un procedimiento para validar los valores ingresados sean positivos, si no cumple esta condición
    'pedir el reingreso del dato.
    Dim radio, altura As Double
    Dim p As Decimal = 3.14159265

    Sub Main()
        Console.WriteLine("Ingrese valor de radio: ")
        IValor(radio)
        Console.WriteLine("Ingrese valor de altura: ")
        IValor(altura)
        Console.WriteLine("****************************" + vbCr + "El volumen del cilindro es: " & Vo(radio, altura))
        'funcion ingresar valor y validar si es positivo en ej 04
    End Sub

    Function Vo(radio As Double, altura As Double)
        Return p * Math.Pow(radio, 2) * altura
    End Function
End Module
