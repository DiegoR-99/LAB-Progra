Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numeroEntrante As String = Label2.Text
        numeroEntrante = Disminuir(numeroEntrante)
        Label2.Text = numeroEntrante
    End Sub
    Function Disminuir(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevoTexto As String
        numero = numero - 1
        nuevoTexto = numero.ToString()
        Return nuevoTexto
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim numeroEntrante As String = Label2.Text
        numeroEntrante = Aumentar(numeroEntrante)
        Label2.Text = numeroEntrante
    End Sub
    Function Aumentar(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevoTexto As String
        numero = numero + 1
        nuevoTexto = numero.ToString()
        Return nuevoTexto
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim numeroEntrante As String = Label4.Text
        numeroEntrante = Disminuir(numeroEntrante)
        Label4.Text = numeroEntrante
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim numeroEntrante As String = Label4.Text
        numeroEntrante = Aumentar(numeroEntrante)
        Label4.Text = numeroEntrante
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim txtA = Label2.Text
        Dim numeroA = Int32.Parse(txtA)
        Dim txtB = Label4.Text
        Dim numeroB = Int32.Parse(txtB)
        Dim resultadoSuma = Suma(numeroA, numeroB)
        'MsgBox(resultadoSuma)
        Label5.Text = "EL RESULTADO DE A + B ES " & resultadoSuma.ToString
    End Sub
    Function Suma(numeroA As Integer, numerob As Integer) As Integer
        Dim resultado As Integer
        resultado = numeroA + numerob
        Return resultado
    End Function
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim txtA = Label2.Text
        Dim numeroA = Int32.Parse(txtA)
        Dim txtB = Label4.Text
        Dim numeroB = Int32.Parse(txtB)
        Dim resultadoResta = Resta(numeroA, numeroB)
        Label5.Text = "EL RESULTADO DE A - B ES " & resultadoResta.ToString
    End Sub
    Function Resta(numeroA As Integer, numerob As Integer) As Integer
        Dim resultado As Integer
        resultado = numeroA - numerob
        Return resultado
    End Function
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim txtA = Label2.Text
        Dim numeroA = Int32.Parse(txtA)
        Dim txtB = Label4.Text
        Dim numeroB = Int32.Parse(txtB)
        Dim resultadoMultiplicacion = Multiplicacion(numeroA, numeroB)
        Label5.Text = "EL RESULTADO DE A * B ES " & resultadoMultiplicacion.ToString
    End Sub
    Function Multiplicacion(numeroA As Integer, numerob As Integer) As Integer
        Dim resultado As Integer
        resultado = numeroA * numerob
        Return resultado
    End Function
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim txtA = Label2.Text
        Dim numeroA = Int32.Parse(txtA)
        Dim txtB = Label4.Text
        Dim numeroB = Int32.Parse(txtB)
        Dim resultadoDivision = Division(numeroA, numeroB)
        Label5.Text = "EL RESULTADO DE A / B ES " & resultadoDivision.ToString
    End Sub
    Function Division(numeroA As Integer, numerob As Integer) As Double
        Dim resultado As Double
        resultado = numeroA / numerob
        Return resultado
    End Function
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Label2.Text = "0"
        Label4.Text = "0"
        Label5.Text = "EL RESULTADO ES:"
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()
        If (True) Then
        Else
        End If
    End Sub
End Class