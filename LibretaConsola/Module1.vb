﻿Module Module1

    Sub Main()

        ' Declarar arreglo con el máximo número de índice
        Dim Nombres(9) As String ' 10 elementos
        Dim Telefonos() As String = {"958933345", "982884632", "957224765"} ' 3 elementos

        'Asignar valores
        Nombres(0) = "Antonio"
        Nombres(1) = "Carlos"
        Nombres(2) = "Flor"
        Nombres(3) = "Gabriel"
        Nombres(4) = "Juan"
        Nombres(5) = "María"
        Nombres(6) = "Olga"
        Nombres(7) = "Pedro"
        Nombres(8) = "Sandra"
        Nombres(9) = "Victor"

        'Mostrar un elemento
        Console.WriteLine(Nombres(5)) 'María
        Console.WriteLine(Telefonos(0)) '958933345

        Console.ReadLine()

    End Sub

End Module
