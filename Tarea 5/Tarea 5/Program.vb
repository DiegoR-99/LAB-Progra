Imports System

Module Program
    Sub Main()
        Dim i, j, n As Double
        Dim Esperar As Char
        While Esperar <> "z" And Esperar <> "Z"
            Try
                j = 1
                Console.Clear()
                'formula para calculo n! = 1 x 2 x 3 x 4 x 5 x ... x (n-1) x n
                Console.Write("Ingresar un numero entero positivo para calcular el factorial:")
                Console.WriteLine()
                Console.WriteLine()
                n = Console.ReadLine()
                For i = 1 To n Step 1
                    j = j * i
                Next
                Console.WriteLine()
                Console.Write("El factorial de " & n & " es = ")
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine(j)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            Console.WriteLine()
            Console.Write("Presione la letra z o Z para salir del programa")
            Esperar = Console.ReadKey.KeyChar
        End While
    End Sub
End Module
