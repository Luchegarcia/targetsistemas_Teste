
Imports System.Data.OleDb


Public Class Questao3
    Dim ds As New DataSet
    Dim oConn As New OleDb.OleDbConnection
    Dim strOutputDirectory As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Refresh()
        Try
            oConn = New OleDb.OleDbConnection
            oConn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & strOutputDirectory & "\dados.mdb"
            oConn.Open()

            Dim oDA As New OleDbDataAdapter("Select dia , Round(valor,2) As Valor FROM faturamento Where valor =(Select MIN(valor) FROM Faturamento WHERE Valor <> 0)", oConn)

            oDA.Fill(ds)

            DataGridView1.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox("Erro ao acessar o banco de dados: " & ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.Refresh()
        Try
            oConn = New OleDb.OleDbConnection
            oConn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & strOutputDirectory & "\dados.mdb"
            oConn.Open()

            Dim oDA As New OleDbDataAdapter("Select dia , Round(valor,2) as Valor FROM faturamento Where valor =(Select MAX(valor) FROM Faturamento)", oConn)

            oDA.Fill(ds)

            DataGridView1.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox("Erro ao acessar o banco de dados: " & ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.Refresh()
        Try
            oConn = New OleDb.OleDbConnection
            oConn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & strOutputDirectory & "\dados.mdb"
            oConn.Open()

            Dim oDA As New OleDbDataAdapter("Select dia , Round(valor,2) AS Valor FROM faturamento Where valor > (Select SUM(Valor) /30  FROM faturamento)", oConn)

            oDA.Fill(ds)

            DataGridView1.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox("Erro ao acessar o banco de dados: " & ex.Message)
        End Try
    End Sub
End Class