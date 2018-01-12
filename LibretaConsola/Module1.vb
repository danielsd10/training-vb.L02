Module Module1

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
        'Console.WriteLine(Nombres(5)) 'María
        'Console.WriteLine(Telefonos(0)) '958933345

        'Bucles
        'Mostrar todos los nombres
        Dim i As Integer = 0 'contador

        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Do While")
        Console.ForegroundColor = ConsoleColor.Gray
        Do While i < Nombres.Length
            Console.WriteLine(Nombres(i))
            If i = 6 Then 'salir despues de mostrar el elemento con índice 6
                Exit Do
            End If
            i = i + 1
        Loop

        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Do Until")
        Console.ForegroundColor = ConsoleColor.Gray
        i = 0
        Do Until i = Nombres.Length
            Console.WriteLine(Nombres(i))
            i = i + 1
        Loop

        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("While")
        Console.ForegroundColor = ConsoleColor.Gray
        i = 0
        While i < Nombres.Length
            Console.WriteLine(Nombres(i))
            i = i + 1
        End While

        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Do .. Loop Until")
        Console.ForegroundColor = ConsoleColor.Gray
        i = 0
        Do
            Console.WriteLine(Nombres(i))
            i = i + 1
        Loop Until i = Nombres.Length

        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Do .. Loop While")
        Console.ForegroundColor = ConsoleColor.Gray
        i = 0
        Do
            Console.WriteLine(Nombres(i))
            i = i + 1
        Loop While i < Nombres.Length

        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("For")
        Console.ForegroundColor = ConsoleColor.Gray
        For i = 0 To Nombres.Length - 1 Step 2 ' sólo elementos impares
            Console.WriteLine(Nombres(i))
        Next

        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("For Each")
        Console.ForegroundColor = ConsoleColor.Gray
        For Each Nombre As String In Nombres
            Console.WriteLine(Nombre)
        Next

        '--------
        'Matrices
        '--------

        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("Matrices")

        Dim Contactos(3, 1) As String
        Dim x As Integer

        'Solicitar 10 nombres y apellidos y colocarlos en la matriz
        For x = 0 To Contactos.GetLongLength(0) - 1
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine("Contacto #{0}", x + 1)
            Console.ForegroundColor = ConsoleColor.Gray
            Console.Write("Ingrese el nombre  : ")
            Contactos(x, 0) = Console.ReadLine()
            Console.Write("Ingrese el apellido: ")
            Contactos(x, 1) = Console.ReadLine()
        Next

        'Mostrar los 10 contactos de la forma: Contacto #: Apellido, Nombre
        Console.ForegroundColor = ConsoleColor.White
        For x = 0 To Contactos.GetLongLength(0) - 1
            Console.WriteLine("Contacto #{0}: {1}, {2}", x + 1, Contactos(x, 1), Contactos(x, 0))
        Next

        Console.ReadLine()

    End Sub

End Module
