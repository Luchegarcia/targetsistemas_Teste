Public Class Questao2

    Dim i As Integer
    Dim fibo(15) As Integer
    Dim fibo2(15) As Integer
    Dim vl As Integer
    Dim vl2 As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer
        num = Integer.Parse(TextBox1.Text)

        For i = 1 To 15 Step 1

            fibo(i) = 5 * num * num + 4
            fibo2(i) = 5 * num * num - 4

            vl = Math.Sqrt(fibo(i))
            vl2 = Math.Sqrt(fibo2(i))

            If vl * vl = fibo(i) Or vl2 * vl2 = fibo2(i) Then
                Label3.Visible = True
                Label3.Text = "Número foi encontrado"
                MsgBox("Numero " & num & " foi encontrado na sequência de Fibonacci")
                Exit Sub
            Else
                Label3.Visible = True
                Label3.Text = "Número não foi encontrado"
                Label3.Text = "Numero " & num & "não foi encontrado na sequência de Fibonacci"

            End If

        Next

    End Sub

End Class