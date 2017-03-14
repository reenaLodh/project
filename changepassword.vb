Imports System.Data.SqlClient

Public Class changepassword
    Dim sqlcon As SqlConnection
    Dim sqlcmd As SqlCommand
    Dim sqlrdr As SqlDataReader
    Dim sqlconstring As String
    Dim sqlstmt As String
    Dim passvalue As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        studentform3.Show()
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sqlstmt = "select *from change.password"
        sqlcmd = New SqlCommand(sqlstmt, sqlcon)
        sqlrdr = sqlcmd.ExecuteReader
        While sqlrdr.Read

            passvalue = sqlrdr.Item(1)
        End While
        sqlrdr.Close()
        sqlcmd.Dispose()

        Try

            If oldpass.Text = passvalue And newname.Text = confirmname.Text Then
                sqlstmt = "update  change.password set pass=" & "'" & confirmname.Text & "'" & "where user_name='sis'"
                sqlcmd = New SqlCommand(sqlstmt, sqlcon)
                sqlrdr = sqlcmd.ExecuteReader
                MsgBox("changed...")
                sqlrdr.Close()
                sqlcmd.Dispose()

            Else
                MsgBox("password didnt match")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub

    Private Sub changepassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlconstring = "Data Source=user;Initial Catalog=student.information.system;Integrated Security=True"

        sqlcon = New SqlConnection(sqlconstring)
        sqlcon.Open()

    End Sub
End Class