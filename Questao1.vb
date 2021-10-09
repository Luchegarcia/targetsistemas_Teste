Public Class Questao1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim indice, soma, k As Integer

        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            soma = 0
            k = 0
        End If

        indice = 13
        soma = TextBox1.Text
        k = TextBox2.Text

        While k < indice
            k = k + 1
            soma = soma + k
        End While
        TextBox3.Text = soma

    End Sub

End Class