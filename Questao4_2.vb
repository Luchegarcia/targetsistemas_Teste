Public Class Questao4_2
    Private Sub Questao4_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Percentual()
        FormatoMoeda()

    End Sub
    Sub Percentual()

        Dim vl1 As Decimal
        Dim vl2 As Decimal
        Dim vl3 As Decimal
        Dim vl4 As Decimal
        Dim vl5 As Decimal

        vl1 = 67836.43
        vl2 = 36678.66
        vl3 = 29229.88
        vl4 = 27165.48
        vl5 = 19849.53

        Dim total As Decimal

        TextBox1.Text = vl1
        TextBox2.Text = vl2
        TextBox3.Text = vl3
        TextBox4.Text = vl4
        TextBox5.Text = vl5

        total = vl1 + vl2 + vl3 + vl4 + vl5

        TextBox6.Text = Math.Round((vl1 / total) * 100, 2) & "%"
        TextBox7.Text = Math.Round((vl2 / total) * 100, 2) & "%"
        TextBox8.Text = Math.Round((vl3 / total) * 100, 2) & "%"
        TextBox9.Text = Math.Round((vl4 / total) * 100, 2) & "%"
        TextBox10.Text = Math.Round((vl5 / total) * 100, 2) & "%"

    End Sub

    Sub FormatoMoeda()
        TextBox1.Text = "R$ " & TextBox1.Text
        TextBox2.Text = "R$ " & TextBox2.Text
        TextBox3.Text = "R$ " & TextBox3.Text
        TextBox4.Text = "R$ " & TextBox4.Text
        TextBox5.Text = "R$ " & TextBox5.Text
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Percentual()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Percentual()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Percentual()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Percentual()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Percentual()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.ReadOnly = False
        TextBox2.ReadOnly = False
        TextBox3.ReadOnly = False
        TextBox4.ReadOnly = False
        TextBox5.ReadOnly = False
    End Sub
End Class