Imports System.Data.SqlClient





Public Class Form1
    Dim sqlcon As SqlConnection
    Dim sqlstmt As String
    Dim sqlcmd As SqlCommand
    Dim sqlrdr As SqlDataReader
    Dim passvalue As String

    Dim sqlconstring As String

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        If tuser.Text = "sis" And tpass.Text = passvalue Then
            introductionForm2.Show()
            Me.Visible = False
        Else
            MsgBox("password wrong!")
        End If

    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            sqlconstring = "Data Source=USER;Initial Catalog=student_information_system;Integrated Security=True"
            sqlcon = New SqlConnection(sqlconstring)
            sqlcon.Open()
        Catch ex As Exception
            MsgBox("Cannot connect")
        End Try
        sqlstmt = "select *from change_pwd"
        sqlcmd = New SqlCommand(sqlstmt, sqlcon)
        sqlrdr = sqlcmd.ExecuteReader
        While sqlrdr.Read

            passvalue = sqlrdr.Item(1)
        End While
        sqlrdr.Close()
        sqlcmd.Dispose()

    End Sub
End Class


