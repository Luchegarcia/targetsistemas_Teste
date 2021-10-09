Public Class Questao5

    Dim var As String
    Dim reverso As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = Len(TextBox1.Text) To 1 Step -1
            var = Mid(TextBox1.Text, i, 1)
            reverso = reverso & var
        Next
        TextBox2.Text = reverso
    End Sub
End Class