Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n = TextBox1.Text
        Dim i, j As Integer
        'formula para calculo n! = 1 x 2 x 3 x 4 x 5 x ... x (n-1) x n
        j = 1
        For i = 1 To n Step 1
            j = j * i
            Label3.Text = j.ToString
        Next
    End Sub
End Class
