Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numeroEntrante As String = Label2.Text
        numeroEntrante = Restar1(numeroEntrante)
        Label2.Text = numeroEntrante
    End Sub
    Function Restar1(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevoTexto As String
        numero = numero - 1
        nuevoTexto = numero.ToString()
        Return nuevoTexto
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim numeroEntrante As String = Label2.Text
        numeroEntrante = Sumar1(numeroEntrante)
        Label2.Text = numeroEntrante
    End Sub
    Function Sumar1(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevoTexto As String
        numero = numero + 1
        nuevoTexto = numero.ToString()
        Return nuevoTexto
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim numeroEntrante As String = Label4.Text
        numeroEntrante = Restar2(numeroEntrante)
        Label4.Text = numeroEntrante
    End Sub
    Function Restar2(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevoTexto As String
        numero = numero - 1
        nuevoTexto = numero.ToString()
        Return nuevoTexto
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim numeroEntrante As String = Label4.Text
        numeroEntrante = Sumar2(numeroEntrante)
        Label4.Text = numeroEntrante
    End Sub
    Function Sumar2(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevoTexto As String
        numero = numero + 1
        nuevoTexto = numero.ToString()
        Return nuevoTexto
    End Function
End Class
