Imports System

Module Program
    Sub Main()
        Dim x As Double
        Dim factorial As Double
        Dim numero As Double
        Dim Esperar As Char
        While Esperar <> "z" And Esperar <> "Z"
            Try
                factorial = 1
                Console.Clear()
                'formula para calculo n! = 1 x 2 x 3 x 4 x 5 x ... x (n-1) x n
                Console.Write("Ingresar un numero entero positivo para calcular el factorial:")
                Console.WriteLine()
                Console.WriteLine()
                numero = Console.ReadLine()

                If numero < 0 Then
                    Console.WriteLine()
                    Console.WriteLine("Solamente se permite el 0 y enteros positvos")

                ElseIf numero >= 0 Then
                    For x = 1 To numero Step 1
                        factorial = factorial * x
                    Next
                    Console.WriteLine()
                    Console.Write("El factorial de " & numero & " es = ")
                    Console.WriteLine()
                    Console.WriteLine()
                    Console.WriteLine(factorial)
                    Console.WriteLine()
                End If

                If (factorial >= 1) Then
                    Dim indice = 1
                    Dim cantidad As Integer = 0
                    Dim resultado As String = ""
                    While (indice <= factorial)
                        If (indice Mod 4 = 0) Then
                            resultado = resultado + indice.ToString + ","
                            cantidad = cantidad + 1
                        End If
                        indice = indice + 1
                    End While
                    Console.WriteLine("Numeros multiplos de 4 entre 0 y " & factorial & " = ")
                    Console.WriteLine()
                    Console.WriteLine(resultado)
                    Console.WriteLine()
                    Console.WriteLine("La cantidad de numeros multiplos de 4 entre 0 y " & factorial & " es de = ")
                    Console.WriteLine()
                    Console.WriteLine(cantidad.ToString)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            Console.WriteLine()
            Console.Write("Presione la letra z o Z para salir del programa")
            Esperar = Console.ReadKey.KeyChar
        End While
    End Sub
End Module
